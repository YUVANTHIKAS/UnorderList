using System;
using System.Net.NetworkInformation;
using UnorderedList.UnorderedList;
using UnorderedList.UnorderedListQueue;
using UnorderedList.UnorderedListStack;

namespace UnorderedList
{
    class Program
    {
        static string unOrderedFilePath = @"D:\BridgeLabs Training\UnorderedList\UnorderedList\UnorderedList\UnOrderList.txt";
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            operation.ReadFileAndPerformOperation(unOrderedFilePath);
            Console.WriteLine("\nStack:");
            OperationStack operationStack = new OperationStack();
            operationStack.ReadFileAndPerformOperation(unOrderedFilePath);
            Console.WriteLine("\nQueue:");
            OperationQueue operationqueue = new OperationQueue();
            operationqueue.ReadFileAndPerformOperation(unOrderedFilePath);

        }
    }
}