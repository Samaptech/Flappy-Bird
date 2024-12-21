namespace Flappy_Bird
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
            this.pipeUp = new System.Windows.Forms.PictureBox();
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.gameStatus = new System.Windows.Forms.Label();
            this.restartLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // pipeUp
            // 
            this.pipeUp.Image = global::Flappy_Bird.Properties.Resources.pipedown;
            this.pipeUp.Location = new System.Drawing.Point(473, 1);
            this.pipeUp.Name = "pipeUp";
            this.pipeUp.Size = new System.Drawing.Size(100, 194);
            this.pipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeUp.TabIndex = 1;
            this.pipeUp.TabStop = false;
            // 
            // pipeDown
            // 
            this.pipeDown.Image = global::Flappy_Bird.Properties.Resources.pipe;
            this.pipeDown.Location = new System.Drawing.Point(644, 414);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(100, 271);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 1;
            this.pipeDown.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = global::Flappy_Bird.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(89, 315);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(58, 58);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 1;
            this.bird.TabStop = false;
            this.bird.Click += new System.EventHandler(this.bird_Click);
            // 
            // ground
            // 
            this.ground.Image = global::Flappy_Bird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-5, 611);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(749, 74);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(0, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 56);
            this.scoreLabel.TabIndex = 2;
            // 
            // gameStatus
            // 
            this.gameStatus.AutoSize = true;
            this.gameStatus.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStatus.Location = new System.Drawing.Point(316, 274);
            this.gameStatus.Name = "gameStatus";
            this.gameStatus.Size = new System.Drawing.Size(0, 43);
            this.gameStatus.TabIndex = 3;
            this.gameStatus.Click += new System.EventHandler(this.restartLabel_Click);
            // 
            // restartLabel
            // 
            this.restartLabel.AutoSize = true;
            this.restartLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartLabel.Location = new System.Drawing.Point(303, 435);
            this.restartLabel.Name = "restartLabel";
            this.restartLabel.Size = new System.Drawing.Size(0, 56);
            this.restartLabel.TabIndex = 4;
            this.restartLabel.Click += new System.EventHandler(this.restartLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(740, 684);
            this.Controls.Add(this.restartLabel);
            this.Controls.Add(this.gameStatus);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.pipeDown);
            this.Controls.Add(this.pipeUp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeUp;
        private System.Windows.Forms.PictureBox pipeDown;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label gameStatus;
        private System.Windows.Forms.Label restartLabel;
    }
}

