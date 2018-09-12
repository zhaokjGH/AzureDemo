using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace FunctionAppDemo
{
    public static class Function2
    {
        [FunctionName("Function2")]
        public static void Run([QueueTrigger("myqueue-items", Connection = "")]string myQueueItem, TraceWriter log)
        {
            log.Info($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
