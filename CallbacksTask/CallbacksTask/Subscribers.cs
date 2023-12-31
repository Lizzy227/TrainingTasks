﻿using ConcurrentCollections;
using log4net;
using log4net.Core;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbacksTask
{
    internal class Subscribers
    {
        private ConcurrentDictionary<string, ConcurrentHashSet<Func<SimpleEventArgs, Task>>> _simpleSubscribers = new();

        //Keats: this is a way of defining event handlers as callbacks. Now try and include callbacks in the form of:
        //private ConcurrentDictionary<string, ConcurrentHashSet<Func<SimpleEventArgs, Task>>> _simpleSubscribers = new();
        //This will mean your function signatures will change to pass a Func<SimpleEventArgs, Task> instead of SimpleMessageProvider.MessageCallback evenCallback, for example.

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
                LizLogger.Instance.Log(typeof(Subscribers), Level.Info, "Subscribed to BothEvents", null);
            }
            catch (Exception ex)
            {
                LizLogger.Instance.Log(typeof(Subscribers), Level.Error, $"Error subscribing to BothEvents: {ex.Message}", null);
            }
        }

        public void SubscribeToEvenMessagesEvent(SimpleMessageProvider simpleMessageProvider, Func<SimpleEventArgs, Task> evenCallback)
        {
            try
            {
                if (_simpleSubscribers["EvenMessageReceivedEvent"].Contains(evenCallback))
                {
                    return;
                }

                _simpleSubscribers.TryAdd("EvenMessageReceivedEvent", new ConcurrentHashSet<Func<SimpleEventArgs, Task>>());

                simpleMessageProvider.EvenMessageReceivedEvent += evenCallback;
                _simpleSubscribers["EvenMessageReceivedEvent"].Add(evenCallback);
                LizLogger.Instance.Log(typeof(Subscribers), Level.Info, "Subscribed to EvenEvent", null);
            }
            catch (Exception ex)
            {
                LizLogger.Instance.Log(typeof(Subscribers), Level.Error, $"Error subscribing to EvenEvent: {ex.Message}", null);
            }
        }

        public void SubscribeToOddMessagesEvent(SimpleMessageProvider simpleMessageProvider, Func<SimpleEventArgs, Task> oddCallback)
        {
            if (subscribedOddCallbacks.Contains(oddCallback))
            {
                return;
            }

            try
            {
                simpleMessageProvider.OddMessageReceivedEvent += oddCallback;
                subscribedOddCallbacks.Add(oddCallback);
                LizLogger.Instance.Log(typeof(Subscribers), Level.Info, "Subscribed to OddEvent", null);

            }
            catch (Exception ex)
            {
                LizLogger.Instance.Log(typeof(Subscribers), Level.Error, $"Error subscribing to OddEvent: {ex.Message}", null);
            }
        }

        public void UnsubscribeFromBothMessageEvents(SimpleMessageProvider simpleMessageProvider)
        {
            try
            {
                simpleMessageProvider.EvenMessageReceivedEvent -= HandleBothMessageEvent;
                simpleMessageProvider.OddMessageReceivedEvent -= HandleBothMessageEvent;
                LizLogger.Instance.Log(typeof(Subscribers), Level.Info, "Unsubscribed from BothEvents", null);
            }
            catch (Exception ex)
            {
                LizLogger.Instance.Log(typeof(Subscribers), Level.Error, $"Error unsubscribing from BothEvents: {ex.Message}", null);
            }
        }

        public void UnsubscribeFromEvenMessagesEvent(SimpleMessageProvider simpleMessageProvider, Func<SimpleEventArgs, Task>)
        {
            if (!subscribedEvenCallbacks.Contains(evenCallback))
            {
                LizLogger.Instance.Log(typeof(Subscribers), Level.Info, "There's no EvenEvent to unsubscribe from", null);
                return;
            }

            try
            {
                simpleMessageProvider.EvenMessageReceivedEvent -= evenCallback;
                subscribedEvenCallbacks.Remove(evenCallback);
                LizLogger.Instance.Log(typeof(Subscribers), Level.Info, "Unsubscribed from EvenEvent", null);
            }
            catch (Exception ex)
            {
                LizLogger.Instance.Log(typeof(Subscribers), Level.Error, $"Error unsubscribing from EvenEvent: {ex.Message}", null);
            }
        }

        public void UnsubscribeFromOddMessagesEvent(SimpleMessageProvider simpleMessageProvider, Func<SimpleEventArgs, Task>)
        {
            if (!subscribedOddCallbacks.Contains(oddCallback))
            {
                LizLogger.Instance.Log(typeof(Subscribers), Level.Info, "There's no OddEvent to unsubscribe from", null);
                return;
            }

            try
            {
                simpleMessageProvider.OddMessageReceivedEvent -= oddCallback;
                subscribedOddCallbacks.Remove(oddCallback);
                LizLogger.Instance.Log(typeof(Subscribers), Level.Info, "Unsubscribed from OddEvent", null);

            }
            catch (Exception ex)
            {
                LizLogger.Instance.Log(typeof(Subscribers), Level.Error, $"Error unsubscribing from OddEvent: {ex.Message}", null);
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
                LizLogger.Instance.Log(typeof(Subscribers), Level.Error, $"Error updating textbox: {ex.Message}", null);
            }
        }
    }
}
