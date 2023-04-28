namespace TaskManager
{
    partial class Selections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selections));
            this.AvtoLogo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VerticalLine = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ReccomendationLabel = new System.Windows.Forms.Label();
            this.FavoritesButton = new System.Windows.Forms.Button();
            this.AddPlayList = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AvtoLogo
            // 
            this.AvtoLogo.AutoSize = true;
            this.AvtoLogo.BackColor = System.Drawing.Color.Transparent;
            this.AvtoLogo.Font = new System.Drawing.Font("Segoe UI Variable Display", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvtoLogo.Location = new System.Drawing.Point(91, 25);
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
            this.panel1.Location = new System.Drawing.Point(-5, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 5);
            this.panel1.TabIndex = 13;
            // 
            // VerticalLine
            // 
            this.VerticalLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VerticalLine.BackColor = System.Drawing.Color.Black;
            this.VerticalLine.Location = new System.Drawing.Point(202, -3);
            this.VerticalLine.Name = "VerticalLine";
            this.VerticalLine.Size = new System.Drawing.Size(5, 761);
            this.VerticalLine.TabIndex = 10;
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(200, 200);
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BackgroundImage = global::TaskManager.Properties.Resources.BackGround2;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(213, 116);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 15, 15, 15);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(972, 647);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // ReccomendationLabel
            // 
            this.ReccomendationLabel.AutoSize = true;
            this.ReccomendationLabel.BackColor = System.Drawing.Color.Transparent;
            this.ReccomendationLabel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReccomendationLabel.Location = new System.Drawing.Point(469, 22);
            this.ReccomendationLabel.Name = "ReccomendationLabel";
            this.ReccomendationLabel.Size = new System.Drawing.Size(352, 80);
            this.ReccomendationLabel.TabIndex = 15;
            this.ReccomendationLabel.Text = "Плейлисты";
            // 
            // FavoritesButton
            // 
            this.FavoritesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FavoritesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FavoritesButton.FlatAppearance.BorderSize = 0;
            this.FavoritesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FavoritesButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FavoritesButton.Location = new System.Drawing.Point(12, 671);
            this.FavoritesButton.Name = "FavoritesButton";
            this.FavoritesButton.Size = new System.Drawing.Size(169, 59);
            this.FavoritesButton.TabIndex = 14;
            this.FavoritesButton.Text = "Назад";
            this.FavoritesButton.UseVisualStyleBackColor = false;
            this.FavoritesButton.Click += new System.EventHandler(this.FavoritesButton_Click);
            // 
            // AddPlayList
            // 
            this.AddPlayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddPlayList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPlayList.FlatAppearance.BorderSize = 0;
            this.AddPlayList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPlayList.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPlayList.Location = new System.Drawing.Point(12, 133);
            this.AddPlayList.Name = "AddPlayList";
            this.AddPlayList.Size = new System.Drawing.Size(169, 59);
            this.AddPlayList.TabIndex = 17;
            this.AddPlayList.Text = "Добавить плейлист";
            this.AddPlayList.UseVisualStyleBackColor = false;
            this.AddPlayList.Click += new System.EventHandler(this.AddPlayList_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::TaskManager.Properties.Resources.BackGround2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 285);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(447, -1);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(25, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(41, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(373, 59);
            this.button1.TabIndex = 18;
            this.button1.Text = "Создать плейлист";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(41, 121);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 47);
            this.textBox1.TabIndex = 2;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(357, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создание плейлиста";
            // 
            // Selections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TaskManager.Properties.Resources.BackGround2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AddPlayList);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ReccomendationLabel);
            this.Controls.Add(this.FavoritesButton);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.AvtoLogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VerticalLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Selections";
            this.Text = "Коллекции";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label AvtoLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel VerticalLine;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label ReccomendationLabel;
        private System.Windows.Forms.Button FavoritesButton;
        private System.Windows.Forms.Button AddPlayList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}