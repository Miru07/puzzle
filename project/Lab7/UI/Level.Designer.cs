namespace Lab7
{
    partial class Level
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level));
            this.picture1 = new System.Windows.Forms.Button();
            this.picture2 = new System.Windows.Forms.Button();
            this.picture3 = new System.Windows.Forms.Button();
            this.picture4 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // picture1
            // 
            this.picture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture1.Location = new System.Drawing.Point(89, 47);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(131, 146);
            this.picture1.TabIndex = 0;
            this.picture1.UseVisualStyleBackColor = true;
            this.picture1.Click += new System.EventHandler(this.Picture1_Click);
            // 
            // picture2
            // 
            this.picture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture2.Location = new System.Drawing.Point(268, 47);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(131, 146);
            this.picture2.TabIndex = 1;
            this.picture2.UseVisualStyleBackColor = true;
            this.picture2.Click += new System.EventHandler(this.Picture2_Click);
            // 
            // picture3
            // 
            this.picture3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture3.Location = new System.Drawing.Point(89, 236);
            this.picture3.Name = "picture3";
            this.picture3.Size = new System.Drawing.Size(131, 146);
            this.picture3.TabIndex = 2;
            this.picture3.UseVisualStyleBackColor = true;
            this.picture3.Click += new System.EventHandler(this.Picture3_Click);
            // 
            // picture4
            // 
            this.picture4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture4.Location = new System.Drawing.Point(268, 236);
            this.picture4.Name = "picture4";
            this.picture4.Size = new System.Drawing.Size(131, 146);
            this.picture4.TabIndex = 3;
            this.picture4.UseVisualStyleBackColor = true;
            this.picture4.Click += new System.EventHandler(this.Picture4_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Indigo;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(180, 419);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(125, 41);
            this.exit.TabIndex = 7;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(525, 494);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.picture4);
            this.Controls.Add(this.picture3);
            this.Controls.Add(this.picture2);
            this.Controls.Add(this.picture1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Level";
            this.Text = "Level";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button picture1;
        private System.Windows.Forms.Button picture2;
        private System.Windows.Forms.Button picture3;
        private System.Windows.Forms.Button picture4;
        private System.Windows.Forms.Button exit;
    }
}