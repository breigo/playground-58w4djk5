# Filtering data - A first approach

Ok, now that you know what *enumerables* are, we can go on and work with them.

In many scenarios you have to filter a data set.

Basicalliy, 
* the data set is a bunch of objects, where you can iterate over items... the `IEnumerable<T>`,
* a filter is an expression or function that can decide if you keep an item or throw it away and
* you iterate over the items in the data set and apply the filter.

Here is an example:
We get a list of numbers and want to keep only positive values.

A first approch to filter the data would be to create a new empty list and then iterate over
the numbers and add the positive values to the new list.

# Here is the code

@[First appoach on filtering]({"stubs": ["Exercises/FilterWithoutLinq.cs"],"command": "TechIo.FilterWithoutLinqTest.Verify"})

## The code explained

We successfully created a method where we can pour in a any numbers but out only get out a positive numbers.

The method accepts any `IEnumerable<int>` and also returns an `IEnumerable<int>`, so the method works with
Arrays, Lists or other data structures that realize the `IEnumerable<int>` interface.

```c#
var numbers1 = KeepPositiveNumbers(new[] { -5, 4, 10, 0, -9 })
var numbers2 = KeepPositiveNumbers(new List<int> { -5, 4, 10, 0, -9 })
```

For clarity, we also introduced a method called `bool IsGreaterThanZero(int)`.
This is our *filter* mehtod, that decides if we should keep a value or discard it.

Of course, we could have simply written the expression in the `if` statement, but as filters get more complex they won't fit in a single line.
E.g. imagine we don't want to filter for positive numbers but for prime numbers. 
That's not a simple expression any more.


# It works, we are done

Now time passes by and you have another requirement, that you want to keep only negative numbers.

You have to implement a new filter method for that. 😠😠😠

Or is there a more flexible way?
What if we could pass our expression to the filter method before as function pointer or delegate?

Luckily, whe have a delegate type called `System.Func<>`.