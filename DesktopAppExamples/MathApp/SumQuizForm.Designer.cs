namespace MathApp
{
    partial class SumQuizForm
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
            Num1 = new TextBox();
            Num2 = new TextBox();
            label1 = new Label();
            Correct = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Num1
            // 
            Num1.Location = new Point(91, 100);
            Num1.Name = "Num1";
            Num1.Size = new Size(151, 23);
            Num1.TabIndex = 0;
            // 
            // Num2
            // 
            Num2.Location = new Point(315, 100);
            Num2.Name = "Num2";
            Num2.Size = new Size(151, 23);
            Num2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 103);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 2;
            label1.Text = "+";
            // 
            // Correct
            // 
            Correct.AutoSize = true;
            Correct.Location = new Point(269, 198);
            Correct.Name = "Correct";
            Correct.Size = new Size(0, 15);
            Correct.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(521, 103);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // SumQuizForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Correct);
            Controls.Add(label1);
            Controls.Add(Num2);
            Controls.Add(Num1);
            Name = "SumQuizForm";
            Text = "SumQuizForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Num1;
        private TextBox Num2;
        private Label label1;
        private Label Correct;
        private Button button1;
    }
}