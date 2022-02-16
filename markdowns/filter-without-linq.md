# Filtering data - A first approach

Ok, now that you know what *enumerables* are, we can go on and work with them.

In many scenarios you have to filter a data set.

* The data set is a collection of objects (the `IEnumerable<T>`),
* a decision predicate is an expression or function that can decide if you keep an item.
* You enumerate over the items in the collection and check the predicate.
* If the predicate matches, you keep the item. If not, you trhow it away.

Here is an example:
From a list of numbers keep only positive values.

A first approch to filter the data would be to create a new empty list and then enumerate over
the numbers and add the positive values to the new list.

# Here is the code

@[First appoach on filtering]({"stubs": ["Exercises/FilterWithoutLinq.cs"],"command": "TechIo.FilterWithoutLinqTest.Verify"})

## The code explained

We successfully created a method where we can pass a list of numbers but out only get out a positive numbers.

The method accepts any `IEnumerable<int>` and also returns an `IEnumerable<int>`, so the method works with
Arrays, Lists or other data structures that realize the `IEnumerable<int>` interface.

```c#
var numbers1 = KeepPositiveNumbers(new[] { -5, 4, 10, 0, -9 })
var numbers2 = KeepPositiveNumbers(new List<int> { -5, 4, 10, 0, -9 })
```


# It works, we are done

Now time passes by and you have another requirement, that you want to keep only negative numbers.

You have to implement a new filter method for that. 😠😠😠

Or is there a more flexible way?
What if we could pass our expression to the filter method in some way?