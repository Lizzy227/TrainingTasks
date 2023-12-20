﻿using System;
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

    private readonly EvaluatorForm winForm;
        public string Expression {  get; private set; }

        public UserExpression(EvaluatorForm Form)
        {
            this.winForm = Form;
            this.winForm.UserInputReceived += ProcessUserInput;
        }

        private void ProcessUserInput(object sender, string expression)
        {

            Expression = expression.Replace(" ", "");
            bool validParenthesesExpression = IsValidParentheses(Expression);
            if (!validParenthesesExpression)
            {
                ShowErrorMessage("Please enter a valid expression. For a valid expression use these operators (/, *, +, -), equal pairs of parenthesis, and numbers from 0 to 9.");
            }
            else
            {
              IsValidSyntax(Expression);
            }

        }
        public bool IsValidParentheses(string expression)
        {
            int parenthesesCounter = 0;

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

        public bool IsValidSyntax(string expression)
        {
            HashSet<char> validOperators = new HashSet<char> { '+', '-', '*', '/', '.' };

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

        private bool IsValidCharacter(char c)
        {
            HashSet<char> validCharacters = new HashSet<char> { '(', ')', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            return validCharacters.Contains(c);
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
