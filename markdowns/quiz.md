# Time for a quiz

You read a lot so far.
Now it is time to test your knowledge!

We present some statements, you answer the questions.

# Example 1 - Warmup

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



# Example 2 - Writing LINQ

In this example you are requested to write a simple LINQ query:

You get a collection of people and shoud return the names from people that are at least (>=) 30 years.


@[Exymple 2]({"stubs": ["Exercises/QuizExample2.cs"],"command": "TechIo.QuizExample2Test.Verify"})



# Example 3 - Understanding LINQ

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

?[Name the person(s) returned in Example 3?](multiple)
-[ ] Samina Stephenson
-[ ] Jaydon Heath
-[x] Imaani Macgregor
-[ ] Caiden Leonard