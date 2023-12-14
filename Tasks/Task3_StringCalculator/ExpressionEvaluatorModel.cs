using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_ExpressionEvaluator
{
    public class ExpressionEvaluatorModel
    {
        public string Expression { get; set;  }
        public string ExpressionLeft { get; set; }
        public string ExpressionRight { get; set; }
        public string FoundDelimiter { get; set; }

        public string MultiValue { get; set; }
        public float MultiValueAsFloat { get; set; }

        public Stack<float> Operands { get; set; }
        public Stack<char> Operators { get; set; }
        public Stack<float> ExpressionResults { get; set; }

        public Dictionary<char, int> Precedence { get; set; }

        // Constructor to initialize stacks, dictionary, etc.
        public ExpressionEvaluatorModel()
        {
            Operands = new Stack<float>();
            Operators = new Stack<char>();
            ExpressionResults = new Stack<float>();
            MultiValue = "";

            Precedence = new Dictionary<char, int>
        {
            {'+', 1 },
            {'-', 1 },
            {'*', 2 },
            {'/', 2 }
        };
        }

        void ExpressionOrganizer(string expression)
        {
            string[] delimiters = { ">=", "<=", "==", "=", "<", ">" };
            FoundDelimiter = delimiters.FirstOrDefault(d => expression.Contains(d));

            if (!string.IsNullOrEmpty(FoundDelimiter))
            {
                string[] splitArray = expression.Split(new string[] { FoundDelimiter }, StringSplitOptions.RemoveEmptyEntries);

                if (splitArray.Length == 2)
                {
                    ExpressionLeft = splitArray[0];
                    ExpressionRight = splitArray[1];


                }
                else
                {
                    throw new Exception("Invalid input: String does not contain exactly one delimiter or there is no expression after the delimiter");
                }
            }

            else
            {
                throw new Exception("No valid delimiter found in the string");
            }
        }


        void Evaluator(string expression)
        {
            foreach (char c in expression)
            {

                if (char.IsDigit(c) || c == '.')
                {
                    MultiValue += c;

                    continue;
                }
                else if (c == '(')
                {
                    Operators.Push(c);
                }
                if (c == ')')
                {
                    while (Operators.Count > 0 && Operators.Peek() != '(')
                    {
                        if (MultiValue.Length > 0)
                        {
                            MultiValueAsFloat = float.Parse(MultiValue, CultureInfo.InvariantCulture);
                            Operands.Push(MultiValueAsFloat);
                            MultiValue = "";
                        }

                        ProcessOperations(Operands, Operators);
                    }

                }
                else if (Precedence.ContainsKey(c))
                {
                    if (Operators.Count > 0 && Operators.Peek() == '(')
                    {
                        Operators.Pop(); // Discard the '('
                    }
                    while (Operators.Count > 0 && Precedence[c] <= Precedence[Operators.Peek()])
                    {
                        if (MultiValue.Length > 0)
                        {
                            MultiValueAsFloat = float.Parse(MultiValue, CultureInfo.InvariantCulture);
                            Operands.Push(MultiValueAsFloat);
                            MultiValue = "";
                        }
                        ProcessOperations(Operands, Operators);
                    }

                    Operators.Push(c);
                }
                else if (MultiValue.Length > 0)
                {
                    MultiValueAsFloat = float.Parse(MultiValue, CultureInfo.InvariantCulture);
                    Operands.Push(MultiValueAsFloat);
                    MultiValue = "";
                }
            }
            if (MultiValue.Length > 0)
            {
                MultiValueAsFloat = float.Parse(MultiValue, CultureInfo.InvariantCulture);
                Operands.Push(MultiValueAsFloat);
                MultiValue = "";
            }
            if (Operators.Count > 0)
            {
                ProcessOperations(Operands, Operators);
            }
            ExpressionResults.Push(Operands.Pop());
        }

        bool ExpressionComparer()
        {
            string delimiter = FoundDelimiter;
            float expressionResultRight = ExpressionResults.Pop();
            float expressionResultLeft = ExpressionResults.Pop();
            bool result = false;

            switch (delimiter)
            {
                case "=":
                    if (expressionResultLeft == expressionResultRight)
                    {
                        result = true;
                    }
                    break;

                case "<":
                    if (expressionResultLeft < expressionResultRight)
                    {
                        result = true;
                    }
                    break;

                case ">":
                    if (expressionResultLeft > expressionResultRight)
                    {
                        result = true;
                    }
                    break;

                case "==":
                    if (expressionResultLeft == expressionResultRight)
                    {
                        result = true;
                    }
                    break;

                case "<=":
                    if (expressionResultLeft <= expressionResultRight)
                    {
                        result = true;
                    }
                    break;

                case ">=":
                    if (expressionResultLeft >= expressionResultRight)
                    {
                        result = true;
                    }
                    break;

                default:

                    throw new Exception();


            }
            return result;
        }

        static void ProcessOperations(Stack<float> operands, Stack<char> operators)
        {
            char operatorSymbol = operators.Pop();
            float operand1 = operands.Pop();
            float operand2 = operands.Pop();
            float result = 0;

            switch (operatorSymbol)
            {
                case '+':
                    result = operand1 + operand2;
                    break;

                case '-':
                    result = operand1 - operand2;
                    break;

                case '*':
                    result = operand1 * operand2;
                    break;

                case '/':
                    result = operand2 / operand1;
                    break;
                default:
                    throw new Exception();
            }
            operands.Push(result);



        }

      public bool EvaluateExpression()
        {
            ExpressionOrganizer(Expression);
            Evaluator(ExpressionLeft); 
            Evaluator(ExpressionRight);
            return ExpressionComparer();

        }

    }


}