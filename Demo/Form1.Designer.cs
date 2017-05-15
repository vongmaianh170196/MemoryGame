namespace Demo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Register = new System.Windows.Forms.Button();
            this.button_Login = new System.Windows.Forms.Button();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Title.Location = new System.Drawing.Point(264, 65);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(339, 46);
            this.Title.TabIndex = 0;
            this.Title.Text = "MEMORY GAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(289, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(289, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // button_Register
            // 
            this.button_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Register.Image = ((System.Drawing.Image)(resources.GetObject("button_Register.Image")));
            this.button_Register.Location = new System.Drawing.Point(294, 322);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(115, 36);
            this.button_Register.TabIndex = 5;
            this.button_Register.Text = "Register";
            this.button_Register.UseVisualStyleBackColor = true;
            this.button_Register.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Login
            // 
            this.button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.Image = ((System.Drawing.Image)(resources.GetObject("button_Login.Image")));
            this.button_Login.Location = new System.Drawing.Point(445, 322);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(110, 36);
            this.button_Login.TabIndex = 6;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button2_Click);
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(419, 170);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(136, 20);
            this.textUsername.TabIndex = 7;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(419, 244);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '●';
            this.textPass.Size = new System.Drawing.Size(136, 20);
            this.textPass.TabIndex = 8;
            // 
            // Form1
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPass;
    }
}

