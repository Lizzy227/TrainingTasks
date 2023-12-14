using Task1_CountdownTimer;

namespace Tasks
{
    public partial class TasksMenu : Form
    {
        public TasksMenu()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHam_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void taskOne_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void timerMethod_Click(object sender, EventArgs e)
        {

        }
        private void asyncMethod_Click(object sender, EventArgs e)
        {
            
        }

        private void Task1Button_Click(object sender, EventArgs e)
        {
            Task1_CountdownTimer.Task1_CountdownTimer countdownTimerForm = new Task1_CountdownTimer.Task1_CountdownTimer();
            countdownTimerForm.Show(); // Show the countdown timer form

        }
    }
}