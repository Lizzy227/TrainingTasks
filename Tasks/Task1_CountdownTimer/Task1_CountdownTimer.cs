using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Task1_CountdownTimer
{
    public partial class Task1_CountdownTimer : Form
    {
        private CancellationTokenSource _cancellationTokenSource;


        public Task1_CountdownTimer()
        {
            InitializeComponent();
            durationNum.ValueChanged += durationNum_ValueChanged;
            stepNum.ValueChanged += stepNum_ValueChanged;
            counterDisplay.ReadOnly = true;
        }


        private int _nStartTime;
        private bool _isCounting = false;

        private void StartCounterButton_Click(object sender, EventArgs e)
        {
            if (stepNum.Value <= 0 || durationNum.Value <= 0)
            {
                MessageBox.Show("Duration and step number should be positive values.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (stepNum.Value > durationNum.Value)
            {
                MessageBox.Show("Step number cannot be bigger than duration.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_isCounting)
            {

                counterDisplay.Text = _nStartTime.ToString();
                


                if (methodSwitch.Switched)
                {
                    CountDownAsync();
                }
                else
                {
                    CountDownTimer();
                }

                methodSwitch.Enabled = false;
            }
        }
        private int _nStepValue;
       
        public async void CountDownAsync()
        {
            _isCounting = true;
            _cancellationTokenSource = new CancellationTokenSource();

           
            while (_nStartTime > 0)
            {
                if (_cancellationTokenSource.Token.IsCancellationRequested)
                {
                    _isCounting = false;
                    break;
                }

               
                
               int delay = Math.Min(_nStartTime, _nStepValue);
               await Task.Delay(delay * 1000);
               _nStartTime -= delay;

               counterDisplay.Text = _nStartTime.ToString();
                
                
            }

            _isCounting = false;
            methodSwitch.Enabled = true;
            _nStartTime = 0;
            _nStepValue = 0;
            counterDisplay.Text = _nStartTime.ToString();
            stepNum.Value = _nStepValue;
            durationNum.Value = _nStartTime;

        }

        public void CountDownTimer()
        {
            _isCounting = true;
            countdownTimer.Interval = _nStepValue * 1000;
            countdownTimer.Start();



        }



        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            if (!_isCounting)
            {
                return;
            }


            if (_nStartTime <= 0)
            {
                countdownTimer.Stop();
                _isCounting = false;
                methodSwitch.Enabled = true;

                _nStartTime = 0;
                _nStepValue = 0;
                counterDisplay.Text = _nStartTime.ToString();
                stepNum.Value = _nStepValue;
                durationNum.Value = _nStartTime;

                return;
            }

            
            
                
            
            int delay = Math.Min(_nStartTime, _nStepValue);
            
            countdownTimer.Interval = delay * 1000;
            
            _nStartTime -= delay;
            
            counterDisplay.Text = _nStartTime.ToString();


            
            
            
            return;
                
            
            
                
        }

        private void methodSwitch_SwitchedChanged(object sender)
        {

            if (methodSwitch.Switched)
            {
                asyncLabel.ForeColor = Color.FromArgb(128, 255, 128);
                timerLabel.ForeColor = Color.FromArgb(29, 200, 238);
            }
            else
            {
                timerLabel.ForeColor = Color.FromArgb(128, 255, 128);
                asyncLabel.ForeColor = Color.FromArgb(29, 200, 238);
            }

        }
        public void durationNum_ValueChanged(object sender, EventArgs e)
        {
            _nStartTime = Convert.ToInt32(durationNum.Value);
            CheckForInaccuracies();

            if (_isCounting)
            {
                if (methodSwitch.Switched)
                {
                    countdownTimer.Stop();
                                       
                    _cancellationTokenSource?.Cancel();
                    
                    counterDisplay.Text = _nStartTime.ToString();
                    CountDownAsync();
                }
                else
                {
                    _isCounting = false;
                    countdownTimer.Stop();
                    counterDisplay.Text = _nStartTime.ToString();
                    CountDownTimer();
                }
            }
            else
            {
                counterDisplay.Text = _nStartTime.ToString();
            }
        }

        public void stepNum_ValueChanged(object sender, EventArgs e)
        {
            _nStepValue = Convert.ToInt32(stepNum.Value);
            CheckForInaccuracies();

            if (_isCounting)
            {
                if (methodSwitch.Switched)
                {
                    _cancellationTokenSource?.Cancel();
                    counterDisplay.Text = _nStartTime.ToString();
                    CountDownAsync();
                }
                else
                {
                    _isCounting = false;
                    countdownTimer.Stop();
                    counterDisplay.Text = _nStartTime.ToString();
                    CountDownTimer();
                }
            }
        }

        private void CheckForInaccuracies()
        {



            if (_nStepValue != 0 && _nStartTime % _nStepValue != 0)
            {
                inaccuracyLabel.Visible = true;
                inaccuracyLabel.Text = $"Note: Inaccuracies may occur due to remainder being {_nStartTime % _nStepValue}.";
            }
            else
            {
                inaccuracyLabel.Visible = false;
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (_isCounting)
            {
                _cancellationTokenSource?.Cancel();
                _isCounting = false;
                

                
                _nStartTime = 0; 
                _nStepValue = 0; 

               
                counterDisplay.Text = _nStartTime.ToString();
                stepNum.Value = _nStepValue;
                durationNum.Value = _nStartTime;
                methodSwitch.Enabled = true;
            }
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
           
        }
    }
}

