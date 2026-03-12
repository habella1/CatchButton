namespace CatchButton
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
            ButtonRun = new Button();
            SuspendLayout();
            // 
            // ButtonRun
            // 
            ButtonRun.BackColor = SystemColors.Info;
            ButtonRun.Font = new Font("휴먼편지체", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ButtonRun.Location = new Point(225, 136);
            ButtonRun.Name = "ButtonRun";
            ButtonRun.Size = new Size(336, 147);
            ButtonRun.TabIndex = 0;
            ButtonRun.Text = "나를 잡아봐";
            ButtonRun.UseVisualStyleBackColor = false;
            ButtonRun.Click += button1_Click;
            ButtonRun.MouseEnter += button1_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonRun);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonRun;
    }
}
