# Time for a quiz

You read a lot so far.
Now it is time to test your knowledge!

# Warmup

```c#
var people = new List<Person>()
{
    new Person() { Name = "Samina Stephenson", Age = 9 },
    new Person() { Name = "Jaydon Heath", Age = 82 },
    new Person() { Name = "Imaani Macgregor", Age = 66 },
    new Person() { Name = "Caiden Leonard", Age = 52 }
};

var person = people.FirstOrDefault(p => p.Age > 60 && p.Age < 70);
```

?[Who are we looking for (value of person)?]
-[ ] Samina Stephenson
-[ ] Jaydon Heath
-[x] Imaani Macgregor
-[ ] Caiden Leonard