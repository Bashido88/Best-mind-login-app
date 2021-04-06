
namespace OliveiraTradeFrontPage
{
    partial class SingPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblusuario = new System.Windows.Forms.Label();
            this.txbuser = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txbpass = new System.Windows.Forms.TextBox();
            this.lblconfirma = new System.Windows.Forms.Label();
            this.txbconfirma = new System.Windows.Forms.TextBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(62, 77);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(47, 15);
            this.lblusuario.TabIndex = 0;
            this.lblusuario.Text = "Usuario";
            // 
            // txbuser
            // 
            this.txbuser.Location = new System.Drawing.Point(62, 95);
            this.txbuser.Name = "txbuser";
            this.txbuser.Size = new System.Drawing.Size(151, 23);
            this.txbuser.TabIndex = 1;
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(62, 142);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(39, 15);
            this.lblsenha.TabIndex = 2;
            this.lblsenha.Text = "Senha";
            // 
            // txbpass
            // 
            this.txbpass.Location = new System.Drawing.Point(62, 160);
            this.txbpass.Name = "txbpass";
            this.txbpass.PasswordChar = '*';
            this.txbpass.Size = new System.Drawing.Size(151, 23);
            this.txbpass.TabIndex = 3;
            // 
            // lblconfirma
            // 
            this.lblconfirma.AutoSize = true;
            this.lblconfirma.Location = new System.Drawing.Point(62, 206);
            this.lblconfirma.Name = "lblconfirma";
            this.lblconfirma.Size = new System.Drawing.Size(101, 15);
            this.lblconfirma.TabIndex = 4;
            this.lblconfirma.Text = "Confirme a Senha";
            // 
            // txbconfirma
            // 
            this.txbconfirma.Location = new System.Drawing.Point(62, 224);
            this.txbconfirma.Name = "txbconfirma";
            this.txbconfirma.PasswordChar = '*';
            this.txbconfirma.Size = new System.Drawing.Size(151, 23);
            this.txbconfirma.TabIndex = 5;
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(99, 274);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(75, 23);
            this.btncadastrar.TabIndex = 6;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // SingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 332);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txbconfirma);
            this.Controls.Add(this.lblconfirma);
            this.Controls.Add(this.txbpass);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.txbuser);
            this.Controls.Add(this.lblusuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SingPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox txbuser;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txbpass;
        private System.Windows.Forms.Label lblconfirma;
        private System.Windows.Forms.TextBox txbconfirma;
        private System.Windows.Forms.Button btncadastrar;
    }
}