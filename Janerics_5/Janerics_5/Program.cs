using Janerics_5;

IStorage<int> storage = new ListStorage<int>();
storage.Add(1);
storage.Add(2);
Console.WriteLine("Первый элемент: " + storage.Get(0));