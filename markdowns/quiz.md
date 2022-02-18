# Time for a quiz

You read a lot so far.
Now it is time to test your knowledge!

We present some statements, you answer the questions.

# Example 1

```c#
var people = new List<Person>()
{
    new Person() { Name = "Samina Stephenson", Age = 9 },
    new Person() { Name = "Jaydon Heath", Age = 82 },
    new Person() { Name = "Imaani Macgregor", Age = 66 },
    new Person() { Name = "Caiden Leonard", Age = 52 }
};

var result = people.FirstOrDefault(p => p.Age > 60 && p.Age < 70);
```

?[Name the person(s) returned in Example 1?](multiple)
-[ ] Samina Stephenson
-[ ] Jaydon Heath
-[x] Imaani Macgregor
-[ ] Caiden Leonard


# Example 2

```c#
var people = new List<Person>()
{
    new Person() { Name = "Samina Stephenson", Age = 9 },
    new Person() { Name = "Jaydon Heath", Age = 82 },
    new Person() { Name = "Imaani Macgregor", Age = 66 },
    new Person() { Name = "Caiden Leonard", Age = 52 }
};

var result = people
                .Where(x => x.Age >= 30)
                .Take(2)
                .Select(x => x.Name)
                .Last();
```

?[What is the type of the result?]
-[ ] IEnumerable&lt;Person&gt;
-[ ] IEnumerable&lt;string&gt;
-[] Person
-[x] string
-[] It throws an exception

?[Name the person(s) returned in Example 2?](multiple)
-[ ] Samina Stephenson
-[ ] Jaydon Heath
-[x] Imaani Macgregor
-[ ] Caiden Leonard
