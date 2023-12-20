using System;
using System.Threading;
using log4net.Core;
using log4net.Config;

namespace CallbacksTask
{
    public partial class Form1 : Form
    {

        private SimpleMessageProvider simpleMessageProvider;
        private Subscribers subscribers;
        
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
                Logger.Instance.Log(typeof(Form1), Level.Info, "Start button on BothEvents clicked", null);
                subscribers.SubscribeToBothMessageEvents(simpleMessageProvider);
                simpleMessageProvider.StartMessaging();
            }
            catch (Exception ex)
            {                
                Logger.Instance.Log(typeof(Form1), Level.Error, $"Error clicking Start button on BothEvents: {ex.Message}", null);
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStopBoth_Click(object sender, EventArgs e)
        {
            try
            {                
                Logger.Instance.Log(typeof(Form1), Level.Info, "Stop button on BothEvents clicked", null);
                subscribers.UnsubscribeFromBothMessageEvents(simpleMessageProvider);
            }
            catch (Exception ex)
            {                
                Logger.Instance.Log(typeof(Form1), Level.Error, $"Error clicking Stop button on BothEvents: {ex.Message}", null);
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnStartEven_Click(object sender, EventArgs e)
        {
            try
            {                
                Logger.Instance.Log(typeof(Form1), Level.Info, "Start button on EvenEvent clicked", null);
                SimpleMessageProvider.MessageCallback evenCallback = subscribers.HandleEvenMessageEvent;
                subscribers.SubscribeToEvenMessagesEvent(simpleMessageProvider, evenCallback);
            }
            catch (Exception ex)
            {                
                Logger.Instance.Log(typeof(Form1), Level.Error, $"Error clicking Start button on EvenEvent: {ex.Message}", null);
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStopEven_Click(object sender, EventArgs e)
        {
            try
            {               
                Logger.Instance.Log(typeof(Form1), Level.Info, "Stop button on EvenEvent clicked", null);
                SimpleMessageProvider.MessageCallback evenCallback = subscribers.HandleEvenMessageEvent;
                subscribers.UnsubscribeFromEvenMessagesEvent(simpleMessageProvider, evenCallback);
            }
            catch (Exception ex)
            {                
                Logger.Instance.Log(typeof(Form1), Level.Error, $"Error clicking Stop button on EvenEvent: {ex.Message}", null);
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStartOdd_Click(object sender, EventArgs e)
        {
            try
            {                
                Logger.Instance.Log(typeof(Form1), Level.Info, "Start button on OddEvent clicked", null);
                SimpleMessageProvider.MessageCallback oddCallback = subscribers.HandleOddMessageEvent;
                subscribers.SubscribeToOddMessagesEvent(simpleMessageProvider, oddCallback);
            }
            catch (Exception ex)
            {                
                Logger.Instance.Log(typeof(Form1), Level.Error, $"Error clicking Start button on OddEvent: {ex.Message}", null);
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStopOdd_Click(object sender, EventArgs e)
        {
            try
            {                
                Logger.Instance.Log(typeof(Form1), Level.Info, "Stop button on OddEvent clicked", null);
                SimpleMessageProvider.MessageCallback oddCallback = subscribers.HandleOddMessageEvent;
                subscribers.UnsubscribeFromOddMessagesEvent(simpleMessageProvider, oddCallback);
            }
            catch (Exception ex)
            {                
                Logger.Instance.Log(typeof(Form1), Level.Error, $"Error clicking Stop button on OddEvent: {ex.Message}", null);
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
                SimpleMessageProvider.MessageCallback evenCallback = subscribers.HandleEvenMessageEvent;
                SimpleMessageProvider.MessageCallback oddCallback = subscribers.HandleOddMessageEvent;
            try
            {
                simpleMessageProvider.StopMessaging();
                subscribers.UnsubscribeFromBothMessageEvents(simpleMessageProvider);
                subscribers.UnsubscribeFromEvenMessagesEvent(simpleMessageProvider, evenCallback);
                subscribers.UnsubscribeFromOddMessagesEvent(simpleMessageProvider, oddCallback);
                                
                Logger.Instance.Log(typeof(Form1), Level.Info, "Application is closing", null);
            }
            catch (Exception ex)
            {                
                Logger.Instance.Log(typeof(Form1), Level.Error, $"Error in Application closing: {ex.Message}", null);
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
