# Filtering data - A more flexible approach

The type `System.Func<>` allows us to assign a function to a variable or an argument of a method.

`Func<>` is a generic type (like `IEnumerable<T>`) with at least 2 template parameters.

For example, we can create a predicate method  `bool IsGreaterThanZero(int)` and assign it to a variable of type `Func<int, bool>`.
The first template parameter for `Func<int, bool>` is the input type (`int`) and the second type is the return type (`bool`) of the method.
We can then "call" the variable as it would be a method.

```c#
public bool IsGreaterThanZero(int number)
{
    return number > 0;
}
```

```c#
Func<int, bool> greaterZero = IsGreaterThanZero;

Console.WriteLine(greaterZero(10)) // true
Console.WriteLine(greaterZero(-4)) // false
```

We can also pass `greaterZero` as argument to filter method.

@[Filtering with Func<>]({"stubs": ["Exercises/FilterWithFuncA.cs"],"command": "TechIo.FilterWithFuncATest.Verify"})

## The code explained

We pulled out all the filter logic into a method called `FilterNumbers`.
This method takes the source items as first argument and an predicate function delegate as second argument.

The difference to the previous version is, that we don't have a fixed expression in the if statement.
Instead, we call the `filterPredicate` argument, which was passed from outside as a function.
We 'delegate' the decission to the caller.

Our `KeepPositiveNumbers` method from the previous example now can call `FilterNumbers` and pass in `IsGreaterThanZero` as the filter predicate.


# Add additional requirements

Adding a filter method for keeping only negative integeres is now very easy.
All we need is a filter mehtod and a predicate function. The filter method calls `FilterNumbers` with the predicate function.

@[Filtering with Func<>]({"stubs": ["Exercises/FilterWithFuncB.cs"],"command": "TechIo.FilterWithFuncBTest.Verify"})

We implemented the predicate function `IsSmallerThanZero` and a new filter method `KeepNegativeNumbers`.
In contrast to `KeepPositiveNumbers` we directly pass `IsSmallerThanZero` as delegate function without assigning it to a variable.


# This is it?

Passing delegate methods as arguments is an elegant way to reduce implementation effort required by the one who implemented the filter method.
Iterating over the input is always the same and responsibility for deciding which items are kept is delegated to the caller.

However, the way we pass the delegate function introduces more complexity on the caller's side.
A separate method has to be defined and passed to `FilterNumbers`.

But is there an easier way to tell `FilterNumbers` that we want to keep all number `x > 0` or `x < 0`?

You guess it, yes there is.
And the answer is lambda expressions.





You can also have more than one input types.
For example, `Func<int, int, bool>` takes two ints as input and returns a boolean.
The last type is always the method's return type and the types before define the method's input types (one per argument).