# Sort with OrderBy

A common use case is sorting.

For that LINQ offers
* `OrderBy(keySelector)` and
* `OrderByDescending(keySelector)`

```c#
var numbers = new [] { 1, 4, 3, 6, 5, 2 };

var ascending = numbers.OrderBy(x => x); // 1, 2, 3, 4, 5, 6
var descending = numbers.OrderByDescending(x => x); // 6, 5, 4, 3, 2, 1
```

We sort the list of numbers by it's integer values.
The number we get as input is the number we return (`x => x`).
This construct is also called *identity function*.

Having the option to select a key is very helpful, when we want to order objects.
This way, we can easily order our people by age:

```c#
var people = new List<Person> {
    new Person { Name = "...", Age = 5 },
    new Person { Name = "...", Age = 8 },
    new Person { Name = "...", Age = 3 },
}

var sortedPeople = people.OrderBy(p => p.Age);
```

We can also sort the objects by multiple keys, e.g. first by `Name` and then by `Age`.
After calling `OrderBy` we get new LINQ methods to chain:

* `ThenBy(keySelector)` and
* `ThenByDescending(keySelector)`

@[OrderBy]({"stubs": ["Exercises/SortPeopleWithLinq.cs"],"command": "TechIo.SortPeopleWithLinqTest.Verify"})

Note: Calling `OrderBy` twice would not lead to the expected result, because the second call to `OrderBy` would sort the collection again. Instead, calling `OrderBy` followed by `ThenBy` leads to the expected result, because `ThenBy` performs a subsequent ordering.