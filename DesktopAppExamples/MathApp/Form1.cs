using System.Windows.Forms;

namespace MathApp
{
    public partial class Form1 : Form
    {
        
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Sub

        }



        private void SumButton_Click(object sender, EventArgs e)
        {
            // Clear previous content from the panel (if any)
            panel2.Controls.Clear();
            int correctAnswers = 0; // Counter for correct answers

            for (int i = 0; i < 10; i++)
            {
                int num1 = random.Next(1, 100);
                int num2 = random.Next(1, 100);
                int correctAnswer = num1 + num2;

                Label questionLabel = new Label();
                Label questionLabel2 = new Label();
                TextBox answerTextBox = new TextBox();
                Label answerLabel = new Label(); // New label for answer feedback

                // Set question text and position controls
                questionLabel.Text = $"Question {i + 1}: {num1} + ";
                questionLabel2.Text = $"{num2}";

                // Place questionLabel2 next to questionLabel with a small gap
                questionLabel.Location = new Point(20, 20 + (i * 30));
                questionLabel2.Location = new Point(questionLabel.Right + 5, questionLabel.Top);
                answerTextBox.Location = new Point(questionLabel2.Right + 40, questionLabel.Top);
                answerLabel.Location = new Point(answerTextBox.Right + 20, questionLabel.Top);

                // Add controls to the panel
                panel2.Controls.Add(questionLabel);
                panel2.Controls.Add(questionLabel2);
                panel2.Controls.Add(answerTextBox);
                panel2.Controls.Add(answerLabel);

                // Event handler for answer check on TextChanged (user types)
                answerTextBox.TextChanged += (senderTextBox, eTextBox) =>
                {
                    string userAnswer = answerTextBox.Text.Trim();
                    if (int.TryParse(userAnswer, out int parsedAnswer) && parsedAnswer == correctAnswer)
                    {
                        answerLabel.Text = "Correct!";
                        correctAnswers++;
                    }
                    else
                    {
                        answerLabel.Text = "Incorrect. Try again.";
                    }
                };
            }

            // Label for overall result
            Label resultLabel = new Label();
            resultLabel.Location = new Point(20, 20 + (10 * 30)); // Below the last question

            // Check if all answers are correct
            if (correctAnswers == 10)
            {
                resultLabel.Text = "Congratulations! You answered all questions correctly.";
            }
            else
            {
                resultLabel.Text = $"You answered {correctAnswers} out of 10 questions correctly.";
            }

            panel2.Controls.Add(resultLabel);

            // Make the panel visible
            panel2.Visible = true;
        }

        private void MultButton_Click(object sender, EventArgs e)
        {

        }

        private void DivideButton_Click(object sender, EventArgs e)
        {

        }

        private void Quiz_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
