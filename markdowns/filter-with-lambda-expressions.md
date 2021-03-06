# Filtering data with lambda expressions

Lambda expressions are anonymous functions you can define inline.

```c#
Func<int, bool> isGreaterThanZero = x => x > 0;

Console.WriteLine(isGreaterThanZero(10)) // true
Console.WriteLine(isGreaterThanZero(-4)) // false
```

Here, `x => x > 0` is the lambda expression.
* The `=>` operator is the lambda operator.
* To the left of the lambda operator you see the input parameters (`x`).
* To the right of the lambda operator you see the expression that is executed when calling the function (`x > 0`).

The types of input argument and return value are not explicitly stated in the lambda expression.
They are inferred by the context.
In the example above we assign the lambda expression `x => x > 0` to a variable of type `Func<int, bool>`, which means a function with an `int` as input (`x`) and a `bool` as output (`x > 0`).

# Lambda expressions applied

@[Filtering with lambda expressions]({"stubs": ["Exercises/FilterWithLambda.cs"],"command": "TechIo.FilterWithLambdaTest.Verify"})

## The code explained

`FilterNumbers` is unchanged.

We removed the two explicitly defined filter methods `IsGreaterThanZero` and `IsSmallerThanZero` and put their content directly as lambda expressions into `KeepPositiveNumbers` and `KeepNegativeNumbers`.

In `KeepPositiveNumbers` we assign the lambda expression to a variable.
In `KeepNegativeNumbers` we directly pass the lambda expression as argument to `FilterNumbers`.


# It can't hardly get simpler

`KeepPositiveNumbers` and `KeepNegativeNumbers` are now really tight - that's fine.

The only method with some complexity left is `FilterNumbers`.
Here, we have to enumerate the original `numbers` and add them to `filteredNumbers` if our `filterPredicate` evaluates to true.

But isn`t the concept of filtering a collection of elements always the same,
no matter if we have a collection of numbers, or timestamps, or any other type of objects?

It is!
And finally we are at the heart of this tutorial: LINQ