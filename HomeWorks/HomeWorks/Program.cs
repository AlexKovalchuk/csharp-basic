using HomeWorks;

void CalledWhenResized(int newSize)
{
    Console.WriteLine($"List was resized to {newSize}");
}

var myList = new MyList<int>();
myList.Add(1);
myList.Add(2);
myList.OnResize += CalledWhenResized;
myList.OnResizeFunc += int (int newSize) =>
{
    Console.WriteLine($"Resized this using FUNC {newSize}");
    return newSize;
};
myList.OnResizeAction += void (int newSize) =>
{
    Console.WriteLine($"Resized this using ACTION {newSize}");
};
myList.OnResizePredicate = bool (int newSize) =>
{
    Console.WriteLine($"Resized this using Predicate {newSize}");
    return true;
};
myList[0] = 17;
myList[1] = 347;
myList.Remove(347);
myList.Add(112);
myList.Add(527);
myList.Add(527);
myList.Add(372);
myList.Add(372);
myList.Add(372);
myList.Add(372);
myList.Add(372);
myList.Add(372);
myList.Add(372);
myList.Add(372);
myList.Add(372);
myList = myList + 5;
myList = myList + 10;
myList = myList - 527;
foreach (var ml in myList)
{
    Console.WriteLine($"element = {ml}");
}