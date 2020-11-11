namespace _8hét
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.Car = new System.Windows.Forms.Button();
            this.Ball = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Present = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Location = new System.Drawing.Point(-1, 306);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(801, 100);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // Car
            // 
            this.Car.Location = new System.Drawing.Point(12, 12);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(78, 76);
            this.Car.TabIndex = 1;
            this.Car.Text = "CAR";
            this.Car.UseVisualStyleBackColor = true;
            this.Car.Click += new System.EventHandler(this.Car_Click);
            // 
            // Ball
            // 
            this.Ball.Location = new System.Drawing.Point(96, 12);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(78, 76);
            this.Ball.TabIndex = 1;
            this.Ball.Text = "BALL";
            this.Ball.UseVisualStyleBackColor = true;
            this.Ball.Click += new System.EventHandler(this.Ball_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coming Next: ";
            // 
            // Present
            // 
            this.Present.Location = new System.Drawing.Point(180, 12);
            this.Present.Name = "Present";
            this.Present.Size = new System.Drawing.Size(78, 76);
            this.Present.TabIndex = 1;
            this.Present.Text = "BALL";
            this.Present.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(96, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Present);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button Car;
        private System.Windows.Forms.Button Ball;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Present;
        private System.Windows.Forms.Button button1;
    }
}

