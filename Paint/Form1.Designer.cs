namespace Paint
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
            this.Canvas = new System.Windows.Forms.Panel();
            this.radioButtonElipse = new System.Windows.Forms.RadioButton();
            this.radioButtonBrush = new System.Windows.Forms.RadioButton();
            this.radioButtonRect = new System.Windows.Forms.RadioButton();
            this.Instruments = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxRed = new System.Windows.Forms.PictureBox();
            this.pictureBoxOrange = new System.Windows.Forms.PictureBox();
            this.pictureBoxYellow = new System.Windows.Forms.PictureBox();
            this.pictureBoxGreen = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlue = new System.Windows.Forms.PictureBox();
            this.pictureBoxPurple = new System.Windows.Forms.PictureBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.fontSize = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxBlack = new System.Windows.Forms.PictureBox();
            this.pictureBoxEraser = new System.Windows.Forms.PictureBox();
            this.Canvas.SuspendLayout();
            this.Instruments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPurple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEraser)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.Controls.Add(this.pictureBoxEraser);
            this.Canvas.Controls.Add(this.fontSize);
            this.Canvas.Controls.Add(this.radioButtonElipse);
            this.Canvas.Controls.Add(this.radioButtonBrush);
            this.Canvas.Controls.Add(this.radioButtonRect);
            this.Canvas.Controls.Add(this.Instruments);
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(0, 0);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(800, 450);
            this.Canvas.TabIndex = 0;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // radioButtonElipse
            // 
            this.radioButtonElipse.AutoSize = true;
            this.radioButtonElipse.Location = new System.Drawing.Point(481, 7);
            this.radioButtonElipse.Name = "radioButtonElipse";
            this.radioButtonElipse.Size = new System.Drawing.Size(53, 17);
            this.radioButtonElipse.TabIndex = 8;
            this.radioButtonElipse.Text = "Elipse";
            this.radioButtonElipse.UseVisualStyleBackColor = true;
            // 
            // radioButtonBrush
            // 
            this.radioButtonBrush.AutoSize = true;
            this.radioButtonBrush.Checked = true;
            this.radioButtonBrush.Location = new System.Drawing.Point(343, 7);
            this.radioButtonBrush.Name = "radioButtonBrush";
            this.radioButtonBrush.Size = new System.Drawing.Size(52, 17);
            this.radioButtonBrush.TabIndex = 7;
            this.radioButtonBrush.TabStop = true;
            this.radioButtonBrush.Text = "Brush";
            this.radioButtonBrush.UseVisualStyleBackColor = true;
            // 
            // radioButtonRect
            // 
            this.radioButtonRect.AutoSize = true;
            this.radioButtonRect.Location = new System.Drawing.Point(401, 7);
            this.radioButtonRect.Name = "radioButtonRect";
            this.radioButtonRect.Size = new System.Drawing.Size(74, 17);
            this.radioButtonRect.TabIndex = 6;
            this.radioButtonRect.Text = "Rectangle";
            this.radioButtonRect.UseVisualStyleBackColor = true;
            // 
            // Instruments
            // 
            this.Instruments.BackColor = System.Drawing.Color.Gainsboro;
            this.Instruments.Controls.Add(this.pictureBoxRed);
            this.Instruments.Controls.Add(this.pictureBoxOrange);
            this.Instruments.Controls.Add(this.pictureBoxYellow);
            this.Instruments.Controls.Add(this.pictureBoxGreen);
            this.Instruments.Controls.Add(this.pictureBoxBlue);
            this.Instruments.Controls.Add(this.pictureBoxPurple);
            this.Instruments.Controls.Add(this.pictureBoxBlack);
            this.Instruments.Controls.Add(this.buttonClear);
            this.Instruments.Location = new System.Drawing.Point(0, 0);
            this.Instruments.Name = "Instruments";
            this.Instruments.Size = new System.Drawing.Size(800, 33);
            this.Instruments.TabIndex = 0;
            // 
            // pictureBoxRed
            // 
            this.pictureBoxRed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxRed.BackColor = System.Drawing.Color.Red;
            this.pictureBoxRed.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxRed.Name = "pictureBoxRed";
            this.pictureBoxRed.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxRed.TabIndex = 2;
            this.pictureBoxRed.TabStop = false;
            this.pictureBoxRed.Click += new System.EventHandler(this.pictureBoxRed_Click_1);
            // 
            // pictureBoxOrange
            // 
            this.pictureBoxOrange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxOrange.BackColor = System.Drawing.Color.Orange;
            this.pictureBoxOrange.Location = new System.Drawing.Point(34, 3);
            this.pictureBoxOrange.Name = "pictureBoxOrange";
            this.pictureBoxOrange.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxOrange.TabIndex = 3;
            this.pictureBoxOrange.TabStop = false;
            this.pictureBoxOrange.Click += new System.EventHandler(this.pictureBoxRed_Click_1);
            // 
            // pictureBoxYellow
            // 
            this.pictureBoxYellow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxYellow.BackColor = System.Drawing.Color.Yellow;
            this.pictureBoxYellow.Location = new System.Drawing.Point(65, 3);
            this.pictureBoxYellow.Name = "pictureBoxYellow";
            this.pictureBoxYellow.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxYellow.TabIndex = 3;
            this.pictureBoxYellow.TabStop = false;
            this.pictureBoxYellow.Click += new System.EventHandler(this.pictureBoxRed_Click_1);
            // 
            // pictureBoxGreen
            // 
            this.pictureBoxGreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxGreen.BackColor = System.Drawing.Color.Green;
            this.pictureBoxGreen.Location = new System.Drawing.Point(96, 3);
            this.pictureBoxGreen.Name = "pictureBoxGreen";
            this.pictureBoxGreen.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxGreen.TabIndex = 4;
            this.pictureBoxGreen.TabStop = false;
            this.pictureBoxGreen.Click += new System.EventHandler(this.pictureBoxRed_Click_1);
            // 
            // pictureBoxBlue
            // 
            this.pictureBoxBlue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxBlue.BackColor = System.Drawing.Color.Blue;
            this.pictureBoxBlue.Location = new System.Drawing.Point(127, 3);
            this.pictureBoxBlue.Name = "pictureBoxBlue";
            this.pictureBoxBlue.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxBlue.TabIndex = 3;
            this.pictureBoxBlue.TabStop = false;
            this.pictureBoxBlue.Click += new System.EventHandler(this.pictureBoxRed_Click_1);
            // 
            // pictureBoxPurple
            // 
            this.pictureBoxPurple.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPurple.BackColor = System.Drawing.Color.Purple;
            this.pictureBoxPurple.Location = new System.Drawing.Point(158, 3);
            this.pictureBoxPurple.Name = "pictureBoxPurple";
            this.pictureBoxPurple.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxPurple.TabIndex = 4;
            this.pictureBoxPurple.TabStop = false;
            this.pictureBoxPurple.Click += new System.EventHandler(this.pictureBoxRed_Click_1);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.MistyRose;
            this.buttonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Location = new System.Drawing.Point(220, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(68, 25);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "REFRESH";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // fontSize
            // 
            this.fontSize.Location = new System.Drawing.Point(294, 6);
            this.fontSize.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(43, 20);
            this.fontSize.TabIndex = 9;
            this.fontSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.fontSize.ValueChanged += new System.EventHandler(this.fontSize_ValueChanged);
            // 
            // pictureBoxBlack
            // 
            this.pictureBoxBlack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxBlack.BackColor = System.Drawing.Color.Black;
            this.pictureBoxBlack.Location = new System.Drawing.Point(189, 3);
            this.pictureBoxBlack.Name = "pictureBoxBlack";
            this.pictureBoxBlack.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxBlack.TabIndex = 10;
            this.pictureBoxBlack.TabStop = false;
            this.pictureBoxBlack.Click += new System.EventHandler(this.pictureBoxRed_Click_1);
            // 
            // pictureBoxEraser
            // 
            this.pictureBoxEraser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxEraser.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxEraser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEraser.Image")));
            this.pictureBoxEraser.Location = new System.Drawing.Point(541, 3);
            this.pictureBoxEraser.Name = "pictureBoxEraser";
            this.pictureBoxEraser.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxEraser.TabIndex = 11;
            this.pictureBoxEraser.TabStop = false;
            this.pictureBoxEraser.Click += new System.EventHandler(this.pictureBoxEraser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Canvas);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Paint";
            this.Canvas.ResumeLayout(false);
            this.Canvas.PerformLayout();
            this.Instruments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPurple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEraser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.FlowLayoutPanel Instruments;
        private System.Windows.Forms.PictureBox pictureBoxRed;
        private System.Windows.Forms.PictureBox pictureBoxOrange;
        private System.Windows.Forms.PictureBox pictureBoxYellow;
        private System.Windows.Forms.PictureBox pictureBoxGreen;
        private System.Windows.Forms.PictureBox pictureBoxBlue;
        private System.Windows.Forms.PictureBox pictureBoxPurple;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.RadioButton radioButtonRect;
        private System.Windows.Forms.RadioButton radioButtonBrush;
        private System.Windows.Forms.RadioButton radioButtonElipse;
        private System.Windows.Forms.NumericUpDown fontSize;
        private System.Windows.Forms.PictureBox pictureBoxBlack;
        private System.Windows.Forms.PictureBox pictureBoxEraser;
    }
}

