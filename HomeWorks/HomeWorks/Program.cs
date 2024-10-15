using HomeWorks;

Console.WriteLine("Hello Home Work 11 -> My List");
var myList = new MyList<int>();
myList.Add(1);
myList.Add(2);
foreach (var ml in myList)
{
    Console.WriteLine($"element = {ml}");
}

myList[0] = 17;
myList[1] = 347;
Console.WriteLine($"[0] = {myList[0]} && [1] = {myList[1]}");
Console.WriteLine($"Try to find 17 {myList.Find(17)}");
Console.WriteLine($"try to remove 17 {myList.Remove(17)}");
Console.WriteLine($"try to remove 17 {myList.Remove(17)}");
Console.WriteLine($"Try to find 17 {myList.Find(17)}");
myList.Remove(347);
myList.Add(112);
myList.Add(527);
myList.Add(527);
myList.Add(372);
Console.WriteLine($"Try to find 372 {myList.Find(372)}");

myList = myList + 5;
myList = myList + 10;
myList = myList - 527;
foreach (var ml in myList)
{
    Console.WriteLine($"element = {ml}");
}
