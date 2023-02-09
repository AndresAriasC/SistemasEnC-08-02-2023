namespace TrabajoPractico
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.campoUser = new System.Windows.Forms.TextBox();
            this.campoPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.barraLogin = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblPor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // campoUser
            // 
            this.campoUser.Location = new System.Drawing.Point(169, 55);
            this.campoUser.Name = "campoUser";
            this.campoUser.Size = new System.Drawing.Size(100, 20);
            this.campoUser.TabIndex = 2;
            // 
            // campoPass
            // 
            this.campoPass.Location = new System.Drawing.Point(169, 95);
            this.campoPass.Name = "campoPass";
            this.campoPass.Size = new System.Drawing.Size(100, 20);
            this.campoPass.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // barraLogin
            // 
            this.barraLogin.BackColor = System.Drawing.Color.Coral;
            this.barraLogin.ForeColor = System.Drawing.Color.Red;
            this.barraLogin.Location = new System.Drawing.Point(89, 185);
            this.barraLogin.Name = "barraLogin";
            this.barraLogin.Size = new System.Drawing.Size(180, 23);
            this.barraLogin.Step = 1;
            this.barraLogin.TabIndex = 14;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblPor
            // 
            this.lblPor.AutoSize = true;
            this.lblPor.Location = new System.Drawing.Point(276, 190);
            this.lblPor.Name = "lblPor";
            this.lblPor.Size = new System.Drawing.Size(0, 13);
            this.lblPor.TabIndex = 15;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 260);
            this.Controls.Add(this.lblPor);
            this.Controls.Add(this.barraLogin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.campoPass);
            this.Controls.Add(this.campoUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox campoUser;
        private System.Windows.Forms.TextBox campoPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        protected System.Windows.Forms.ProgressBar barraLogin;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblPor;
    }
}