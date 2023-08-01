using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnorderedList.UnorderedListStack
{
    public class OperationStack
    {
        public void ReadFileAndPerformOperation(string filePath)
        {
            Stack<string> stack = new Stack<string>();
            string readAllText = File.ReadAllText(filePath);
            string[] words = readAllText.Split(" ");
            foreach (var data in words)
            {
                stack.Push(data);
            }
            stack.Display();
            Console.WriteLine("Pop:");
            stack.Pop();
            stack.Display();
            Console.WriteLine("Peek:");
            stack.Peek();
            stack.Display();
        }
    }
}