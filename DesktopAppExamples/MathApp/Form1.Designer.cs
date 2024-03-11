namespace MathApp
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
            panel1 = new Panel();
            DivideButton = new Button();
            MultButton = new Button();
            SubButton = new Button();
            SumButton = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(DivideButton);
            panel1.Controls.Add(MultButton);
            panel1.Controls.Add(SubButton);
            panel1.Controls.Add(SumButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 450);
            panel1.TabIndex = 0;
            // 
            // DivideButton
            // 
            DivideButton.Location = new Point(35, 209);
            DivideButton.Name = "DivideButton";
            DivideButton.Size = new Size(93, 31);
            DivideButton.TabIndex = 3;
            DivideButton.Text = "Divide";
            DivideButton.UseVisualStyleBackColor = true;
            DivideButton.Click += DivideButton_Click;
            // 
            // MultButton
            // 
            MultButton.Location = new Point(35, 148);
            MultButton.Name = "MultButton";
            MultButton.Size = new Size(93, 31);
            MultButton.TabIndex = 2;
            MultButton.Text = "Multi";
            MultButton.UseVisualStyleBackColor = true;
            MultButton.Click += MultButton_Click;
            // 
            // SubButton
            // 
            SubButton.Location = new Point(35, 89);
            SubButton.Name = "SubButton";
            SubButton.Size = new Size(93, 31);
            SubButton.TabIndex = 1;
            SubButton.Text = "Sub";
            SubButton.UseVisualStyleBackColor = true;
            SubButton.Click += button2_Click;
            // 
            // SumButton
            // 
            SumButton.Location = new Point(35, 31);
            SumButton.Name = "SumButton";
            SumButton.Size = new Size(93, 31);
            SumButton.TabIndex = 0;
            SumButton.Text = "Sum";
            SumButton.UseVisualStyleBackColor = true;
            SumButton.Click += SumButton_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(192, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(588, 402);
            panel2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button DivideButton;
        private Button MultButton;
        private Button SubButton;
        private Button SumButton;
        private Panel panel2;
    }
}
