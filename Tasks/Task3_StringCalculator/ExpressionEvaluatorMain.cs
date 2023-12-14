namespace Task3_ExpressionEvaluator
{
    public partial class ExpressionEvaluatorMain : Form
    {
        public event EventHandler<string> UserInputReceived;
        public ExpressionEvaluatorMain()
        {
            InitializeComponent();
        }

        private void EvaluateButton_Click(object sender, EventArgs e)
        {
            // Get the expression from the TextBox
            string expression = expressionTextbox.Text;

            if (UserInputReceived != null)
            {
                UserInputReceived.Invoke(this, expression);

            }
        }

        public void UpdateEvaluationBoolLabel(bool result)
        {
            if (result)
            {
                EvaluationBoolLabel.Text = "Result: True";
                EvaluationBoolLabel.ForeColor = Color.Green;
            }
            else
            {
                EvaluationBoolLabel.Text = "Result: False";
                EvaluationBoolLabel.ForeColor = Color.Red;
            }
        }
    }
}