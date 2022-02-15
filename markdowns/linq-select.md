# Projections with Select

In many cases you want to transform data from one representation into another.

With the `Select()` function you can project each element of a sequence into a new form.
The function takes transformation function as argument.


Here is a simple example. From a list of numbers, calculate the squeare number of each element.

```c#
var numbers = new [] { 1, 2, 3, 4, 5 };
var squares = numbers.Select(x => x * X);   // 1, 4, 9, 16, 25
```

In the example above, the transformation function `x => x * X` is called for evrey element of `numbers`.
This projects the sequence of integers (`numbers`) to a new sequence of integers (`squares`).

But with `Select` you can also create sequences with a different type.

Here is another example. From a list of person objects, select only the names.

```c#
var people = new List<Person>() {
                    new Person() { Name = "Samina Stephenson", Age = 9 },
                    new Person() { Name = "Jaydon Heath", Age = 82 },
                    new Person() { Name = "Imaani Macgregor", Age = 66 },
                    new Person() { Name = "Caiden Leonard", Age = 52 }
                };

var names = people.Select(p => p.Name);

// names is an IEnumerable<string> with the values:
//  "Samina Stephenson",
//  "Jaydon Heath",
//  "Imaani Macgregor",
//  "Caiden Leonard"
```

The example above projects the `IEnumerable<Person>` into an `IEnumerable<string>`.