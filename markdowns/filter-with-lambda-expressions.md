# Filtering data with lambda expressions

Lambda expressions are anonymous functions you can define inline.

```c#
Func<int, bool> isGreaterThanZero = x => x > 0;

Console.WriteLine(isGreaterThanZero(10)) // true
Console.WriteLine(isGreaterThanZero(-4)) // false
```

Here, `x => x > 0` is the lambda expression.
* The `=>` operator is the lambda operator.
* To the left of the lambda operator are the input parameters (`x`).
* To the right of the lambda operator is hte expression that is executed when calling the function (`x > 0`).

The types of input argument and return value are not explicitly stated in the lambda expression.
They are infered by the context.
In the example above we assign the lambda expression `x => x > 0` to a variable of type `Func<int, bool>`, which means a function with an `integer` as input (`x`) and a `bool` as output (`x > 0`).

# Lambda expressions applied

@[Filtering with lambda expressions]({"stubs": ["Exercises/FilterWithLambda.cs"],"command": "TechIo.FilterWithLambdaTest.Verify"})

## The code explained