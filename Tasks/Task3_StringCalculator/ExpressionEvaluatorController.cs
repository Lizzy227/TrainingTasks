using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task3_ExpressionEvaluator;
using System.Text.RegularExpressions;

namespace Task3_StringCalculator
{
    public class ExpressionEvaluatorController
    {
        private readonly ExpressionEvaluatorModel model;
        private readonly ExpressionEvaluatorMain view;

        public ExpressionEvaluatorController(ExpressionEvaluatorMain view, ExpressionEvaluatorModel  model)
        {
            this.view = view;
            this.model = model;
            this.view.UserInputReceived += ProcessUserInput;
        }

        private void ProcessUserInput(object sender, string expression)
        {

            try
            {
                string expressionCondensed = Regex.Replace(expression, @"\s+", "");
                
                bool hasValidOperators = CheckValidOperators(expressionCondensed);

                if(!hasValidOperators)
                {
                    ShowErrorMessage("Please enter a valid expression with operators such as (/, *, +, -) and/or parenthesis such as ( or ).");
                }

                if (hasValidOperators )
                {
                    model.Expression = expressionCondensed; 
                    float evaluationResult = model.EvaluateExpression(expressionCondensed);
                    view.UpdateTotalLabel(evaluationResult);
                }
                
            }
            catch (Exception ex)
            {                
                ShowErrorMessage("An error occurred: " + ex.Message);
            }
        }

        private bool CheckValidOperators(string expression)
        {
            return expression.Contains("+") || expression.Contains("-") || expression.Contains("*") || expression.Contains("/") || expression.Contains("(") || expression.Contains(")");
        }

        private void ShowErrorMessage(string message)
        {            
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
}
