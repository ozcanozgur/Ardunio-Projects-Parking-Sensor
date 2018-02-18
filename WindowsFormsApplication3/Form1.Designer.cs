namespace WindowsFormsApplication3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDis = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackBar = new CircularProgressBar.CircularProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.Transparent;
            this.buttonConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConnect.BackgroundImage")));
            this.buttonConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonConnect.FlatAppearance.BorderSize = 0;
            this.buttonConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Location = new System.Drawing.Point(37, 41);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(40, 42);
            this.buttonConnect.TabIndex = 7;
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDis
            // 
            this.buttonDis.BackColor = System.Drawing.Color.Transparent;
            this.buttonDis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDis.BackgroundImage")));
            this.buttonDis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDis.FlatAppearance.BorderSize = 0;
            this.buttonDis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonDis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonDis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDis.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonDis.Location = new System.Drawing.Point(119, 41);
            this.buttonDis.Name = "buttonDis";
            this.buttonDis.Size = new System.Drawing.Size(41, 42);
            this.buttonDis.TabIndex = 8;
            this.buttonDis.UseVisualStyleBackColor = false;
            this.buttonDis.Click += new System.EventHandler(this.buttonDis_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(489, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 68);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(810, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 313);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(141, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // BackBar
            // 
            this.BackBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.BackBar.AnimationSpeed = 500;
            this.BackBar.BackColor = System.Drawing.Color.Transparent;
            this.BackBar.Font = new System.Drawing.Font("Mistral", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BackBar.ForeColor = System.Drawing.Color.LimeGreen;
            this.BackBar.InnerColor = System.Drawing.Color.Transparent;
            this.BackBar.InnerMargin = 0;
            this.BackBar.InnerWidth = 0;
            this.BackBar.Location = new System.Drawing.Point(707, 12);
            this.BackBar.MarqueeAnimationSpeed = 2000;
            this.BackBar.Maximum = 360;
            this.BackBar.Name = "BackBar";
            this.BackBar.OuterColor = System.Drawing.Color.Transparent;
            this.BackBar.OuterMargin = 0;
            this.BackBar.OuterWidth = 0;
            this.BackBar.ProgressColor = System.Drawing.Color.LimeGreen;
            this.BackBar.ProgressWidth = 20;
            this.BackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BackBar.RightToLeftLayout = true;
            this.BackBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.BackBar.Size = new System.Drawing.Size(369, 243);
            this.BackBar.StartAngle = 180;
            this.BackBar.SubscriptColor = System.Drawing.Color.GreenYellow;
            this.BackBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.BackBar.SubscriptText = "";
            this.BackBar.SuperscriptColor = System.Drawing.Color.Fuchsia;
            this.BackBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.BackBar.SuperscriptText = "";
            this.BackBar.TabIndex = 0;
            this.BackBar.Text = "00";
            this.BackBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.BackBar.Value = 180;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1088, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonDis);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BackBar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDis;
        private System.Windows.Forms.Button button2;
       
        private System.Windows.Forms.PictureBox pictureBox2;
        
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CircularProgressBar.CircularProgressBar BackBar;
    }
}

