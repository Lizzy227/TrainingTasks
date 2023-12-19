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
        private static readonly ILog log = LogManager.GetLogger(typeof(Subscribers));
        private HashSet<Logger.MessageCallback> subscribedEvenCallbacks = new HashSet<Logger.MessageCallback>();
        private HashSet<Logger.MessageCallback> subscribedOddCallbacks = new HashSet<Logger.MessageCallback>();

        private TextBox tbBoth;
        private TextBox tbEven;
        private TextBox tbOdd;


        public Subscribers(TextBox tbBoth, TextBox tbEven, TextBox tbOdd)
        {
            this.tbBoth = tbBoth;
            this.tbEven = tbEven;
            this.tbOdd = tbOdd;
        }
        public void SubscribeToBothMessageEvents(Logger logger)
        {
            try
            {
            logger.EvenMessageReceivedEvent += HandleBothMessageEvent;
            logger.OddMessageReceivedEvent += HandleBothMessageEvent;
                log.Info("Subscribed to both events");
            }
            catch (Exception ex)
            {

                log.Error($"Error subscribing to Both events: {ex.Message}");
            }
        }

        public void SubscribeToEvenMessagesEvent(Logger logger, Logger.MessageCallback evenCallback)
        {
            if (subscribedEvenCallbacks.Contains(evenCallback))
            {
                return;
            }

            try
            {

                logger.EvenMessageReceivedEvent += evenCallback;
                subscribedEvenCallbacks.Add(evenCallback);
                log.Info("Callback subscribed to Even event");
            }
            catch (Exception ex)
            {

                log.Error($"Error subscribing to Even event: {ex.Message}");
            }

        }

        public void SubscribeToOddMessagesEvent(Logger logger, Logger.MessageCallback oddCallback)
        {
            if (subscribedOddCallbacks.Contains(oddCallback))
            {
                return;
            }

            try
            {
                logger.OddMessageReceivedEvent += oddCallback;
                subscribedOddCallbacks.Add(oddCallback);
                log.Info("Callback subscribed to Odd event");

            }
            catch (Exception ex)
            {

                log.Error($"Error subscribing to Odd event: {ex.Message}");
            }

        }

        public void UnsubscribeFromBothMessageEvents(Logger logger)
        {
            try
            {
                logger.EvenMessageReceivedEvent -= HandleBothMessageEvent;
                logger.OddMessageReceivedEvent -= HandleBothMessageEvent;
                log.Info("Unsubscribed from both events");
            }
            catch (Exception ex)
            {

                log.Error($"Error unsubscribing from Both events: {ex.Message}");
            }
        }
        public void UnsubscribeFromEvenMessagesEvent(Logger logger, Logger.MessageCallback evenCallback)
        {
            if (!subscribedEvenCallbacks.Contains(evenCallback))
            {
                return;
            }

            try
            {

                logger.EvenMessageReceivedEvent -= evenCallback;
                subscribedEvenCallbacks.Remove(evenCallback);
                log.Info("Callback unsubscribed from Even event");
            }
            catch (Exception ex)
            {

                log.Error($"Error unsubscribing from Even event: {ex.Message}");
            }
        }

        public void UnsubscribeFromOddMessagesEvent(Logger logger, Logger.MessageCallback oddCallback)
        {
            if (!subscribedOddCallbacks.Contains(oddCallback))
            {
                return;
            }

            try
            {
                logger.OddMessageReceivedEvent -= oddCallback;
                subscribedOddCallbacks.Remove(oddCallback);
                log.Info("Callback subscribed from Odd event");

            }
            catch (Exception ex)
            {

                log.Error($"Error unsubscribing from Odd event: {ex.Message}");
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

                log.Error($"Error updating textbox: {ex.Message}");
            }
        }
    }
}
