using System;
using System.Net.NetworkInformation;
using UnorderList.UnorderList;
using UnorderList.UnorderListQueue;
using UnorderList.UnorderListStack;

namespace UnorderList
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