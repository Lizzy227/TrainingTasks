using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Task3_ExpressionEvaluator
{
    internal class ExpressionCalculator
    {
        public string MultiValue { get; set; }
        public double MultiValueAsDouble { get; set; }
        public Stack<double> Operands { get; set; }
        public Stack<char> Operators { get; set; }
        public Dictionary<char, int> Precedence { get; set; }

        public ExpressionCalculator()
        {
            Operands = new Stack<double>();
            Operators = new Stack<char>();           
            MultiValue = "";
            Precedence = new Dictionary<char, int>
        {
            {'+', 1 },
            {'-', 1 },
            {'*', 2 },
            {'/', 2 }
        };
        }
        public double EvaluateExpression(string expression)
        {
            try
            {
            while (expression.Contains("("))
            {
                int openIndex = expression.LastIndexOf('(');
                int closeIndex = expression.IndexOf(")", openIndex);
                string subExpression = expression.Substring(openIndex + 1, closeIndex - openIndex - 1);
                double result = EvaluateSubExpression(subExpression);

                expression = expression.Substring(0,openIndex) + result.ToString() + expression.Substring(closeIndex + 1);
            }

            return EvaluateSubExpression(expression);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private double EvaluateSubExpression(string subExpression) 
        {
            try
            {
            foreach (char c in subExpression)
            {

                if (char.IsDigit(c) || c == '.')
                {
                    MultiValue += c;

                    continue;
                }
                
                if (Precedence.ContainsKey(c))
                {
                    if (MultiValue.Length > 0)
                    {
                            PushMultiValue();
                        }

                    while (Operators.Count > 0 && Precedence[c] <= Precedence[Operators.Peek()])
                    {
                        ProcessOperations(Operands, Operators);
                    }

                    Operators.Push(c);
                }
                else if (MultiValue.Length > 0)
                {
                        PushMultiValue();
                }
            }
            if (MultiValue.Length > 0)
            {
                    PushMultiValue();
            }
            while (Operands.Count > 1)
            {
                ProcessOperations(Operands, Operators);
            }
            return Operands.Pop();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void PushMultiValue()
        {
            MultiValueAsDouble = double.Parse(MultiValue, CultureInfo.InvariantCulture);
            Operands.Push(MultiValueAsDouble);
            MultiValue = "";
        }

        static void ProcessOperations(Stack<double> operands, Stack<char> operators)
        {
            try
            {
            char operatorSymbol = operators.Pop();
            double operand2 = operands.Pop();
            double operand1 = operands.Pop();
            double result = 0;

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
                    result = operand1 / operand2;
                    break;
                default:
                    throw new Exception();
            }
            operands.Push(result);

            }
            catch (Exception)
            {

                throw;
            }



        }
    }
}
