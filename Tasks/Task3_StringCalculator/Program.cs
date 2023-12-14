using Task3_StringCalculator;

namespace Task3_ExpressionEvaluator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ExpressionEvaluatorMain view = new ExpressionEvaluatorMain();
            ExpressionEvaluatorModel model = new ExpressionEvaluatorModel(); // Instantiate the model
            ExpressionEvaluatorController controller = new ExpressionEvaluatorController(view, model);
            Application.Run(view);
        }
    }
}