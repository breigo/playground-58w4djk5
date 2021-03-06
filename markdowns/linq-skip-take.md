# Take or skip some elements in the collection

The next two methods we discuss are
* `Take(numberOfElements)` and
* `Skip(numberOfElements)`

`Take` returns the first `n` elements:

```c#
var numbers = new [] { 1, 2, 3, 4, 5, 6 };
var result = numbers.Take(3); // 1, 2, 3
```

`Skip` discards the first `n` elements:

```c#
var numbers = new [] { 1, 2, 3, 4, 5, 6 };
var result = numbers.Skip(3); // 4, 5, 6
```

You can also combine the methods:

```c#
var numbers = new [] { 1, 2, 3, 4, 5, 6 };
var result = numbers.Skip(1).Take(3);   // 2, 3, 4
```

# This is NEW - Method Chaining!

Here we have to stop and deliberately walk through the last example again.

We just discovered a very powerful feature of LINQ: method chaining!

As the LINQ methods covered so far have the same type `IEnumerable<T>` as input and output, we can call a LINQ method on the result of another LINQ method.

Here is what happens:
* The first call to `Skip` skips the first element and returns the succeeding elements.
* The second call to `Take` retunrs the first three elements of the result of `Skip`.

```c#
var numbers = new [] { 1, 2, 3, 4, 5, 6 };
var result = numbers    // 1, 2, 3, 4, 5, 6
    .Skip(1)            //    2, 3, 4, 5, 6
    .Take(3);           //    2, 3, 4
```

You can aply method chaining to any LINQ method.
They are designed to work that way.


## Method chaining example

Return the first two adults of a collection.

@[Where and Take]({"stubs": ["Exercises/FilterPeopleWithWhereAndTake.cs"],"command": "TechIo.FilterPeopleWithWhereAndTakeTest.Verify"})
