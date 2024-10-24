using System.Collections;

namespace HomeWorks;

public class MyQueue
{
    private List<int> queue;

    public MyQueue()
    {
        queue = new List<int>();
    }

    public MyQueue(List<int>? items)
    {
        queue = new List<int>(items);
    }

    public void Enqueue(int item)
    {
        queue.Add(item);
    }

    public int Dequeue()
    {
        if (queue.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        };
        int item = queue[0];
        queue.RemoveAt(0);
        return item;
    }

    public int Peek()
    {
        if (queue.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        };

        return queue[0];
    }

    public int Count()
    {
        return queue.Count;
    }

    public void PrintAllItems()
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("The queue is empty");
            return;
        }
        Console.WriteLine("Items of queue are:");
        Console.Write("Head ");
        for (int i = 0; i < queue.Count; i++)
        {
            Console.Write($"[index: {i} = {queue[i]}]");
            if(queue.Count-1 != i ) Console.Write(" => ");
            else Console.WriteLine(" Tail");
        }
    }
}