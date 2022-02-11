# Enumerables in .Net

We start with **Enumerables**.
An enumerable in .Net is an object that allows you to enumerate a collection elements.

## Arrays

The most basic enumerable is an array, which can store a fixed number of typed elements.

```c#
var numbers = new int[3] { 1, 2, 3};
```

You can access each element of an array by index or enumerate the values.

```c#
// Access element by index
int fistNumber = numbers[0]; // 1
```

```c#
// Enumerate values
foreach(int number in numbers)
{
    Console.WriteLine(number)
}

/* Output:
 * 1
 * 2
 * 3
 */
```

## Lists

Another common type of enumerables are lists. In contrast to arrays, lists can store a variable number of elements.

```c#
var numbers = new List<int> { 1, 2, 3 };
```

Again, you can access the values by index, or enumerate them.

```c#
// Access element by index
int fistNumber = numbers[0]; // 1
```

```c#
// Enumerate values
foreach(int number in numbers)
{
    Console.WriteLine(number)
}

/* Output:
 * 1
 * 2
 * 3
 */
```

## Sets

A third type of enumerables would be sets.
Sets contain unique elements.
A `HashSet` for example provides high-performance set operations (e.g. `UnionWith`, `IntersectWith`...).

```c#
var numbers = new HashSet<int>() {1, 2, 3};
```

In contrast to the previous two examples of arrays and lists, you cannot access an element of a set by an index. 
There is no such concept of "index of an element" in a set.

However, you can still enumerate the values stored in the set.

```c#
// Enumerate values
foreach(int number in numbers)
{
    Console.WriteLine(number)
}

/* Output could be (but depends on the implementation of the set's enumerator):
 * 1
 * 2
 * 3
 */
```

## And many more

There are many other types of enumerables in .Net containing dictionaries, queues, stacks as well as other spezilized lists and sets.


# The common ground

Although all enumerable types have different purposes and methods they have on common characteristic.

**They all realize the same interface `IEnumerable<T>`.**

As enumerables are so fundamental in .Net, there is a declarative language construct in C# (and other .Net languages) that makes working with enumerables easy.

We have seen it before: **The `foreach` loop.**

::: How it works (advanced, open if you want to take a look under the hood)

The `IEnumerable<T>` gives you access to an *enumerator*.
The enumerator can return the *next* element. What *next* means depends on the implementation of the enumerable.

A `foreach` loop operates on an `IEnumerable<T>` object.
It accesses the *enumerator's* *next* element in each iteration and assigns it to the specified variable, until the enumerator has no *next* element any more.

In your code you write:
```c#
foreach(var number in numbers)
{
    // Your code here
}
```

The compiler converts it to something like this:
```c#
try
{
    int number;
    IEnumerator<int> numbersEnumerator = numbers.GetEnumerator();
    while(numbersEnumerator.MoveNext()) {
        number = numbersEnumerator.Current;
        // Your code here
    }
}
finally
{
    numbersEnumerator.Dispose()
}
```
:::

## One additional note: Generics types
The type `IEnumerable<T>` is a generic type.
This means means that the enumerable is strongly typed, but you can define the type in your code. 
*Strongly typed* means, that it can hold only elements of the specified type (or elements that can be implicitly converted to this type).
`T` is the template type, a placehoder for the type you specify.

A `List<int>` (list of integers) for example is an `IEnumerable<int>` (enumerable of integers).
You can add `int` values to the list.
You can also add `byte` values to the list (as they can be converted to `int` automatically, i.e. implicitly, without loss).
However, you can not add `string` or `long` values to the list. The former cannot be converted to an integer at all, the latter could be converted to an integer, but with a possible data loss and this is never done automatically.
