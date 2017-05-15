namespace Demo
{
    partial class Player_Login
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
            this.textPass = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.button_Register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(398, 230);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '●';
            this.textPass.Size = new System.Drawing.Size(136, 20);
            this.textPass.TabIndex = 15;
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(398, 156);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(136, 20);
            this.textUsername.TabIndex = 14;
            // 
            // button_Login
            // 
            this.button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.Image = global::Demo.Properties.Resources.blue_rose_wallpaper_border_35_background;
            this.button_Login.Location = new System.Drawing.Point(398, 308);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(110, 36);
            this.button_Login.TabIndex = 13;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_Register
            // 
            this.button_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Register.Image = global::Demo.Properties.Resources.blue_rose_wallpaper_border_35_background;
            this.button_Register.Location = new System.Drawing.Point(259, 308);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(115, 36);
            this.button_Register.TabIndex = 12;
            this.button_Register.Text = "Register";
            this.button_Register.UseVisualStyleBackColor = true;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::Demo.Properties.Resources.blue_rose_wallpaper_border_35_background;
            this.label1.Location = new System.Drawing.Point(268, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::Demo.Properties.Resources.blue_rose_wallpaper_border_35_background;
            this.label2.Location = new System.Drawing.Point(306, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(234, 41);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(339, 46);
            this.Title.TabIndex = 9;
            this.Title.Text = "MEMORY GAME";
            // 
            // Player_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Demo.Properties.Resources.Qirin_Mountain_v3;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Title);
            this.Name = "Player_Login";
            this.Text = "Player_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Title;
    }
}