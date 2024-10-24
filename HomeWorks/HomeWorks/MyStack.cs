namespace HomeWorks;

public class MyStack
{
    private List<int> stack;

    public MyStack()
    {
        stack = new List<int>();
    }

    public MyStack(List<int>? items)
    {
        stack = new List<int>(items);
    }

    public void Push(int item)
    {
        stack.Add(item);
    }

    public int Pop()
    {
        if (stack.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        };
        int item = stack[^1];
        stack.RemoveAt(stack.Count-1);
        return item;
    }

    public int Peek()
    {
        if (stack.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        };

        return stack[^1];
    }

    public void PrintAllItems()
    {
        if (stack.Count == 0)
        {
            Console.WriteLine("The stack is empty");
            return;
        }
        Console.WriteLine("Items of stack are:");
        Console.Write("Tail ");
        for (int i = 0; i < stack.Count; i++)
        {
            Console.Write($"[index: {i} = {stack[i]}]");
            if(stack.Count-1 != i ) Console.Write(" <- ");
            else Console.WriteLine(" Head");
        }
    }
}