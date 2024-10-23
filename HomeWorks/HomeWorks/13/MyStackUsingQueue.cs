namespace HomeWorks;

public class MyStackUsingQueue
{
    private MyQueue queue;

    public MyStackUsingQueue()
    {
        queue = new MyQueue();
    }

    public void Push(int item)
    {
        int size = queue.Count();
        queue.Enqueue(item);

        // Move all elements before the newly added item to the end of the queue
        for (int i = 0; i < size; i++)
        {
            queue.Enqueue(queue.Dequeue());
        }
    }

    public int Pop()
    {
        return queue.Dequeue();
    }

    public int Peek()
    {
        return queue.Peek();
    }

    public void PrintAllItems()
    {
        queue.PrintAllItems();
    }
}
