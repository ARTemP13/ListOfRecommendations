﻿namespace TaskManager
{
    partial class Favorites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Favorites));
            this.BackButton = new System.Windows.Forms.Button();
            this.FavoriteLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanelFavorite = new System.Windows.Forms.FlowLayoutPanel();
            this.VerticalLine = new System.Windows.Forms.Panel();
            this.HorizontLine = new System.Windows.Forms.Panel();
            this.AvtoLogo = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
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
            this.BackButton.TabIndex = 18;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // FavoriteLabel
            // 
            this.FavoriteLabel.AutoSize = true;
            this.FavoriteLabel.BackColor = System.Drawing.Color.Transparent;
            this.FavoriteLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FavoriteLabel.Location = new System.Drawing.Point(478, 24);
            this.FavoriteLabel.Name = "FavoriteLabel";
            this.FavoriteLabel.Size = new System.Drawing.Size(349, 80);
            this.FavoriteLabel.TabIndex = 19;
            this.FavoriteLabel.Text = "Избранное";
            // 
            // flowLayoutPanelFavorite
            // 
            this.flowLayoutPanelFavorite.AutoScroll = true;
            this.flowLayoutPanelFavorite.AutoScrollMargin = new System.Drawing.Size(200, 200);
            this.flowLayoutPanelFavorite.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelFavorite.BackgroundImage = global::TaskManager.Properties.Resources.BackGround2;
            this.flowLayoutPanelFavorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanelFavorite.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelFavorite.Location = new System.Drawing.Point(207, 118);
            this.flowLayoutPanelFavorite.Name = "flowLayoutPanelFavorite";
            this.flowLayoutPanelFavorite.Padding = new System.Windows.Forms.Padding(0, 15, 15, 15);
            this.flowLayoutPanelFavorite.Size = new System.Drawing.Size(987, 614);
            this.flowLayoutPanelFavorite.TabIndex = 20;
            // 
            // VerticalLine
            // 
            this.VerticalLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VerticalLine.BackColor = System.Drawing.Color.Black;
            this.VerticalLine.Location = new System.Drawing.Point(196, -4);
            this.VerticalLine.Name = "VerticalLine";
            this.VerticalLine.Size = new System.Drawing.Size(5, 761);
            this.VerticalLine.TabIndex = 14;
            // 
            // HorizontLine
            // 
            this.HorizontLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HorizontLine.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HorizontLine.Location = new System.Drawing.Point(-11, 118);
            this.HorizontLine.Name = "HorizontLine";
            this.HorizontLine.Size = new System.Drawing.Size(212, 5);
            this.HorizontLine.TabIndex = 17;
            // 
            // AvtoLogo
            // 
            this.AvtoLogo.AutoSize = true;
            this.AvtoLogo.BackColor = System.Drawing.Color.Transparent;
            this.AvtoLogo.Font = new System.Drawing.Font("Segoe UI Variable Display", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvtoLogo.Location = new System.Drawing.Point(85, 24);
            this.AvtoLogo.Name = "AvtoLogo";
            this.AvtoLogo.Size = new System.Drawing.Size(105, 49);
            this.AvtoLogo.TabIndex = 15;
            this.AvtoLogo.Text = "Avto";
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.BackgroundImage = global::TaskManager.Properties.Resources.Logo2;
            this.pictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureLogo.Location = new System.Drawing.Point(6, 11);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(85, 79);
            this.pictureLogo.TabIndex = 16;
            this.pictureLogo.TabStop = false;
            // 
            // Favorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TaskManager.Properties.Resources.BackGround2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.flowLayoutPanelFavorite);
            this.Controls.Add(this.FavoriteLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.HorizontLine);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.AvtoLogo);
            this.Controls.Add(this.VerticalLine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Favorites";
            this.Text = "Favorites";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label FavoriteLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFavorite;
        private System.Windows.Forms.Panel VerticalLine;
        private System.Windows.Forms.Panel HorizontLine;
        private System.Windows.Forms.Label AvtoLogo;
        private System.Windows.Forms.PictureBox pictureLogo;
    }
}