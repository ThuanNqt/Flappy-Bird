namespace Flappy_Bird
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
            this.components = new System.ComponentModel.Container();
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.weather = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weather)).BeginInit();
            this.SuspendLayout();
            // 
            // pipeDown
            // 
            this.pipeDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pipeDown.Image = global::Flappy_Bird.Properties.Resources.pipe23___pipe;
            this.pipeDown.Location = new System.Drawing.Point(574, 2);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(82, 87);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 0;
            this.pipeDown.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = global::Flappy_Bird.Properties.Resources.Flappy_Bird_PNG_Transparent_Image;
            this.bird.Location = new System.Drawing.Point(209, 118);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(75, 65);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pipeTop.Image = global::Flappy_Bird.Properties.Resources.pipe2___pipe;
            this.pipeTop.Location = new System.Drawing.Point(399, 244);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(82, 185);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 0;
            this.pipeTop.TabStop = false;
            // 
            // ground
            // 
            this.ground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ground.Image = global::Flappy_Bird.Properties.Resources._47_474860_ground_flappy_bird_ground_scratch_clipart;
            this.ground.Location = new System.Drawing.Point(-10, 341);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(815, 117);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblScore
            // 
            this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(12, 374);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(123, 40);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score: 0";
            // 
            // weather
            // 
            this.weather.Image = global::Flappy_Bird.Properties.Resources.Untitled;
            this.weather.Location = new System.Drawing.Point(2, 2);
            this.weather.Name = "weather";
            this.weather.Size = new System.Drawing.Size(100, 70);
            this.weather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weather.TabIndex = 3;
            this.weather.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.weather);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.pipeDown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pipeDown;
        private PictureBox bird;
        private PictureBox pipeTop;
        private PictureBox ground;
        private System.Windows.Forms.Timer timer1;
        private Label lblScore;
        private PictureBox weather;
    }
}