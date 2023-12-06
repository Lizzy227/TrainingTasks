using System.Drawing.Text;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;


namespace ExceptionHandeling
{
    public partial class ExceptionHandler : Form
    {
        public ExceptionHandler()
        {
            InitializeComponent();
           


        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 5;
            int y = 0;

            int z = x / y;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 5;
            int y = 0;

            if (y == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }

            int z = x / y;


        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                int x = 5;
                int y = 0;

                int z = x / y;

            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            emptyMethod();

        }

        private void emptyMethod()
        {
            throw new NotImplementedException();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            emptyMethodWithTryCatch();
        }

        private void emptyMethodWithTryCatch()
        {
            try
            {

                throw new NotImplementedException();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                methodCallingMethod();
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void methodCallingMethod()
        {
            methodBeingCalled();
        }

        private void methodBeingCalled()
        {
            try
            {

                throw new NotImplementedException();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            methodA();
        }

        private void methodA()
        {
            methodB();

        }

        private void methodB()
        {
            methodC();

        }

        private void methodC()
        {
            try
            {

                throw new NotImplementedException();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AsyncMethod();
        }

        private async void AsyncMethod()
        {
            throw new InvalidOperationException("Intentional Failure");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AsyncMethodwithTryCatch();
        }

        private async void AsyncMethodwithTryCatch()
        {
            try
            {
                throw new InvalidOperationException("Intentional Failure");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //
        //Here the exception seems to be unobserved or not handled.
        //The method creates a completed task representing an exception.
        // The method throws the exception at the 'await' point.
        // The exception is caught by the 'await' operator and returned as part of the completed task to the calling method --> button10_Click.
        // The app continues running like nothing happened. Interesting....
        private void button10_Click(object sender, EventArgs e)
        {
            AsyncTaskMethod();
        }

        private async Task AsyncTaskMethod()
        {
            try
            {
                await Task.FromException(new Exception("Async operation failed"));
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AsyncTaskMethodWithTryCatch();
        }
        private async Task AsyncTaskMethodWithTryCatch()
        {

            try
            {
                await Task.FromException(new Exception("Async operation failed"));

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        bool timerRunning = false;

        private void button12_Click(object sender, EventArgs e)
        {
            if (!timerRunning)
            {
                timer1.Start();
                timerRunning = true;
                button12.Text = "Stop";
            }
            else
            {
                timer1.Stop();
                timerRunning = false;
                button12.Text = "Start";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            methodBeingCalled();
        }


        bool timerRunning2 = false;
        private void button13_Click(object sender, EventArgs e)
        {
            if (!timerRunning)
            {
                timer2.Start();
                timerRunning = true;
                button13.Text = "Stop";
            }
            else
            {
                timer2.Stop();
                timerRunning = false;
                button13.Text = "Start";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {

                throw new NotImplementedException();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private System.Threading.Timer threadingTimer;
        private void button14_Click(object sender, EventArgs e)
        {
            if (threadingTimer == null)
            {
                threadingTimer = new System.Threading.Timer(ThreadingTimer_Tick, null, 0, 1000);
            }
        }

        private void ThreadingTimer_Tick(object state)
        {
            try
            {
                threadingTimer.Change(1000, Timeout.Infinite);
            }
            catch (Exception ex)
            {

                throw new InvalidOperationException("Intentional Failure");
            }
        }

        private async void button15_Click(object sender, EventArgs e)
        {
            try
            {

                Task.Run(async () =>
                {
                    try
                    {
                        await AsyWork();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                });
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task AsyWork()
        {
            await Task.Run(async () =>
            {
                await Task.Delay(1000);
                throw new NotImplementedException();
            });
        }
    }
}
