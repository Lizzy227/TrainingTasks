﻿using Task4_BitMEXOrderbook;

namespace Task4_BitMEXOrderbook.WebSocket
{
    public static class MessageHandler
    {
        public static async Task HandleUpdateMessage(WebSocketEventArgs e)
        {
            try
            {
                string message = e.Message + ": " + DateTime.Now.ToString("HH:mm:ss");
            }
            catch (Exception ex)
            {
                //throw;
            }
        }

        public static async Task HandleInsertMessage(WebSocketEventArgs e)
        {
            try
            {
                string message = e.Message + ": " + DateTime.Now.ToString("HH:mm:ss");
            }
            catch (Exception ex)
            {
                //throw;
            }
        }

        public static async Task HandleDeleteMessage(WebSocketEventArgs e)
        {
            try
            {
                string message = e.Message + ": " + DateTime.Now.ToString("HH:mm:ss");
            }
            catch (Exception ex)
            {
                //throw;
            }
        }


    }
}
