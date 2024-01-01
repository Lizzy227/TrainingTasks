namespace Task4_BitMEXOrderbook.WebSocket
{
    public class QueueHandler
    {
        private static readonly QueueHandler instance = new QueueHandler();
        public static QueueHandler Instance { get { return instance; } }

        private Queue<string> _eventQueue = new Queue<string>();
        public QueueHandler() {
            
        }
        public void AddEventToQueue(string IncomingResult)
        {
            try
            {
                _eventQueue.Enqueue(IncomingResult);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Queue<string> GetEventQueue()
        {
            try
            {
                return _eventQueue;
            }
            catch
            {

            }
            return new Queue<string>();
        }

        public void RemoveFirstEventFromQueue()
        {
            try
            {
                _eventQueue.Dequeue();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}