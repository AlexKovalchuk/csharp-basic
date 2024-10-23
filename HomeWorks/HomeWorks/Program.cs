using HomeWorks;

Console.WriteLine("Hello, World! This is Home Work #14: Queue & Stack");

/*
 * створитий класс MyStack<>, який буде мати методи як у стека,
 * при цьому всередині буде Черга. Жодного чітингу!
 * Допустимі структури в середині - черга.
 * Методи Черги які можна використовувати - Enqueue і Dequeue
 */

Console.WriteLine("");
Console.WriteLine("QUEUE");
MyQueue myQueue = new MyQueue();
myQueue.Enqueue(1);
myQueue.Enqueue(2);
myQueue.Enqueue(3);
myQueue.Enqueue(4);
myQueue.Enqueue(5);
myQueue.Enqueue(6);
myQueue.Enqueue(7);

myQueue.PrintAllItems();

myQueue.Dequeue();
myQueue.Peek();
myQueue.Dequeue();
myQueue.Peek();
myQueue.Dequeue();
myQueue.Peek();
myQueue.Dequeue();
myQueue.Peek();

myQueue.PrintAllItems();

myQueue.Dequeue();
myQueue.Dequeue();
myQueue.Dequeue();

myQueue.PrintAllItems();

Console.WriteLine("");
Console.WriteLine("STACK");
MyStack myStack = new MyStack();
myStack.Push(1);
myStack.Push(2);
myStack.Push(3);
myStack.Push(4);
myStack.Push(5);
myStack.Push(6);
myStack.Push(7);

myStack.PrintAllItems();

myStack.Pop();
myStack.Peek();
myStack.Pop();
myStack.Peek();
myStack.Pop();
myStack.Peek();
myStack.Pop();
myStack.Peek();

myStack.PrintAllItems();

myStack.Pop();
myStack.Pop();
myStack.Pop();

myStack.PrintAllItems();

Console.WriteLine("");
Console.WriteLine("STACK USING QUEUE");
MyStackUsingQueue myStackUsingQueue = new MyStackUsingQueue();
myStackUsingQueue.Push(1);
myStackUsingQueue.Push(2);
myStackUsingQueue.Push(3);
myStackUsingQueue.Push(4);
myStackUsingQueue.Push(5);
myStackUsingQueue.Push(6);
myStackUsingQueue.Push(7);

myStackUsingQueue.PrintAllItems();

myStackUsingQueue.Pop();
myStackUsingQueue.Peek();
myStackUsingQueue.Pop();
myStackUsingQueue.Peek();
myStackUsingQueue.Pop();
myStackUsingQueue.Peek();
myStackUsingQueue.Pop();
myStackUsingQueue.Peek();

myStackUsingQueue.PrintAllItems();

myStackUsingQueue.Pop();
myStackUsingQueue.Pop();
myStackUsingQueue.Pop();

myStackUsingQueue.PrintAllItems();
