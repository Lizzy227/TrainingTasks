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
            tbBothEvents.ReadOnly = true;
            tbEvenEvents.ReadOnly = true;
            tbOddEvents.ReadOnly = true;
            subscribers = new Subscribers(tbBothEvents, tbEvenEvents, tbOddEvents);

        }

        private void btnStartMessaging_Click(object sender, EventArgs e)
        {
            try
            {

                subscribers.SubscribeToBothMessageEvents(logger);
                logger.StartMessaging();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnStopMessaging_Click(object sender, EventArgs e)
        {
            try
            {
                subscribers.UnsubscribeFromBothMessageEvents(logger);

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
                logger.StopMessaging();
                subscribers.UnsubscribeFromBothMessageEvents(logger);
            }
            catch (Exception)
            {

                throw;
            }

        }


        private void btnStartEvenCallback_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.MessageCallback evenCallback = subscribers.HandleEvenMessageEvent;
                subscribers.SubscribeToEvenMessagesEvent(logger, evenCallback);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStopEvenCallback_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.MessageCallback evenCallback = subscribers.HandleEvenMessageEvent;
                subscribers.UnsubscribeFromEvenMessagesEvent(logger, evenCallback);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStartOddCallback_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.MessageCallback oddCallback = subscribers.HandleOddMessageEvent;
                subscribers.SubscribeToOddMessagesEvent(logger, oddCallback);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStopOddCallback_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.MessageCallback oddCallback = subscribers.HandleOddMessageEvent;
                subscribers.UnsubscribeFromOddMessagesEvent(logger, oddCallback);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
