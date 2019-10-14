namespace PingPongGame
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
            this.PlayGround = new System.Windows.Forms.Panel();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Racket1 = new System.Windows.Forms.PictureBox();
            this.Racket2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Player1Label = new System.Windows.Forms.Label();
            this.Player2label = new System.Windows.Forms.Label();
            this.Player2Scored = new System.Windows.Forms.Label();
            this.Player1Scored = new System.Windows.Forms.Label();
            this.PlayGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket2)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayGround
            // 
            this.PlayGround.Controls.Add(this.Player1Scored);
            this.PlayGround.Controls.Add(this.Player2Scored);
            this.PlayGround.Controls.Add(this.Player2label);
            this.PlayGround.Controls.Add(this.Player1Label);
            this.PlayGround.Controls.Add(this.Ball);
            this.PlayGround.Controls.Add(this.Racket1);
            this.PlayGround.Controls.Add(this.Racket2);
            this.PlayGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayGround.Font = new System.Drawing.Font("Mistral", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayGround.Location = new System.Drawing.Point(0, 0);
            this.PlayGround.Name = "PlayGround";
            this.PlayGround.Size = new System.Drawing.Size(800, 552);
            this.PlayGround.TabIndex = 0;
            // 
            // Ball
            // 
            this.Ball.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ball.BackgroundImage")));
            this.Ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Ball.ErrorImage = null;
            this.Ball.Image = ((System.Drawing.Image)(resources.GetObject("Ball.Image")));
            this.Ball.Location = new System.Drawing.Point(382, 281);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(25, 25);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            // 
            // Racket1
            // 
            this.Racket1.BackColor = System.Drawing.Color.DimGray;
            this.Racket1.Location = new System.Drawing.Point(287, 12);
            this.Racket1.Name = "Racket1";
            this.Racket1.Size = new System.Drawing.Size(300, 20);
            this.Racket1.TabIndex = 1;
            this.Racket1.TabStop = false;
            // 
            // Racket2
            // 
            this.Racket2.BackColor = System.Drawing.Color.DimGray;
            this.Racket2.Location = new System.Drawing.Point(287, 530);
            this.Racket2.Name = "Racket2";
            this.Racket2.Size = new System.Drawing.Size(300, 20);
            this.Racket2.TabIndex = 0;
            this.Racket2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Player1Label
            // 
            this.Player1Label.AutoSize = true;
            this.Player1Label.Font = new System.Drawing.Font("VNI-Ariston", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Label.Location = new System.Drawing.Point(13, 18);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(113, 37);
            this.Player1Label.TabIndex = 3;
            this.Player1Label.Text = "Scored: ";
            // 
            // Player2label
            // 
            this.Player2label.AutoSize = true;
            this.Player2label.Font = new System.Drawing.Font("VNI-Ariston", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2label.Location = new System.Drawing.Point(12, 506);
            this.Player2label.Name = "Player2label";
            this.Player2label.Size = new System.Drawing.Size(113, 37);
            this.Player2label.TabIndex = 4;
            this.Player2label.Text = "Scored: ";
            // 
            // Player2Scored
            // 
            this.Player2Scored.AutoSize = true;
            this.Player2Scored.Font = new System.Drawing.Font("VNI-Ariston", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Scored.Location = new System.Drawing.Point(131, 506);
            this.Player2Scored.Name = "Player2Scored";
            this.Player2Scored.Size = new System.Drawing.Size(32, 37);
            this.Player2Scored.TabIndex = 5;
            this.Player2Scored.Text = "0";
            // 
            // Player1Scored
            // 
            this.Player1Scored.AutoSize = true;
            this.Player1Scored.Font = new System.Drawing.Font("VNI-Ariston", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Scored.Location = new System.Drawing.Point(132, 18);
            this.Player1Scored.Name = "Player1Scored";
            this.Player1Scored.Size = new System.Drawing.Size(32, 37);
            this.Player1Scored.TabIndex = 6;
            this.Player1Scored.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.PlayGround);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.PlayGround.ResumeLayout(false);
            this.PlayGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PlayGround;
        private System.Windows.Forms.PictureBox Racket1;
        private System.Windows.Forms.PictureBox Racket2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Label Player1Label;
        private System.Windows.Forms.Label Player2label;
        private System.Windows.Forms.Label Player1Scored;
        private System.Windows.Forms.Label Player2Scored;
    }
}

