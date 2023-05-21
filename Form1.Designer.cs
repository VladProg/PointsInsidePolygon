namespace PointsInsidePolygon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label labelPoints2;
            System.Windows.Forms.Label labelPoints;
            System.Windows.Forms.Label labelPolygon2;
            System.Windows.Forms.Label labelPolygon;
            System.Windows.Forms.Button buttonClearPoints;
            System.Windows.Forms.Button buttonGeneratePolygon;
            System.Windows.Forms.Panel panelGeneratePolygon;
            System.Windows.Forms.Label labelGeneratePolygon;
            System.Windows.Forms.Panel panelGeneratePoints;
            System.Windows.Forms.Label labelGeneratePoints;
            System.Windows.Forms.Button buttonGeneratePoints;
            this.numericUpDownGeneratePolygon = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGeneratePoints = new System.Windows.Forms.NumericUpDown();
            this.buttonDrawPoints = new System.Windows.Forms.Button();
            this.buttonDrawPolygon = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.textBoxPoints = new System.Windows.Forms.TextBox();
            this.textBoxPolygon = new System.Windows.Forms.TextBox();
            this.panelDraw = new System.Windows.Forms.Panel();
            labelPoints2 = new System.Windows.Forms.Label();
            labelPoints = new System.Windows.Forms.Label();
            labelPolygon2 = new System.Windows.Forms.Label();
            labelPolygon = new System.Windows.Forms.Label();
            buttonClearPoints = new System.Windows.Forms.Button();
            buttonGeneratePolygon = new System.Windows.Forms.Button();
            panelGeneratePolygon = new System.Windows.Forms.Panel();
            labelGeneratePolygon = new System.Windows.Forms.Label();
            panelGeneratePoints = new System.Windows.Forms.Panel();
            labelGeneratePoints = new System.Windows.Forms.Label();
            buttonGeneratePoints = new System.Windows.Forms.Button();
            panelGeneratePolygon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGeneratePolygon)).BeginInit();
            panelGeneratePoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGeneratePoints)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPoints2
            // 
            labelPoints2.AutoSize = true;
            labelPoints2.Dock = System.Windows.Forms.DockStyle.Top;
            labelPoints2.Location = new System.Drawing.Point(0, 320);
            labelPoints2.Name = "labelPoints2";
            labelPoints2.Size = new System.Drawing.Size(156, 20);
            labelPoints2.TabIndex = 9;
            labelPoints2.Text = "або введіть їх у поле:";
            // 
            // labelPoints
            // 
            labelPoints.AutoSize = true;
            labelPoints.Dock = System.Windows.Forms.DockStyle.Top;
            labelPoints.Location = new System.Drawing.Point(0, 192);
            labelPoints.Name = "labelPoints";
            labelPoints.Size = new System.Drawing.Size(108, 40);
            labelPoints.TabIndex = 2;
            labelPoints.Text = "\nТочки запитів:";
            // 
            // labelPolygon2
            // 
            labelPolygon2.AutoSize = true;
            labelPolygon2.Dock = System.Windows.Forms.DockStyle.Top;
            labelPolygon2.Location = new System.Drawing.Point(0, 79);
            labelPolygon2.Name = "labelPolygon2";
            labelPolygon2.Size = new System.Drawing.Size(156, 20);
            labelPolygon2.TabIndex = 6;
            labelPolygon2.Text = "або введіть їх у поле:";
            // 
            // labelPolygon
            // 
            labelPolygon.AutoSize = true;
            labelPolygon.Dock = System.Windows.Forms.DockStyle.Top;
            labelPolygon.Location = new System.Drawing.Point(0, 0);
            labelPolygon.Name = "labelPolygon";
            labelPolygon.Size = new System.Drawing.Size(154, 20);
            labelPolygon.TabIndex = 0;
            labelPolygon.Text = "Точки многокутника:";
            // 
            // buttonClearPoints
            // 
            buttonClearPoints.Dock = System.Windows.Forms.DockStyle.Top;
            buttonClearPoints.Location = new System.Drawing.Point(0, 291);
            buttonClearPoints.Name = "buttonClearPoints";
            buttonClearPoints.Size = new System.Drawing.Size(250, 29);
            buttonClearPoints.TabIndex = 10;
            buttonClearPoints.Text = "очистити";
            buttonClearPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonClearPoints.UseVisualStyleBackColor = true;
            buttonClearPoints.Click += new System.EventHandler(this.buttonClearPoints_Click);
            // 
            // buttonGeneratePolygon
            // 
            buttonGeneratePolygon.AutoSize = true;
            buttonGeneratePolygon.Dock = System.Windows.Forms.DockStyle.Left;
            buttonGeneratePolygon.Location = new System.Drawing.Point(0, 0);
            buttonGeneratePolygon.Name = "buttonGeneratePolygon";
            buttonGeneratePolygon.Size = new System.Drawing.Size(104, 30);
            buttonGeneratePolygon.TabIndex = 3;
            buttonGeneratePolygon.Text = "згенерувати";
            buttonGeneratePolygon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonGeneratePolygon.UseVisualStyleBackColor = true;
            buttonGeneratePolygon.Click += new System.EventHandler(this.buttonGeneratePolygon_Click);
            // 
            // panelGeneratePolygon
            // 
            panelGeneratePolygon.Controls.Add(labelGeneratePolygon);
            panelGeneratePolygon.Controls.Add(this.numericUpDownGeneratePolygon);
            panelGeneratePolygon.Controls.Add(buttonGeneratePolygon);
            panelGeneratePolygon.Dock = System.Windows.Forms.DockStyle.Top;
            panelGeneratePolygon.Location = new System.Drawing.Point(0, 49);
            panelGeneratePolygon.Name = "panelGeneratePolygon";
            panelGeneratePolygon.Size = new System.Drawing.Size(250, 30);
            panelGeneratePolygon.TabIndex = 2;
            // 
            // labelGeneratePolygon
            // 
            labelGeneratePolygon.AutoSize = true;
            labelGeneratePolygon.Dock = System.Windows.Forms.DockStyle.Left;
            labelGeneratePolygon.Location = new System.Drawing.Point(184, 0);
            labelGeneratePolygon.Name = "labelGeneratePolygon";
            labelGeneratePolygon.Size = new System.Drawing.Size(48, 20);
            labelGeneratePolygon.TabIndex = 7;
            labelGeneratePolygon.Text = "точок";
            // 
            // numericUpDownGeneratePolygon
            // 
            this.numericUpDownGeneratePolygon.Dock = System.Windows.Forms.DockStyle.Left;
            this.numericUpDownGeneratePolygon.Location = new System.Drawing.Point(104, 0);
            this.numericUpDownGeneratePolygon.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownGeneratePolygon.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownGeneratePolygon.Name = "numericUpDownGeneratePolygon";
            this.numericUpDownGeneratePolygon.Size = new System.Drawing.Size(80, 27);
            this.numericUpDownGeneratePolygon.TabIndex = 4;
            this.numericUpDownGeneratePolygon.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // panelGeneratePoints
            // 
            panelGeneratePoints.Controls.Add(labelGeneratePoints);
            panelGeneratePoints.Controls.Add(this.numericUpDownGeneratePoints);
            panelGeneratePoints.Controls.Add(buttonGeneratePoints);
            panelGeneratePoints.Dock = System.Windows.Forms.DockStyle.Top;
            panelGeneratePoints.Location = new System.Drawing.Point(0, 261);
            panelGeneratePoints.Name = "panelGeneratePoints";
            panelGeneratePoints.Size = new System.Drawing.Size(250, 30);
            panelGeneratePoints.TabIndex = 7;
            // 
            // labelGeneratePoints
            // 
            labelGeneratePoints.AutoSize = true;
            labelGeneratePoints.Dock = System.Windows.Forms.DockStyle.Left;
            labelGeneratePoints.Location = new System.Drawing.Point(184, 0);
            labelGeneratePoints.Name = "labelGeneratePoints";
            labelGeneratePoints.Size = new System.Drawing.Size(48, 20);
            labelGeneratePoints.TabIndex = 7;
            labelGeneratePoints.Text = "точок";
            // 
            // numericUpDownGeneratePoints
            // 
            this.numericUpDownGeneratePoints.Dock = System.Windows.Forms.DockStyle.Left;
            this.numericUpDownGeneratePoints.Location = new System.Drawing.Point(104, 0);
            this.numericUpDownGeneratePoints.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownGeneratePoints.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGeneratePoints.Name = "numericUpDownGeneratePoints";
            this.numericUpDownGeneratePoints.Size = new System.Drawing.Size(80, 27);
            this.numericUpDownGeneratePoints.TabIndex = 9;
            this.numericUpDownGeneratePoints.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // buttonGeneratePoints
            // 
            buttonGeneratePoints.AutoSize = true;
            buttonGeneratePoints.Dock = System.Windows.Forms.DockStyle.Left;
            buttonGeneratePoints.Location = new System.Drawing.Point(0, 0);
            buttonGeneratePoints.Name = "buttonGeneratePoints";
            buttonGeneratePoints.Size = new System.Drawing.Size(104, 30);
            buttonGeneratePoints.TabIndex = 8;
            buttonGeneratePoints.Text = "згенерувати";
            buttonGeneratePoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonGeneratePoints.UseVisualStyleBackColor = true;
            buttonGeneratePoints.Click += new System.EventHandler(this.buttonGeneratePoints_Click);
            // 
            // buttonDrawPoints
            // 
            this.buttonDrawPoints.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDrawPoints.Location = new System.Drawing.Point(0, 232);
            this.buttonDrawPoints.Name = "buttonDrawPoints";
            this.buttonDrawPoints.Size = new System.Drawing.Size(250, 29);
            this.buttonDrawPoints.TabIndex = 6;
            this.buttonDrawPoints.Text = "намалювати";
            this.buttonDrawPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDrawPoints.UseVisualStyleBackColor = true;
            this.buttonDrawPoints.Click += new System.EventHandler(this.buttonDrawPoints_Click);
            // 
            // buttonDrawPolygon
            // 
            this.buttonDrawPolygon.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDrawPolygon.Location = new System.Drawing.Point(0, 20);
            this.buttonDrawPolygon.Name = "buttonDrawPolygon";
            this.buttonDrawPolygon.Size = new System.Drawing.Size(250, 29);
            this.buttonDrawPolygon.TabIndex = 1;
            this.buttonDrawPolygon.Text = "намалювати";
            this.buttonDrawPolygon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDrawPolygon.UseVisualStyleBackColor = true;
            this.buttonDrawPolygon.Click += new System.EventHandler(this.buttonDrawPolygon_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.textBoxPoints);
            this.panelLeft.Controls.Add(labelPoints2);
            this.panelLeft.Controls.Add(buttonClearPoints);
            this.panelLeft.Controls.Add(panelGeneratePoints);
            this.panelLeft.Controls.Add(this.buttonDrawPoints);
            this.panelLeft.Controls.Add(labelPoints);
            this.panelLeft.Controls.Add(this.textBoxPolygon);
            this.panelLeft.Controls.Add(labelPolygon2);
            this.panelLeft.Controls.Add(panelGeneratePolygon);
            this.panelLeft.Controls.Add(this.buttonDrawPolygon);
            this.panelLeft.Controls.Add(labelPolygon);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(250, 703);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.SizeChanged += new System.EventHandler(this.panelLeft_SizeChanged);
            // 
            // textBoxPoints
            // 
            this.textBoxPoints.AcceptsReturn = true;
            this.textBoxPoints.AllowDrop = true;
            this.textBoxPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPoints.Location = new System.Drawing.Point(0, 340);
            this.textBoxPoints.MaxLength = 0;
            this.textBoxPoints.Multiline = true;
            this.textBoxPoints.Name = "textBoxPoints";
            this.textBoxPoints.PlaceholderText = "x1 y1\nx2 y2\n...";
            this.textBoxPoints.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPoints.Size = new System.Drawing.Size(250, 363);
            this.textBoxPoints.TabIndex = 11;
            this.textBoxPoints.TextChanged += new System.EventHandler(this.textBoxPoints_TextChanged);
            // 
            // textBoxPolygon
            // 
            this.textBoxPolygon.AcceptsReturn = true;
            this.textBoxPolygon.AllowDrop = true;
            this.textBoxPolygon.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxPolygon.Location = new System.Drawing.Point(0, 99);
            this.textBoxPolygon.MaxLength = 0;
            this.textBoxPolygon.Multiline = true;
            this.textBoxPolygon.Name = "textBoxPolygon";
            this.textBoxPolygon.PlaceholderText = "x1 y1\nx2 y2\n...";
            this.textBoxPolygon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPolygon.Size = new System.Drawing.Size(250, 93);
            this.textBoxPolygon.TabIndex = 5;
            this.textBoxPolygon.TextChanged += new System.EventHandler(this.textBoxPolygon_TextChanged);
            // 
            // panelDraw
            // 
            this.panelDraw.BackColor = System.Drawing.Color.White;
            this.panelDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDraw.Location = new System.Drawing.Point(250, 0);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(1232, 703);
            this.panelDraw.TabIndex = 1;
            this.panelDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 703);
            this.Controls.Add(this.panelDraw);
            this.Controls.Add(this.panelLeft);
            this.Name = "Form1";
            this.Text = "Точки всередині многокутника";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            panelGeneratePolygon.ResumeLayout(false);
            panelGeneratePolygon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGeneratePolygon)).EndInit();
            panelGeneratePoints.ResumeLayout(false);
            panelGeneratePoints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGeneratePoints)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textBoxPoints;
        private Button buttonDrawPoints;
        private TextBox textBoxPolygon;
        private Button buttonGeneratePolygon;
        private Button buttonDrawPolygon;
        private Panel panelLeft;
        private System.Windows.Forms.Panel panelDraw;
        private Button buttonClearPoints;
        private Panel panelGeneratePolygon;
        private NumericUpDown numericUpDownGeneratePolygon;
        private NumericUpDown numericUpDownGeneratePoints;
    }
}