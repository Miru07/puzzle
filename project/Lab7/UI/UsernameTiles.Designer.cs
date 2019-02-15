namespace Lab7
{
    partial class UsernameTiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsernameTiles));
            this.tilesNrLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nrTilesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tilesNrLabel
            // 
            this.tilesNrLabel.AutoSize = true;
            this.tilesNrLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.tilesNrLabel.ForeColor = System.Drawing.Color.White;
            this.tilesNrLabel.Location = new System.Drawing.Point(12, 75);
            this.tilesNrLabel.Name = "tilesNrLabel";
            this.tilesNrLabel.Size = new System.Drawing.Size(171, 18);
            this.tilesNrLabel.TabIndex = 1;
            this.tilesNrLabel.Text = "Number of tiles (n) : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(134, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go ^^";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // nrTilesTextBox
            // 
            this.nrTilesTextBox.Location = new System.Drawing.Point(188, 76);
            this.nrTilesTextBox.Name = "nrTilesTextBox";
            this.nrTilesTextBox.Size = new System.Drawing.Size(83, 20);
            this.nrTilesTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "(the picture will be divided into n x n tiles)";
            // 
            // UsernameTiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(368, 241);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nrTilesTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tilesNrLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsernameTiles";
            this.Text = "UsernameTiles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tilesNrLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nrTilesTextBox;
        private System.Windows.Forms.Label label1;
    }
}