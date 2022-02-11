# Filtering data witn LINQ methods

How can we apply LINQ to our example of filtering positive and negative numbers?

Let's jump right down to the code level. 
As you allready know about lambda expressions and how to pass them as an argument to a method, writing LINQ method syntax queries is quite self explaining.

@[Filtering with LINQ]({"stubs": ["Exercises/FilterWithLinq.cs"],"command": "TechIo.FilterWithLinqTest.Verify"})

## The code explained

Yes, this is it! What should I say?

`KeepPositiveNumbers` returns all numbers `x`, where `x` is larger than 0.
`KeepNegativeNumbers` returns all numbers `x`, where `x` is smaller than 0.


# LINQ to Objects

Applying LINQ methods to `IEnumerable<T>` is also called *LINQ to Objects*.

For the next chapters let us use real objects instead of primitive data types such as `int`.
We habe a `Person` wiht a `Name` and `Age` (years from date of birth until now).

```c#
public class Person {
    public string Name { get; set; }
    public int Age { get; set; }
}
```

## Apply LINQ to people

@[Filtering with LINQ]({"stubs": ["Exercises/FilterPeopleWithLinq.cs"],"command": "TechIo.FilterPeopleWithLinqTest.Verify"})

# This is LINQ!

We have now applied LINQ to filter our data by passing a predicate to the `Where` method.

But there is more then `Where`. As in .Net 6 there are 63 other LINQ methods you can apply to collections to filter, order, group or transform your data.

We will cover the most common ones in the next fiew sections.
