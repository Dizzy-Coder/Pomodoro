namespace Pomodoro
{
    partial class Form2
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
            clock = new Label();
            sessionLabel = new Label();
            SuspendLayout();
            // 
            // clock
            // 
            clock.AutoSize = true;
            clock.Font = new Font("Lucida Console", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clock.Location = new Point(27, 38);
            clock.Name = "clock";
            clock.Size = new Size(0, 32);
            clock.TabIndex = 0;
            // 
            // sessionLabel
            // 
            sessionLabel.AutoSize = true;
            sessionLabel.Font = new Font("Lucida Sans Typewriter", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sessionLabel.Location = new Point(28, 4);
            sessionLabel.Name = "sessionLabel";
            sessionLabel.Size = new Size(142, 23);
            sessionLabel.TabIndex = 1;
            sessionLabel.Text = "Session - 1";
            sessionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(204, 73);
            Controls.Add(sessionLabel);
            Controls.Add(clock);
            ForeColor = SystemColors.Window;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "Form2";
            Text = "Pomodoro";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Timer;
        private Label clock;
        private Label sessionLabel;
    }
}