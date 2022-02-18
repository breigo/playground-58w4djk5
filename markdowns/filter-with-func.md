# Filtering data - A more flexible approach

We want to pass our predicate expression `number > 0` to a filter method.
This way we can decide for which numbers we want to filter.

First, we create a dedicated predicate function that encapsulates the expression:

```c#
public bool IsGreaterThanZero(int number)
{
    return number > 0;
}
```

Second, we assign that function to a variable.
The delegate type `System.Func<>` allows us to assign a function to a variable or pass it as an argument to a method.
We can then "call" the variable as it would be a method.

```c#
Func<int, bool> greaterZero = IsGreaterThanZero;

Console.WriteLine(greaterZero(10)) // true
Console.WriteLine(greaterZero(-4)) // false
```
The first template parameter for `Func<int, bool>` is the input type (`int`) and the second template parameter is the return type (`bool`) of the method.

`Func<>` is a generic type which requires 2 or more template parameters, depending on the number of arguments your method has.
For example, a method `bool Multiply(int a, int b)` which takes two integer arguments as input and returns a boolean value could be assigned to a variable of type `Func<int, int, bool>`.
The last template parameter is always the method's return type and the template parameters before define the method's input types (one per argument).

# How does this help?

We can also pass `greaterZero` as argument to a filter method.

@[Filtering with Func<>]({"stubs": ["Exercises/FilterWithFuncA.cs"],"command": "TechIo.FilterWithFuncATest.Verify"})

## The code explained

We pulled out all the filter logic from the example on the previous page into a method called `FilterNumbers`.
This method takes the unfiltered numbers as first argument and a predicate delegate function as second argument.

The difference to the previous version is, that we don't have a fixed expression in the if statement any more.
Instead, we call the `filterPredicate` argument, which was passed from outside.
We 'delegate' the decission to the caller.

Our `KeepPositiveNumbers` method from the previous example now can call `FilterNumbers` and pass in `IsGreaterThanZero` as the filter predicate.


# Add additional requirements

Adding a filter method for keeping only negative integeres is now very easy.
We can reuse the existing `FilterNumbers` method but pass an alternative filter predicate.

@[Filtering with Func<>]({"stubs": ["Exercises/FilterWithFuncB.cs"],"command": "TechIo.FilterWithFuncBTest.Verify"})

We've added a new predicate function `IsSmallerThanZero` and a new filter method `KeepNegativeNumbers`.
In contrast to `KeepPositiveNumbers` we directly pass `IsSmallerThanZero` as delegate function without assigning it to a variable before.


# This is it?

Passing delegate functions as arguments is an elegant way to reduce implementation effort.
Iterating over the input is always the same and the responsibility for deciding which items are kept is delegated to the caller of the method.

However, the way we pass the delegate function introduces more complexity on the caller's side.
A separate method has to be defined and passed to `FilterNumbers` for evrey predicate.

But is there an easier way to tell `FilterNumbers` that we want to keep all numbers `x > 0` or `x < 0`?

You guess it, yes there is.
And the answer is *lambda expressions*.
