namespace Demo
{
    partial class Upload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upload));
            this.Browse = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.OldopenFile = new System.Windows.Forms.OpenFileDialog();
            this.Panel_images = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Browse.BackgroundImage")));
            this.Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.Location = new System.Drawing.Point(210, 307);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(154, 40);
            this.Browse.TabIndex = 2;
            this.Browse.Text = "Browse image....";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Save
            // 
            this.Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save.BackgroundImage")));
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(398, 307);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(154, 40);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save to Game";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // OldopenFile
            // 
            this.OldopenFile.FileName = "oldOpenFile";
            // 
            // Panel_images
            // 
            this.Panel_images.BackColor = System.Drawing.Color.Transparent;
            this.Panel_images.Location = new System.Drawing.Point(90, 68);
            this.Panel_images.Name = "Panel_images";
            this.Panel_images.Size = new System.Drawing.Size(579, 224);
            this.Panel_images.TabIndex = 9;
            // 
            // back
            // 
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(304, 375);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(154, 40);
            this.back.TabIndex = 4;
            this.back.Text = "Back to Option";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Demo.Properties.Resources.Qirin_Mountain_v3;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Panel_images);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Browse);
            this.Name = "Upload";
            this.Text = "Upload";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.OpenFileDialog OldopenFile;
        private System.Windows.Forms.Panel Panel_images;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}