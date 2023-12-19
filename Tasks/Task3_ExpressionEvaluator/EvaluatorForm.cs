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
        }

        private void btEvaluate_Click(object sender, EventArgs e)
        {
            string expression = txbExpression.Text;
            if (UserInputReceived != null)
            {
                UserInputReceived.Invoke(this, expression);

            }

        }

        public void UpdatelblResult(bool validexpression)
        {
            if (!validexpression)
            {
                lblResult.Text = "Expression not valid";
            }
            else
            {
                lblResult.Text = "Expression is valid";
            }
        }
    }
}
