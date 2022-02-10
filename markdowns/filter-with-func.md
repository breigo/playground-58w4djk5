# Filtering data - A more flexible approach

The type `System.Func<>` allows us to assign a function to a variable or an argument of a method.

`Func<>` is a generic type (like `IEnumerable<T>`) with at least 2 template parameters.

For example, we can assign the `IsGreaterThanZero` method to a variable of type `Func<int, bool>`, where
the first tpye is the input type (`int`) and the second type is the return type (`bool`).
We can then "call" the variable with an argument.

```c#
Func<int, bool> greaterZero = IsGreaterThanZero;

Console.WriteLine(greaterZero(10)) // true
Console.WriteLine(greaterZero(-4)) // false
```


You can also have more than one input types.
For example, `Func<int, int, bool>` takes two ints as input and returns a boolean.
The last type is always the method's return type and the types before define the method's input types (one per argument).

# Here is the code

@[Filtering with Func<>]({"stubs": ["Exercises/FilterWithFunc.cs"],"command": "TechIo.FilterWithFuncTest.Verify"})

## The code explained

We pulled out all the logic into a method called `FilterNumbers`.
This method takes the source items as first argument and an predicate function delegate as second argument.

The difference to the previous version is, that we don't call `IsGreaterThanZero` in the if statement.
Instead, we call the `filterPredicate` argument as a function.

Our `KeepPositiveNumbers` method from the previous example now can call `FilterNumbers` and pass in `IsGreaterThanZero` as the filter predicate.

We've also implemented `KeepNegativeNumbers` and a filter method `IsSMallerThanZero`.
The only difference is, that we directly pass `IsSmallerThanZero` as delegate function without assigning it to a variable.

# This is it?

Passing delegate methods as arguments is an elegant way to reduce implementation effort required by the one who implemented the filter method.
Iterating over the input is always the same and responsibility for deciding which items are kept is delegated to the caller.

However, the way we pass the delegate function introduces more complexity on the caller's side.
A separate method has to be defined and passed to `FilterNumbers`.

But is there an easier way to tell `FilterNumbers` that we want to keep all number `x > 0` or `x < 0`?

You guess it, yes there is.
And the answer is lambda expressions.