using System.Linq.Expressions;

namespace Task3_ExpressionEvaluator
{
    public partial class EvaluatorForm : Form
    {
        private UserExpression userExpression;
        public event EventHandler<string> UserInputReceived;
        public EvaluatorForm()
        {
            InitializeComponent();
            userExpression = new UserExpression(this);
            lblResult.Visible = false;
        }

        private void btEvaluate_Click(object sender, EventArgs e)
        {
            string expression = txbExpression.Text;
            if (UserInputReceived != null)
            {
                UserInputReceived.Invoke(this, expression);

            }

        }

        public void UpdatelblResult(double result)
        {
            lblResult.Visible = true;
            lblResult.Text = result.ToString();           
        }

        private void txbExpression_KeyPress(object sender, KeyPressEventArgs e)
        {
            HashSet<char> validCharacters = new HashSet<char> { ' ','(', ')', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '+', '-', '*', '/', '.' };

            if (!validCharacters.Contains(e.KeyChar))
            {                
                e.Handled = true;
            }
        }
    }
}