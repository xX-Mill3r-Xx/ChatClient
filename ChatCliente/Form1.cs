using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatCliente
{
    public partial class Form1 : Form
    {
        private string NomeUsuario;
        private StreamWriter stwEnviador;
        private StreamReader strReceptor;
        private TcpClient tcpServidor;
        // Nessesario para atualizar o formulario com mensagens da outra Thread
        private delegate void AtualizaLogCallBack(string strMensagem);
        // Nessesario para definir o formulario para o estado "disconnected" de outra Thread
        private delegate void FecharConexaoCallBack(string strMotivo);
        private Thread mensagemThread;
        private IPAddress enderecoIP;
        private int portaHost;
        private bool Conectado;

        public Form1()
        {
            // na saida da aplicação : Desconectar
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            InitializeComponent();
        }

        private void btn_Conectar_Click(object sender, EventArgs e)
        {
            if (!Conectado)
            {
                //inicializa conexao
                InicializaConexao();
            }
            else
            {
                //se estar conectado então desconecta
                FecharConexao("Desconectado a pedido do Usuario!");
            }
        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            EnviarMensagem();
        }

        private void txt_Mensagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se pressionou a tecla enter
            if(e.KeyChar == (char)13)
            {
                EnviarMensagem();
            }
        }

        private void InicializaConexao()
        {
            try
            {
                // Trata o endereço IP informando em um objeto IPAdress
                enderecoIP = IPAddress.Parse(txt_ServidorIP.Text);
                portaHost = (int)num_PortaHost.Value;
                //Inicia uma nova conexão TCP com o servidor chat
                tcpServidor = new TcpClient();
                tcpServidor.Connect(enderecoIP, portaHost);

                // Ajuda a verificar se estamos conectados ou não
                Conectado = true;

                // Prepara o usuario
                NomeUsuario = txt_Usuario.Text;

                // Desabilita e habilita os campos apropiados
                txt_ServidorIP.Enabled = false;
                num_PortaHost.Enabled = false;
                txt_Usuario.Enabled = false;
                txt_Mensagem.Enabled = true;
                btn_Enviar.Enabled = true;
                btn_Conectar.ForeColor = Color.Red;
                btn_Conectar.Text = "Desconectar";

                // enviar o nome do usuario para o servidor
                stwEnviador = new StreamWriter(tcpServidor.GetStream());
                stwEnviador.WriteLine(txt_Usuario.Text);
                stwEnviador.Flush();

                //Inicia a Thread para receber mensagens e nova comunicação
                mensagemThread = new Thread(new ThreadStart(ReceberMensagens));
                mensagemThread.IsBackground = true;
                mensagemThread.Start();

                label_Status.Invoke(new Action(() =>
                {
                    label_Status.ForeColor = Color.Green;
                    label_Status.Text = $"Conectado ao Servidor de Chat {enderecoIP}:{portaHost}";
                }));
            }
            catch (Exception ex)
            {
                label_Status.Invoke(new Action(() =>
                {
                    label_Status.ForeColor = Color.Red;
                    label_Status.Text = "Erro na conexão com o servidor: \n" + ex.Message;
                }));
            }
        }

        private void ReceberMensagens()
        {
            // recebe a resposta do servidor
            strReceptor = new StreamReader(tcpServidor.GetStream());
            string ConResposta = strReceptor.ReadLine();
            // Se o primeiro caractere da resposta é 1 a conexao foi feita com sucesso
            if(ConResposta[0] == '1')
            {
                // Atualiza o formulario para informar que esta conectado
                this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] { "Conectado com Sucesso!" });
            }
            else
            {
                string Motivo = "Não Conectado: ";
                Motivo += ConResposta.Substring(2, ConResposta.Length - 2);
                this.Invoke(new FecharConexaoCallBack(this.FecharConexao), new object[] { Motivo });
                return;
            }

            while (Conectado)
            {
                this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] { strReceptor.ReadLine() });
            }
        }

        private void AtualizaLog(string strMensagem)
        {
            txt_Log.AppendText(strMensagem + "\r\n");
        }

        private void EnviarMensagem()
        {
            if(txt_Mensagem.Lines.Length >= 1)
            {
                stwEnviador.WriteLine(txt_Mensagem.Text);
                stwEnviador.Flush();
                txt_Mensagem.Lines = null;
            }
            txt_Mensagem.Text = "";
        }

        private void FecharConexao(string Motivo)
        {
            txt_Log.AppendText(Motivo + "\r\n");
            txt_ServidorIP.Enabled = true;
            num_PortaHost.Enabled = true;
            txt_Usuario.Enabled = true;
            txt_Mensagem.Enabled = false;
            btn_Conectar.ForeColor = Color.Green;
            btn_Conectar.Text = "Conectar";

            Conectado = false;
            stwEnviador.Close();
            strReceptor.Close();
            tcpServidor.Close();

            label_Status.Invoke(new Action(() =>
            {
                label_Status.ForeColor = Color.Green;
                label_Status.Text = $"Desconectado do Servidor de Chat{enderecoIP}:{portaHost}";
            }));
        }

        public void OnApplicationExit(object sender, EventArgs e)
        {
            if (Conectado)
            {
                Conectado = false;
                stwEnviador.Close();
                strReceptor.Close();
                tcpServidor.Close();

                label_Status.Invoke(new Action(() =>
                {
                    label_Status.ForeColor = Color.Green;
                    label_Status.Text = $"Desconectado do Servidor de Chat{enderecoIP}:{portaHost}";
                }));
            }
           
        }
    }
}
