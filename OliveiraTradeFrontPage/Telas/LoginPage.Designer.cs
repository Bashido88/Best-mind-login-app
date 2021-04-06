
namespace OliveiraTradeFrontPage
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnsing = new System.Windows.Forms.Button();
            this.usuariotxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.Menu;
            this.btnlogin.Location = new System.Drawing.Point(87, 278);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(145, 23);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // btnsing
            // 
            this.btnsing.Location = new System.Drawing.Point(87, 337);
            this.btnsing.Name = "btnsing";
            this.btnsing.Size = new System.Drawing.Size(145, 23);
            this.btnsing.TabIndex = 1;
            this.btnsing.Text = "Criar conta";
            this.btnsing.UseVisualStyleBackColor = true;
            this.btnsing.Click += new System.EventHandler(this.btnsing_Click);
            // 
            // usuariotxt
            // 
            this.usuariotxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.usuariotxt.Location = new System.Drawing.Point(36, 149);
            this.usuariotxt.Multiline = true;
            this.usuariotxt.Name = "usuariotxt";
            this.usuariotxt.Size = new System.Drawing.Size(239, 23);
            this.usuariotxt.TabIndex = 2;
            this.usuariotxt.UseWaitCursor = true;
            // 
            // passtxt
            // 
            this.passtxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.passtxt.Location = new System.Drawing.Point(36, 214);
            this.passtxt.Multiline = true;
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.Size = new System.Drawing.Size(239, 23);
            this.passtxt.TabIndex = 3;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(36, 121);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(47, 15);
            this.lblusuario.TabIndex = 4;
            this.lblusuario.Text = "Usuario";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(36, 185);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(39, 15);
            this.lblsenha.TabIndex = 5;
            this.lblsenha.Text = "Senha";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 513);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usuariotxt);
            this.Controls.Add(this.btnsing);
            this.Controls.Add(this.btnlogin);
            this.MaximizeBox = false;
            this.Name = "LoginPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oliveira Trade Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnsing;
        private System.Windows.Forms.TextBox usuariotxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblsenha;
    }
}

