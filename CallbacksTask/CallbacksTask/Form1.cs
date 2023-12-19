using System;
using System.Threading;
using log4net;
using log4net.Config;

namespace CallbacksTask
{
    public partial class Form1 : Form
    {

        private SimpleMessageProvider simpleMessageProvider;
        private Subscribers subscribers;
        private ILogger logger = Logger.Instance;
        public Form1()
        {
            InitializeComponent();
            simpleMessageProvider = new SimpleMessageProvider();
            tbBothEvents.ReadOnly = true;
            tbEvenEvents.ReadOnly = true;
            tbOddEvents.ReadOnly = true;
            subscribers = new Subscribers(tbBothEvents, tbEvenEvents, tbOddEvents);
            
        }

        private void btnStartBoth_Click(object sender, EventArgs e)
        {
            try
            {
                logger?.LogInfo("Start button on BothEvents clicked");
                subscribers.SubscribeToBothMessageEvents(simpleMessageProvider);
                simpleMessageProvider.StartMessaging();
            }
            catch (Exception ex)
            {
                logger?.LogError($"Error clicking Start button on BothEvents: {ex.Message}");
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStopBoth_Click(object sender, EventArgs e)
        {
            try
            {
                logger?.LogInfo("Stop button on BothEvents clicked");
                subscribers.UnsubscribeFromBothMessageEvents(simpleMessageProvider);
            }
            catch (Exception ex)
            {
                logger?.LogError($"Error clicking Stop button on BothEvents: {ex.Message}");
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnStartEven_Click(object sender, EventArgs e)
        {
            try
            {
                logger?.LogInfo("Start button on EvenEvent clicked");
                SimpleMessageProvider.MessageCallback evenCallback = subscribers.HandleEvenMessageEvent;
                subscribers.SubscribeToEvenMessagesEvent(simpleMessageProvider, evenCallback);
            }
            catch (Exception ex)
            {
                logger?.LogError($"Error clicking Start button on EvenEvent: {ex.Message}");
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStopEven_Click(object sender, EventArgs e)
        {
            try
            {
                logger?.LogInfo("Stop button on EvenEvent clicked");
                SimpleMessageProvider.MessageCallback evenCallback = subscribers.HandleEvenMessageEvent;
                subscribers.UnsubscribeFromEvenMessagesEvent(simpleMessageProvider, evenCallback);
            }
            catch (Exception ex)
            {
                logger?.LogError($"Error clicking Stop button on EvenEvent: {ex.Message}");
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStartOdd_Click(object sender, EventArgs e)
        {
            try
            {
                logger?.LogInfo("Start button on OddEvent clicked");
                SimpleMessageProvider.MessageCallback oddCallback = subscribers.HandleOddMessageEvent;
                subscribers.SubscribeToOddMessagesEvent(simpleMessageProvider, oddCallback);
            }
            catch (Exception ex)
            {
                logger?.LogError($"Error clicking Start button on OddEvent: {ex.Message}");
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStopOdd_Click(object sender, EventArgs e)
        {
            try
            {
                logger?.LogInfo("Stop button on OddEvent clicked");
                SimpleMessageProvider.MessageCallback oddCallback = subscribers.HandleOddMessageEvent;
                subscribers.UnsubscribeFromOddMessagesEvent(simpleMessageProvider, oddCallback);
            }
            catch (Exception ex)
            {
                logger?.LogError($"Error clicking Stop button on OddEvent: {ex.Message}");
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                logger?.LogInfo("Application is closing");
                simpleMessageProvider.StopMessaging();
                subscribers.UnsubscribeFromBothMessageEvents(simpleMessageProvider);
            }
            catch (Exception ex)
            {
                logger?.LogError($"Error in Application closing: {ex.Message}");
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
