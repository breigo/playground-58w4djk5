# Filtering data - A first approach

Ok, now that you know what *enumerables* are, we can go an work with them.

In many scenarios you have to filter a data set.

Basicalliy, 
    * the data set is a bunch of objects, where you can iterate over items... the `IEnumerable<T>`
    * a filter is an expression or function that can decide if you keep an item or throw it away.

We start with a small example:
We get a list of numbers want to keep only positive values.

A first approch to filter the data would be to create a new empty list and then iterate over
the numbers and add the positive values to the new list.

@[First appoach on filtering]({"stubs": ["Exercises/FilterWithoutLinq.cs"],"command": "TechIo.UniverseTest.VerifyCountAllStars"})