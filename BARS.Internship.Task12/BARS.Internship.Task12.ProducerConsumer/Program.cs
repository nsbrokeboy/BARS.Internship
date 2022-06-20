using System;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace BARS.Internship.Task12.ProducerConsumer
{
    class Program
    {
        // BlockingCollectiob - https://ru.stackoverflow.com/questions/428327/%D0%98%D0%BC%D0%BF%D0%BB%D0%B5%D0%BC%D0%B5%D0%BD%D1%82%D0%B0%D1%86%D0%B8%D1%8F-producer-consumer-pattern
        // https://docs.microsoft.com/ru-ru/dotnet/standard/parallel-programming/how-to-implement-a-producer-consumer-dataflow-pattern
        
        static async Task Main()
        {
            var buffer = new BufferBlock<byte[]>();
            Produce(buffer);
            var consumerTask = ConsumeAsync(buffer);
            
            var bytesProcessed = await consumerTask;
            Console.WriteLine($"Processed {bytesProcessed:#,#} bytes.");
        }

        static void Produce(ITargetBlock<byte[]> target)
        {
            var rand = new Random();

            for (int i = 0; i < 100; ++ i)
            {
                var buffer = new byte[1024];
                rand.NextBytes(buffer);
                target.Post(buffer);
            }

            target.Complete();
        }
        
        static async Task<int> ConsumeAsync(ISourceBlock<byte[]> source)
        {
            int bytesProcessed = 0;

            while (await source.OutputAvailableAsync())
            {
                byte[] data = await source.ReceiveAsync();
                bytesProcessed += data.Length;
            }

            return bytesProcessed;
        }
        
        // если несколько получателей 
        static async Task<int> ManyConsumeAsync(IReceivableSourceBlock<byte[]> source)
        {
            int bytesProcessed = 0;
            while (await source.OutputAvailableAsync())
            {
                while (source.TryReceive(out byte[] data))
                {
                    bytesProcessed += data.Length;
                }
            }
            return bytesProcessed;
        }
    }
}