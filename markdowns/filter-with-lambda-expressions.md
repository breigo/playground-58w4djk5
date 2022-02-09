# Filtering data - A more flexible approach

Now time passes by and you have another requirement, that you want to keep only negative numbers.

We have to implement a new filter method for that. :angry:

Or is there a more flexible way?

What if we could pass our expression to the filter method before as function pointer or delegate?

# Here comes the Func

Luckily, whe have a delegate type called `System.Func<>`.
With this type we can assign a function to a variable or a method parameter.

`Func<>` is a generic type (like `IEnumerable<T>`) but with at least 2 template parameters.

For example, we can assign the `IsGreaterThanZero` method to a variable of type `Func<int, bool>`, where
the first tpye is the input type (`int`) and the second type is the return type (`bool`).
```c#
Func<int, bool> greaterZero = IsGreaterThanZero;
```
You can also have more than one input types.
For example, `Func<int, int, bool>` takes two ints as input and returns a boolean.
The last type is always the method's return type and the types before define the method's input types (one per argument).

# Here is the code

@[First appoach on filtering]({"stubs": ["Exercises/FilterWithFunc.cs"],"command": "TechIo.FilterWithFuncTest.Verify"})



# Here comes the lambda expression

Lambda expressions are anonymous functions you can define inline in your code as a variable.

```c#
Func<int, bool> isGreaterThanZero = number => number > 0;

Console.WriteLine(isGreaterThanZero(10)) // true
Console.WriteLine(isGreaterThanZero(-4)) // false
```

Here, `number => number > 0` is the lambda expression.
* The `=>` operator is the lambda operator.
* To the left of the lambda operator are the input parameters (`number`).
* To the right of the lambda operator is hte expression that is executed when calling the function (`number > 0`).

The type of 