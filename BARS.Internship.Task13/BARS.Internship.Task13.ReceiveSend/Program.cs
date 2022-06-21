using System;
using System.Threading;

namespace BARS.Internship.Task13.ReceiveSend
{
    class Program
    {
        private static int number;
        
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                var receiveThread = new Thread(Receive);
                var sendThread = new Thread(Send);
                receiveThread.Start(i);
                sendThread.Start();
                Thread.Sleep(1);
            }
        }

        public static void Receive(object obj)
        {
            number = (int)obj;
            Console.WriteLine($"Получено: {number}");
        }

        public static void Send()
        {
            Console.WriteLine($"Отправлено: {number}");
            number = 0;
        }
    }
}