namespace AplikacjaWS
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButttonEnter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            resources.ApplyResources(this.textBoxLogin, "textBoxLogin");
            this.textBoxLogin.ForeColor = System.Drawing.Color.Gray;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            this.textBoxLogin.Leave += new System.EventHandler(this.textBoxLogin_Leave);
            // 
            // textBoxPassword
            // 
            resources.ApplyResources(this.textBoxPassword, "textBoxPassword");
            this.textBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ButttonEnter
            // 
            resources.ApplyResources(this.ButttonEnter, "ButttonEnter");
            this.ButttonEnter.Name = "ButttonEnter";
            this.ButttonEnter.UseVisualStyleBackColor = true;
            this.ButttonEnter.Click += new System.EventHandler(this.ButttonEnter_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::AplikacjaWS.Properties.Resources._352525_lock_icon;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxLogin
            // 
            resources.ApplyResources(this.pictureBoxLogin, "pictureBoxLogin");
            this.pictureBoxLogin.Image = global::AplikacjaWS.Properties.Resources.user_icon;
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.TabStop = false;
            // 
            // RegisterForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButttonEnter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButttonEnter;
        private System.Windows.Forms.Label label2;
    }
}