namespace TaskManager
{
    partial class Collection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Collection));
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.AvtoLogo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FavoritesButton = new System.Windows.Forms.Button();
            this.VerticalLine = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CollectionLabel = new System.Windows.Forms.Label();
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
            this.pictureLogo.TabIndex = 12;
            this.pictureLogo.TabStop = false;
            // 
            // AvtoLogo
            // 
            this.AvtoLogo.AutoSize = true;
            this.AvtoLogo.BackColor = System.Drawing.Color.Transparent;
            this.AvtoLogo.Font = new System.Drawing.Font("Segoe UI Variable Display", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvtoLogo.Location = new System.Drawing.Point(93, 23);
            this.AvtoLogo.Name = "AvtoLogo";
            this.AvtoLogo.Size = new System.Drawing.Size(105, 49);
            this.AvtoLogo.TabIndex = 11;
            this.AvtoLogo.Text = "Avto";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(1, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 5);
            this.panel1.TabIndex = 13;
            // 
            // FavoritesButton
            // 
            this.FavoritesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FavoritesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FavoritesButton.FlatAppearance.BorderSize = 0;
            this.FavoritesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FavoritesButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FavoritesButton.Location = new System.Drawing.Point(12, 677);
            this.FavoritesButton.Name = "FavoritesButton";
            this.FavoritesButton.Size = new System.Drawing.Size(168, 54);
            this.FavoritesButton.TabIndex = 14;
            this.FavoritesButton.Text = "Назад";
            this.FavoritesButton.UseVisualStyleBackColor = false;
            this.FavoritesButton.Click += new System.EventHandler(this.FavoritesButton_Click);
            // 
            // VerticalLine
            // 
            this.VerticalLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VerticalLine.BackColor = System.Drawing.Color.Black;
            this.VerticalLine.Location = new System.Drawing.Point(222, -7);
            this.VerticalLine.Name = "VerticalLine";
            this.VerticalLine.Size = new System.Drawing.Size(5, 800);
            this.VerticalLine.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(200, 200);
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BackgroundImage = global::TaskManager.Properties.Resources.BackGround2;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(233, 135);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 15, 15, 15);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(951, 645);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // CollectionLabel
            // 
            this.CollectionLabel.AutoSize = true;
            this.CollectionLabel.BackColor = System.Drawing.Color.Transparent;
            this.CollectionLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CollectionLabel.Location = new System.Drawing.Point(495, 23);
            this.CollectionLabel.Name = "CollectionLabel";
            this.CollectionLabel.Size = new System.Drawing.Size(432, 80);
            this.CollectionLabel.TabIndex = 13;
            this.CollectionLabel.Text = "Предложения";
            // 
            // Collection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TaskManager.Properties.Resources.BackGround2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.CollectionLabel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.AvtoLogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FavoritesButton);
            this.Controls.Add(this.VerticalLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Collection";
            this.Text = "Коллекция";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label AvtoLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FavoritesButton;
        private System.Windows.Forms.Panel VerticalLine;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label CollectionLabel;
    }
}