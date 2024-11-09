using Janerics_3;
using System;

Repository<TestClass> personRepository = new Repository<TestClass>();
personRepository.Add(new TestClass { Name = "A", Age = 1 });
personRepository.Add(new TestClass { Name = "B", Age = 2 });

Console.WriteLine("Первый эллемент: " + personRepository.Get(0).Name);
Console.WriteLine("Всего эллементов: " + personRepository.Count);