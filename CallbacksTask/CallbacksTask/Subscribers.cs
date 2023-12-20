using log4net;
using log4net.Core;
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
                Logger.Instance.Log(typeof(Subscribers), Level.Info, "Subscribed to BothEvents", null);
            }
            catch (Exception ex)
            {                               
                Logger.Instance.Log(typeof(Subscribers), Level.Error, $"Error subscribing to BothEvents: {ex.Message}", null);
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
                Logger.Instance.Log(typeof(Subscribers), Level.Info, "Subscribed to EvenEvent", null);                
            }
            catch (Exception ex)
            {                                
                Logger.Instance.Log(typeof(Subscribers), Level.Error, $"Error subscribing to EvenEvent: {ex.Message}", null);
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
                Logger.Instance.Log(typeof(Subscribers), Level.Info, "Subscribed to OddEvent", null);

            }
            catch (Exception ex)
            {                                
                Logger.Instance.Log(typeof(Subscribers), Level.Error, $"Error subscribing to OddEvent: {ex.Message}", null);
            }

        }

        public void UnsubscribeFromBothMessageEvents(SimpleMessageProvider simpleMessageProvider)
        {
            try
            {
                simpleMessageProvider.EvenMessageReceivedEvent -= HandleBothMessageEvent;
                simpleMessageProvider.OddMessageReceivedEvent -= HandleBothMessageEvent;               
                Logger.Instance.Log(typeof(Subscribers), Level.Info, "Unsubscribed from BothEvents", null);
            }
            catch (Exception ex)
            {                                
                Logger.Instance.Log(typeof(Subscribers), Level.Error, $"Error unsubscribing from BothEvents: {ex.Message}", null);
            }
        }
        public void UnsubscribeFromEvenMessagesEvent(SimpleMessageProvider simpleMessageProvider, SimpleMessageProvider.MessageCallback evenCallback)
        {
            if (!subscribedEvenCallbacks.Contains(evenCallback))
            {                
                Logger.Instance.Log(typeof(Subscribers), Level.Info, "There's no EvenEvent to unsubscribe from", null);
                return;
            }

            try
            {

                simpleMessageProvider.EvenMessageReceivedEvent -= evenCallback;
                subscribedEvenCallbacks.Remove(evenCallback);                
                Logger.Instance.Log(typeof(Subscribers), Level.Info, "Unsubscribed from EvenEvent", null);
            }
            catch (Exception ex)
            {                                
                Logger.Instance.Log(typeof(Subscribers), Level.Error, $"Error unsubscribing from EvenEvent: {ex.Message}", null);
            }
        }

        public void UnsubscribeFromOddMessagesEvent(SimpleMessageProvider simpleMessageProvider, SimpleMessageProvider.MessageCallback oddCallback)
        {
            if (!subscribedOddCallbacks.Contains(oddCallback))
            {                
                Logger.Instance.Log(typeof(Subscribers), Level.Info, "There's no OddEvent to unsubscribe from", null);
                return;
            }

            try
            {
                simpleMessageProvider.OddMessageReceivedEvent -= oddCallback;
                subscribedOddCallbacks.Remove(oddCallback);                
                Logger.Instance.Log(typeof(Subscribers), Level.Info, "Unsubscribed from OddEvent", null);

            }
            catch (Exception ex)
            {                                
                Logger.Instance.Log(typeof(Subscribers), Level.Error, $"Error unsubscribing from OddEvent: {ex.Message}", null);
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
                Logger.Instance.Log(typeof(Subscribers), Level.Error, $"Error updating textbox: {ex.Message}", null);
            }
        }
    }
}
