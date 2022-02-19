# Filter one element

In many cases you want to select the first or last element of a collection that satisfies a condition.

While the methods presented before like `Where()`, `Take()` and `Skip()` return a new collection of elements,
there are also LINQ methods that only return a single element:

* `First(predicate)` returns the first element in the collection that matches the predicate.
* `Last(predicate)` returns the last element in the collection that matches the pradicate.
* `Single(predicate)` returns the only element in the collection that matches the predicate. If more than one element matches, the methods throws an exception.

**Note:** As the methods return a single element you won`t be able to call any other LINQ methods after that.
There is nothing to filter, sort, or porject after reducing a collection to a single element.

The following examples call `First()` but `Last()` and `Single()` work the same way.

Here is an example. Return the first adult in the collection.

@[First]({"stubs": ["Exercises/SelectFirstAdultWithLinq.cs"],"command": "TechIo.SelectFirstAdultWithLinqTest.Verify"})

As you can see, the method takes a collection `IEnumerable<Person>` as input but returns a single object of type `Person`.


## What if no element matches the predicate

The LINQ methods `First()`, `Last()`, and `Single()` throw an exception, if no element in the collection matches the predicate.


```c#
var numbers = new [] { 1, 2, 3, 4, 5 };

var firstTwoDigitNumber = numbers.First(x => x >= 10);     // throws an Exception. There is no number >= 10
```

Throwing an exception is sometimes not intended behaviour.
Instead, you want to return a default value if no element matches the predicate.
For these use cases LINQ offers:
  
* `FirstOrDefault(predicate)`
* `LastOrDefault(predicate)`
* `SingleOrDefault(predicate)`

The *default* value is defined by the type of the element:
* `0` for integral types (like `int`, `long`, ...)
* `false` for `bool`
* `null` for objects and `string`


```c#
var numbers = new [] { 1, 2, 3, 4, 5 };

var firstTwoDigitNumber = numbers.FirstOrDefault(x => x >= 10);     // 0 (the default value of type int)
```

## What if I want to select the first or last element of a collection without any condition

You can also use `First()` and `Last()` without a predicate.
Calling the mehtods without a predicate simply returns the first or last element of the collection.

```c#
var numbers = new [] { 1, 2, 3, 4, 5 };

var firstNumber = numbers.First();  // 1
var lastNumber = numbers.Last();    // 5
```
