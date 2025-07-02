using MyStructures;

var list = new MyList();

// Exist
list.Add(2);
Console.WriteLine(list.Exist(2)); // true
Console.WriteLine(list.Exist(3)); // false

list.Clear();

// AddRange
list.AddRange(new []{11, 22, 33});
Console.WriteLine(list.Get(0)); // 11
Console.WriteLine(list.Get(1)); // 22
Console.WriteLine(list.Get(2)); // 33

list.Clear();

// GetRange
list.AddRange(new [] {11, 22, 33});
var result = list.GetRange(0, 2);
Console.WriteLine(result.Get(0)); // 11
Console.WriteLine(result.Get(1)); // 22
Console.WriteLine(result.Get(2)); // 33