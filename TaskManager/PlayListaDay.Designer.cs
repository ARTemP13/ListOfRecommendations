namespace TaskManager
{
    partial class PlayListaDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayListaDay));
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.AvtoLogo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReccomendationLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.VerticalLine = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.BackgroundImage = global::TaskManager.Properties.Resources.Logo2;
            this.pictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(85, 79);
            this.pictureLogo.TabIndex = 15;
            this.pictureLogo.TabStop = false;
            // 
            // AvtoLogo
            // 
            this.AvtoLogo.AutoSize = true;
            this.AvtoLogo.BackColor = System.Drawing.Color.Transparent;
            this.AvtoLogo.Font = new System.Drawing.Font("Segoe UI Variable Display", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvtoLogo.Location = new System.Drawing.Point(97, 27);
            this.AvtoLogo.Name = "AvtoLogo";
            this.AvtoLogo.Size = new System.Drawing.Size(105, 49);
            this.AvtoLogo.TabIndex = 14;
            this.AvtoLogo.Text = "Avto";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(1, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 5);
            this.panel1.TabIndex = 16;
            // 
            // ReccomendationLabel
            // 
            this.ReccomendationLabel.AutoSize = true;
            this.ReccomendationLabel.BackColor = System.Drawing.Color.Transparent;
            this.ReccomendationLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReccomendationLabel.Location = new System.Drawing.Point(478, 27);
            this.ReccomendationLabel.Name = "ReccomendationLabel";
            this.ReccomendationLabel.Size = new System.Drawing.Size(421, 80);
            this.ReccomendationLabel.TabIndex = 18;
            this.ReccomendationLabel.Text = "Плейлист дня";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(12, 673);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(168, 54);
            this.BackButton.TabIndex = 17;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.FavoritesButton_Click);
            // 
            // VerticalLine
            // 
            this.VerticalLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VerticalLine.BackColor = System.Drawing.Color.Black;
            this.VerticalLine.Location = new System.Drawing.Point(208, 1);
            this.VerticalLine.Name = "VerticalLine";
            this.VerticalLine.Size = new System.Drawing.Size(5, 761);
            this.VerticalLine.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(200, 200);
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BackgroundImage = global::TaskManager.Properties.Resources.BackGround2;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(219, 115);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 15, 15, 15);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(974, 647);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // PlayListaDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TaskManager.Properties.Resources.BackGround2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.AvtoLogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ReccomendationLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.VerticalLine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayListaDay";
            this.Text = "Плейлист дня";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label AvtoLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ReccomendationLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel VerticalLine;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}