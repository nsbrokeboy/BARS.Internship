using System;
using System.Runtime.Serialization;
using System.Threading;

namespace BARS.Internship.Task12.WriterReader
{
    class Program
    {
        static void Main(string[] args)
        {
            var transaction = new Transaction();
            var parameters = new Parameters(transaction, 30);


            var threadStartWrite = new ParameterizedThreadStart(TransactionWriteTest);
            var threadWrite = new Thread(threadStartWrite);

            var threadStartRead = new ParameterizedThreadStart(TransactionReadTest);
            var threadRead = new Thread(threadStartRead);

            threadRead.Start(parameters);
            threadWrite.Start(parameters);
        }

        private static void TransactionWriteTest(object obj)
        {
            var parameters = obj as Parameters;
            for (int i = 0; i < parameters.count; i++)
            {
                parameters._transaction.PerformTransaction();
                // Thread.Sleep(1);
            }
        }

        private static void TransactionReadTest(object obj)
        {
            var parameters = obj as Parameters;
            for (int i = 0; i < parameters.count; i++)
            {
                parameters._transaction.LastTransaction();
                // Thread.Sleep(1);
            }
        }
    }

    class Parameters
    {
        public Transaction _transaction;
        public int count;

        public Parameters(Transaction transaction, int count)
        {
            _transaction = transaction;
            this.count = count;
        }
    }
}