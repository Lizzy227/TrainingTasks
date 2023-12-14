using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task3_ExpressionEvaluator;

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

            // Subscribe to the UserInputReceived event
            this.view.UserInputReceived += ProcessUserInput;
        }

        private void ProcessUserInput(object sender, string expression)
        {

            try
            {
                bool hasValidDelimiter = CheckValidDelimiter(expression);

                if (hasValidDelimiter)
                {
                    model.Expression = expression; // 'expression' contains the input from the view
                    bool evaluationResult = model.EvaluateExpression();
                    view.UpdateEvaluationBoolLabel(evaluationResult);
                }
                else
                {
                    // Display a message to the user indicating the need for a valid expression
                    ShowErrorMessage("Please enter a valid expression with a delimiter (=, <, >, ==, <=, >=)");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during processing
                ShowErrorMessage("An error occurred: " + ex.Message);
            }
        }

        private bool CheckValidDelimiter(string expression)
        {
            // Check the expression for a valid delimiter in the controller
            // Return true if a valid delimiter is found, else return false
            return expression.Contains("=") || expression.Contains("<") || expression.Contains(">") || expression.Contains("<=") || expression.Contains(">=") || expression.Contains("==");
        }

        private void ShowErrorMessage(string message)
        {
            // Display an error message using MessageBox
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
}
