using System;
using System.Threading;
using log4net;
using log4net.Config;

namespace CallbacksTask
{
    public partial class Form1 : Form
    {

        private Logger logger;
        private Subscribers subscribers;
        public Form1()
        {
            InitializeComponent();
            XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));
            logger = new Logger();
            subscribers = new Subscribers(textBoxLogs);

        }

        private void btnStartLogs_Click(object sender, EventArgs e)
        {
            try
            {

                subscribers.SubscribeToLoggerEvent(logger);
                logger.StartLogging();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnStopLogs_Click(object sender, EventArgs e)
        {
            try
            {
                subscribers.UnsubscribeFromLoggerEvent(logger);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                logger.StopLogging();
                subscribers.UnsubscribeFromLoggerEvent(logger);
            }
            catch (Exception)
            {

                throw;
            }

        }

        
        private void btnStartEvenCallback_Click(object sender, EventArgs e)
        {

        }

        private void btnStopEvenCallback_Click(object sender, EventArgs e)
        {

        }

       
    }
}
