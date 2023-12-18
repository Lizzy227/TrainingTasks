using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbacksTask
{
    internal class CallbackManager
    {
        private HashSet<Logger.LogCallback> subscribedEvenCallbacks = new HashSet<Logger.LogCallback>();
        private HashSet<Logger.LogCallback> subscribedOddCallbacks = new HashSet<Logger.LogCallback>();

        public void SubscribeToEvenLogs(Logger logger, Logger.LogCallback evenCallback)
        {
            if (subscribedEvenCallbacks.Contains(evenCallback))
            {
                return;
            }

            try
            {

            logger.LogReceived += evenCallback;
            subscribedEvenCallbacks.Add(evenCallback);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void SubscribeToOddLogs(Logger logger, Logger.LogCallback oddCallback)
        {
            if (subscribedOddCallbacks.Contains(oddCallback))
            {
                return;
            }

            try
            {
            logger.LogReceived += oddCallback; 
            subscribedOddCallbacks.Add(oddCallback); 

            }
            catch (Exception)
            {

                throw;
            }

        }

        public void UnsubscribeToEvenLogs(Logger logger, Logger.LogCallback evenCallback)
        {
            if (!subscribedEvenCallbacks.Contains(evenCallback))
            {
                return;
            }

            try
            {

                logger.LogReceived -= evenCallback;
                subscribedEvenCallbacks.Remove(evenCallback);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UnsubscribeToOddLogs(Logger logger, Logger.LogCallback oddCallback)
        {
            if (!subscribedOddCallbacks.Contains(oddCallback))
            {
                return;
            }

            try
            {
                logger.LogReceived -= oddCallback;
                subscribedOddCallbacks.Add(oddCallback);

            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
