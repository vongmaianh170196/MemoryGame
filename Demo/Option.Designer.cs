namespace Demo
{
    partial class Object_Option
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Object_Option));
            this.Title = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PLAY = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Private = new System.Windows.Forms.CheckBox();
            this.Public = new System.Windows.Forms.CheckBox();
            this.two = new System.Windows.Forms.CheckBox();
            this.single = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(231, 38);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(339, 46);
            this.Title.TabIndex = 1;
            this.Title.Text = "MEMORY GAME";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(444, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Upload ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(235, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Upload game objects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(191, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose number of players";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(191, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Choose number of objects";
            // 
            // PLAY
            // 
            this.PLAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLAY.Image = ((System.Drawing.Image)(resources.GetObject("PLAY.Image")));
            this.PLAY.Location = new System.Drawing.Point(349, 401);
            this.PLAY.Name = "PLAY";
            this.PLAY.Size = new System.Drawing.Size(138, 28);
            this.PLAY.TabIndex = 10;
            this.PLAY.Text = "PLAY";
            this.PLAY.UseVisualStyleBackColor = true;
            this.PLAY.Click += new System.EventHandler(this.PLAY_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox1.Location = new System.Drawing.Point(444, 268);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(38, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "20";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox8.Location = new System.Drawing.Point(503, 268);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(38, 17);
            this.checkBox8.TabIndex = 3;
            this.checkBox8.Text = "24";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox9.Location = new System.Drawing.Point(560, 268);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(38, 17);
            this.checkBox9.TabIndex = 0;
            this.checkBox9.Text = "30";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(237, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Choose Game mode";
            // 
            // Private
            // 
            this.Private.AutoSize = true;
            this.Private.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Private.Location = new System.Drawing.Point(444, 334);
            this.Private.Name = "Private";
            this.Private.Size = new System.Drawing.Size(59, 17);
            this.Private.TabIndex = 0;
            this.Private.Text = "Private";
            this.Private.UseVisualStyleBackColor = true;
            // 
            // Public
            // 
            this.Public.AutoSize = true;
            this.Public.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Public.Location = new System.Drawing.Point(560, 334);
            this.Public.Name = "Public";
            this.Public.Size = new System.Drawing.Size(55, 17);
            this.Public.TabIndex = 1;
            this.Public.Text = "Public";
            this.Public.UseVisualStyleBackColor = true;
            // 
            // two
            // 
            this.two.AutoSize = true;
            this.two.ForeColor = System.Drawing.SystemColors.ControlText;
            this.two.Location = new System.Drawing.Point(560, 208);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(68, 17);
            this.two.TabIndex = 1;
            this.two.Text = "2 players";
            this.two.UseVisualStyleBackColor = true;
            // 
            // single
            // 
            this.single.AutoSize = true;
            this.single.ForeColor = System.Drawing.SystemColors.ControlText;
            this.single.Location = new System.Drawing.Point(446, 208);
            this.single.Name = "single";
            this.single.Size = new System.Drawing.Size(86, 17);
            this.single.TabIndex = 0;
            this.single.Text = "Single player";
            this.single.UseVisualStyleBackColor = true;
            // 
            // Object_Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Demo.Properties.Resources.Qirin_Mountain_v3;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.single);
            this.Controls.Add(this.Private);
            this.Controls.Add(this.two);
            this.Controls.Add(this.Public);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PLAY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Title);
            this.Name = "Object_Option";
            this.Text = "Option";
            this.Load += new System.EventHandler(this.Object_Option_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PLAY;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Private;
        private System.Windows.Forms.CheckBox Public;
        private System.Windows.Forms.CheckBox two;
        private System.Windows.Forms.CheckBox single;
    }
}