using log4net;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbacksTask
{
    internal class Subscribers
    {
        private ILogger logger = Logger.Instance;

        private HashSet<SimpleMessageProvider.MessageCallback> subscribedEvenCallbacks = new HashSet<SimpleMessageProvider.MessageCallback>();
        private HashSet<SimpleMessageProvider.MessageCallback> subscribedOddCallbacks = new HashSet<SimpleMessageProvider.MessageCallback>();

        private TextBox tbBoth;
        private TextBox tbEven;
        private TextBox tbOdd;


        public Subscribers(TextBox tbBoth, TextBox tbEven, TextBox tbOdd)
        {
            this.tbBoth = tbBoth;
            this.tbEven = tbEven;
            this.tbOdd = tbOdd;
        }

       
        public void SubscribeToBothMessageEvents(SimpleMessageProvider simpleMessageProvider)
        {
            try
            {
                simpleMessageProvider.EvenMessageReceivedEvent += HandleBothMessageEvent;
                simpleMessageProvider.OddMessageReceivedEvent += HandleBothMessageEvent;
                logger?.LogInfo("Subscribed to BothEvents");
            }
            catch (Exception ex)
            {

                logger?.LogError($"Error subscribing to BothEvents: {ex.Message}");
            }
        }

        public void SubscribeToEvenMessagesEvent(SimpleMessageProvider simpleMessageProvider, SimpleMessageProvider.MessageCallback evenCallback)
        {
            if (subscribedEvenCallbacks.Contains(evenCallback))
            {
                return;
            }

            try
            {

                simpleMessageProvider.EvenMessageReceivedEvent += evenCallback;
                subscribedEvenCallbacks.Add(evenCallback);
                logger?.LogInfo("Callback subscribed to EvenEvent");
            }
            catch (Exception ex)
            {

                logger?.LogError($"Error subscribing to EvenEvent: {ex.Message}");
            }

        }

        public void SubscribeToOddMessagesEvent(SimpleMessageProvider simpleMessageProvider, SimpleMessageProvider.MessageCallback oddCallback)
        {
            if (subscribedOddCallbacks.Contains(oddCallback))
            {
                return;
            }

            try
            {
                simpleMessageProvider.OddMessageReceivedEvent += oddCallback;
                subscribedOddCallbacks.Add(oddCallback);
                logger?.LogInfo("Callback subscribed to OddEvent");

            }
            catch (Exception ex)
            {

                logger?.LogError($"Error subscribing to OddEvent: {ex.Message}");
            }

        }

        public void UnsubscribeFromBothMessageEvents(SimpleMessageProvider simpleMessageProvider)
        {
            try
            {
                simpleMessageProvider.EvenMessageReceivedEvent -= HandleBothMessageEvent;
                simpleMessageProvider.OddMessageReceivedEvent -= HandleBothMessageEvent;
                logger?.LogInfo("Unsubscribed from BothEvents");
            }
            catch (Exception ex)
            {

                logger?.LogError($"Error unsubscribing from BothEvents: {ex.Message}");
            }
        }
        public void UnsubscribeFromEvenMessagesEvent(SimpleMessageProvider simpleMessageProvider, SimpleMessageProvider.MessageCallback evenCallback)
        {
            if (!subscribedEvenCallbacks.Contains(evenCallback))
            {
                return;
            }

            try
            {

                simpleMessageProvider.EvenMessageReceivedEvent -= evenCallback;
                subscribedEvenCallbacks.Remove(evenCallback);
                logger?.LogInfo("Callback unsubscribed from EvenEvent");
            }
            catch (Exception ex)
            {

                logger?.LogError($"Error unsubscribing from EvenEvent: {ex.Message}");
            }
        }

        public void UnsubscribeFromOddMessagesEvent(SimpleMessageProvider simpleMessageProvider, SimpleMessageProvider.MessageCallback oddCallback)
        {
            if (!subscribedOddCallbacks.Contains(oddCallback))
            {
                return;
            }

            try
            {
                simpleMessageProvider.OddMessageReceivedEvent -= oddCallback;
                subscribedOddCallbacks.Remove(oddCallback);
                logger?.LogInfo("Callback unsubscribed from OddEvent");

            }
            catch (Exception ex)
            {

                logger?.LogError($"Error unsubscribing from OddEvent: {ex.Message}");
            }


        }
        public void HandleBothMessageEvent(object sender, SimpleEventArgs e)
        {
            string message = e.Message;
            UpdateTextBox(tbBoth, message);
        }
        public void HandleEvenMessageEvent(object sender, SimpleEventArgs e)
        {
            string message = e.Message;
            UpdateTextBox(tbEven, message);
        }

        public void HandleOddMessageEvent(object sender, SimpleEventArgs e)
        {
            string message = e.Message; ;
            UpdateTextBox(tbOdd, message);
        }

        private void UpdateTextBox(TextBox textBox, string message)
        {
            try
            {
                if (textBox.InvokeRequired)
                {
                    textBox.Invoke(new Action(() =>
                    {
                        textBox.AppendText(message + Environment.NewLine);
                    }));
                }
                else
                {
                    textBox.AppendText(message + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {

                logger?.LogError($"Error updating textbox: {ex.Message}");
            }
        }
    }
}
