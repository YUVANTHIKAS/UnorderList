using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnorderedList.UnorderedListQueue
{
    public class OperationQueue
    {
        public void ReadFileAndPerformOperation(string filePath)
        {
            Queue<string> queue = new Queue<string>();
            string readAllText = File.ReadAllText(filePath);
            string[] words = readAllText.Split(" ");
            foreach (var data in words)
            {
                queue.Enqueue(data);
            }
            queue.Display();
            Console.WriteLine("Dequeue:");
            queue.Dequeue();
            queue.Display();
        }
    }
}
