# Filter single element

In many cases you may want to select the first or last element that satisfies a condition.

While the previous presented methods like `Where()`, `Take()` and `Skip()` return a new collection of elements,
that only return a single element:

* `First(predicate)` returns the first element in the collection that matches the predicate.
* `Last(predicate)` returns the last element in the collection that matches the pradicate.
* `Single(predicate)` returns the single element in the collection that matches the predicate. If more than one element matches, the methods throws an exception.

**Note:** As the methods reurn a single element you won`t be able to call any other LINQ methods after that.
There is nothing to filter, sort, or porject after reducing a collection to a single element.

The following examples call `First()` but `Last()` and `Single()` work the same way.

@[First]({"stubs": ["Exercises/SelectFirstAdultWithLinq.cs"],"command": "TechIo.SelectFirstAdultWithLinqTest.Verify"})

As you can see, the method takes a collection (`IEnumerable<Person>`) as input but returns a single object of type `Person`.


## What if no element matches the predicate

The LINQ methods `First()`, `Last()`, and `Single()` throw an exception, if no element in the collection matches the predicate.


```c#
var numbers = new [] { 1, 2, 3, 4, 5 };

var firstTwoDigitNumber1 = numbers.First(x => x >= 10);     // throws an Exception. There is no number > 10
```

This behavior is sometimes not intended.
For these use cases LINQ offers versions of `First()`, `Last()`, and `Single()` that return a default value if no element matches the predicate:
  
* `FirstOrDefault(predicate, defaultValue)` returns the first element in the collection that matches the predicate, or the default value, if no element matches the predicate.
* `LastOrDefault(predicate, defaultValue)` returns the last element in the collection that matches the pradicate, or the default value, if no element matches the predicate.
* `SingleOrDefault(predicate, defaultValue)` returns the single element in the collection that matches the predicate, or the default value, if no element matches the predicate. If more than one element matches, the methods throws an exception.

```c#
var numbers = new [] { 1, 2, 3, 4, 5 };

var firstTwoDigitNumber = numbers.First(x => x >= 10, -1); // -1
```

You can also omit the default value, if you want to return the default value defined by the type (`0` for integral types, `false` for bool, `null` for objects)

```c#
var numbers = new [] { 1, 2, 3, 4, 5 };

var firstTwoDigitNumber = numbers.First(x => x >= 10);     // 0 (the default value of type int)
```

## What if I want to select the first or last element of a collection

You can also use `First()` and `Last()` without a predicate.
Calling the mehtods without a predicate simply returns the first or last element of the collection.

```c#
IEnumerable<int> numbers = new [] { 1, 2, 3, 4, 5 };
int firstNumber = numbers.First();  // 1
int lastNumber = numbers.Last();    // 5
```
