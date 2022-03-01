
namespace ChatCliente
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_ServidorIP = new System.Windows.Forms.TextBox();
            this.num_PortaHost = new System.Windows.Forms.NumericUpDown();
            this.btn_Conectar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Log = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_Mensagem = new System.Windows.Forms.TextBox();
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_Status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_PortaHost)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_ServidorIP
            // 
            this.txt_ServidorIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ServidorIP.Location = new System.Drawing.Point(6, 19);
            this.txt_ServidorIP.Name = "txt_ServidorIP";
            this.txt_ServidorIP.Size = new System.Drawing.Size(468, 30);
            this.txt_ServidorIP.TabIndex = 0;
            this.txt_ServidorIP.Text = "127.0.0.1";
            // 
            // num_PortaHost
            // 
            this.num_PortaHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_PortaHost.Location = new System.Drawing.Point(480, 20);
            this.num_PortaHost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.num_PortaHost.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_PortaHost.Name = "num_PortaHost";
            this.num_PortaHost.Size = new System.Drawing.Size(136, 30);
            this.num_PortaHost.TabIndex = 1;
            this.num_PortaHost.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btn_Conectar
            // 
            this.btn_Conectar.Location = new System.Drawing.Point(480, 55);
            this.btn_Conectar.Name = "btn_Conectar";
            this.btn_Conectar.Size = new System.Drawing.Size(136, 30);
            this.btn_Conectar.TabIndex = 2;
            this.btn_Conectar.Text = "Conectar";
            this.btn_Conectar.UseVisualStyleBackColor = true;
            this.btn_Conectar.Click += new System.EventHandler(this.btn_Conectar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_Conectar);
            this.panel1.Controls.Add(this.txt_Usuario);
            this.panel1.Controls.Add(this.num_PortaHost);
            this.panel1.Controls.Add(this.txt_ServidorIP);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 100);
            this.panel1.TabIndex = 3;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.Location = new System.Drawing.Point(6, 55);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(468, 30);
            this.txt_Usuario.TabIndex = 2;
            this.txt_Usuario.Text = "Visitante";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txt_Log);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 508);
            this.panel2.TabIndex = 4;
            // 
            // txt_Log
            // 
            this.txt_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Log.Location = new System.Drawing.Point(6, 4);
            this.txt_Log.Multiline = true;
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.ReadOnly = true;
            this.txt_Log.Size = new System.Drawing.Size(610, 497);
            this.txt_Log.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txt_Mensagem);
            this.panel3.Controls.Add(this.btn_Enviar);
            this.panel3.Location = new System.Drawing.Point(12, 632);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(627, 67);
            this.panel3.TabIndex = 4;
            // 
            // txt_Mensagem
            // 
            this.txt_Mensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mensagem.Location = new System.Drawing.Point(6, 21);
            this.txt_Mensagem.Name = "txt_Mensagem";
            this.txt_Mensagem.Size = new System.Drawing.Size(468, 30);
            this.txt_Mensagem.TabIndex = 3;
            this.txt_Mensagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Mensagem_KeyPress);
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.Location = new System.Drawing.Point(480, 21);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(136, 30);
            this.btn_Enviar.TabIndex = 3;
            this.btn_Enviar.Text = "Enviar";
            this.btn_Enviar.UseVisualStyleBackColor = true;
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label_Status);
            this.panel4.Location = new System.Drawing.Point(12, 705);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(627, 92);
            this.panel4.TabIndex = 5;
            // 
            // label_Status
            // 
            this.label_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_Status.Location = new System.Drawing.Point(6, 13);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(610, 44);
            this.label_Status.TabIndex = 0;
            this.label_Status.Text = "Não Conectado...";
            this.label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 809);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.num_PortaHost)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ServidorIP;
        private System.Windows.Forms.NumericUpDown num_PortaHost;
        private System.Windows.Forms.Button btn_Conectar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_Mensagem;
        private System.Windows.Forms.Button btn_Enviar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.TextBox txt_Log;
    }
}

