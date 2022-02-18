# Projections with Select

With LINQ, you also can transform data from one representation into another.

The `Select(transformationFunction)` method allows you to project each element of a sequence into a new form.
The method takes a transformation function as argument.


Here is a simple example. From a list of numbers, calculate the squeare number of each element.

```c#
var numbers = new [] { 1, 2, 3, 4, 5 };
var squares = numbers.Select(x => x * x);   // 1, 4, 9, 16, 25
```

In the example above, the transformation function `x => x * x` is called for evrey element of `numbers`.
This projects the sequence of integers (`numbers`) to a new sequence of integers (`squares`).

But with `Select` you can also transform the type of a sequence.

Here is another example. From a list of person objects, select only the names.

@[Where and Take]({"stubs": ["Exercises/SelectNamesWithLinq.cs"],"command": "TechIo.SelectNamesWithLinqTest.Verify"})

The example above projects the `IEnumerable<Person>` to an `IEnumerable<string>`.