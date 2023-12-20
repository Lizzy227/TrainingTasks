using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3_ExpressionEvaluator
{
    internal class UserExpression
    {
        public ExpressionCalculator expressionCalculator = new ExpressionCalculator();
        private readonly EvaluatorForm winForm;
        public string Expression {  get; private set; }

        public UserExpression(EvaluatorForm Form)
        {
            this.winForm = Form;
            this.winForm.UserInputReceived += ProcessUserInput;
        }

        private void ProcessUserInput(object sender, string expression)
        {
            try
            {
            Expression = expression.Replace(" ", "");
            bool validParenthesesExpression = IsValidParentheses(Expression);
            bool validExpression = IsValidSyntax(Expression);
            if (!validParenthesesExpression || !validExpression)
            {
                ShowErrorMessage("Please enter a valid expression.");
            }
            else
            {
                double result = expressionCalculator.EvaluateExpression(Expression);
                winForm.UpdatelblResult(result);
            }

            }
            catch (Exception)
            {

                throw;
            }

        }
        public bool IsValidParentheses(string expression)
        {
            int parenthesesCounter = 0;
            try
            {
            foreach (char c in expression)
            {
                if (c == '(')
                {
                    parenthesesCounter++;
                }
                if (c == ')')
                {
                    parenthesesCounter--;
                }
                if (parenthesesCounter < 0)
                {
                    return false; 
                }
            }

            return parenthesesCounter == 0;

            }
            catch (Exception)
            {

                throw;
            }

                        
        }

        public bool IsValidSyntax(string expression)
        {
            HashSet<char> validOperators = new HashSet<char> { '+', '-', '*', '/', '.' };
            try
            {
            for (int i = 0; i < expression.Length; i++)
            {
                char currentChar = expression[i];

                if (validOperators.Contains(currentChar))
                {
                    
                    if (i == 0 || i == expression.Length - 1)
                    {
                        return false; 
                    }

                    char prevChar = expression[i - 1];
                    char nextChar = expression[i + 1];

                    if (prevChar == '(' || nextChar == ')' || !IsValidCharacter(nextChar))
                    {
                        return false; 
                    }
                }
            }

            return true; 

            }
            catch (Exception)
            {

                throw;
            }


        }

        private bool IsValidCharacter(char c)
        {
            HashSet<char> validCharacters = new HashSet<char> { '(', ')', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            try
            {

            return validCharacters.Contains(c);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
