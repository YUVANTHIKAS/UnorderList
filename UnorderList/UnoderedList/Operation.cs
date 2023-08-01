using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnorderedList.UnorderedList
{
    public class Operation
    {
        public void ReadFileAndPerformOperation(string filePath)
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            string readAllText = File.ReadAllText(filePath);
            string[] words = readAllText.Split(" ");
            foreach (var data in words)
            {
                linkedList.Add(data);
            }
            linkedList.Display();
            linkedList.Display();
            Console.WriteLine("\nEnter a word :");
            string word = Console.ReadLine();
            int position = linkedList.Search(word);
            if(position == -1)
            {
                linkedList.Add(word);
            }
            else
            {
                linkedList.DeleteNodeAtParticularPosition(position);
            }
            linkedList.Display();
        }
        public void WriteToFile(string filepath)
        {
            string content = string.Join("," , linkedList);
            File.WriteAllText(filepath, content);
        }
    }
}