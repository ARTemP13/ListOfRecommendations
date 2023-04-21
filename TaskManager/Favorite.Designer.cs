namespace TaskManager
{
    partial class Favorite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Favorite));
            this.HorizontLine = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.AvtoLogo = new System.Windows.Forms.Label();
            this.VerticalLine = new System.Windows.Forms.Panel();
            this.flowLayoutPanelFavorite = new System.Windows.Forms.FlowLayoutPanel();
            this.FacoriteLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // HorizontLine
            // 
            this.HorizontLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HorizontLine.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HorizontLine.Location = new System.Drawing.Point(1, 121);
            this.HorizontLine.Name = "HorizontLine";
            this.HorizontLine.Size = new System.Drawing.Size(244, 5);
            this.HorizontLine.TabIndex = 12;
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.BackgroundImage = global::TaskManager.Properties.Resources.Logo2;
            this.pictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(85, 79);
            this.pictureLogo.TabIndex = 11;
            this.pictureLogo.TabStop = false;
            // 
            // AvtoLogo
            // 
            this.AvtoLogo.AutoSize = true;
            this.AvtoLogo.BackColor = System.Drawing.Color.Transparent;
            this.AvtoLogo.Font = new System.Drawing.Font("Segoe UI Variable Display", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvtoLogo.Location = new System.Drawing.Point(100, 25);
            this.AvtoLogo.Name = "AvtoLogo";
            this.AvtoLogo.Size = new System.Drawing.Size(105, 49);
            this.AvtoLogo.TabIndex = 10;
            this.AvtoLogo.Text = "Avto";
            // 
            // VerticalLine
            // 
            this.VerticalLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VerticalLine.BackColor = System.Drawing.Color.Black;
            this.VerticalLine.Location = new System.Drawing.Point(211, -3);
            this.VerticalLine.Name = "VerticalLine";
            this.VerticalLine.Size = new System.Drawing.Size(5, 761);
            this.VerticalLine.TabIndex = 9;
            // 
            // flowLayoutPanelFavorite
            // 
            this.flowLayoutPanelFavorite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelFavorite.AutoScroll = true;
            this.flowLayoutPanelFavorite.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelFavorite.BackgroundImage = global::TaskManager.Properties.Resources.BackGround2;
            this.flowLayoutPanelFavorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanelFavorite.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelFavorite.Location = new System.Drawing.Point(219, 121);
            this.flowLayoutPanelFavorite.Name = "flowLayoutPanelFavorite";
            this.flowLayoutPanelFavorite.Padding = new System.Windows.Forms.Padding(0, 15, 15, 15);
            this.flowLayoutPanelFavorite.Size = new System.Drawing.Size(993, 637);
            this.flowLayoutPanelFavorite.TabIndex = 14;
            // 
            // FacoriteLabel
            // 
            this.FacoriteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FacoriteLabel.AutoSize = true;
            this.FacoriteLabel.BackColor = System.Drawing.Color.Transparent;
            this.FacoriteLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FacoriteLabel.Location = new System.Drawing.Point(456, 25);
            this.FacoriteLabel.Name = "FacoriteLabel";
            this.FacoriteLabel.Size = new System.Drawing.Size(349, 80);
            this.FacoriteLabel.TabIndex = 13;
            this.FacoriteLabel.Text = "Избранное";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(12, 687);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(168, 54);
            this.BackButton.TabIndex = 15;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Favorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TaskManager.Properties.Resources.BackGround2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1214, 753);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.FacoriteLabel);
            this.Controls.Add(this.flowLayoutPanelFavorite);
            this.Controls.Add(this.HorizontLine);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.AvtoLogo);
            this.Controls.Add(this.VerticalLine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Favorite";
            this.Text = "Favorite";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Favorite_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HorizontLine;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label AvtoLogo;
        private System.Windows.Forms.Panel VerticalLine;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFavorite;
        private System.Windows.Forms.Label FacoriteLabel;
        private System.Windows.Forms.Button BackButton;
    }
}