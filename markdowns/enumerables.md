# Enumerables

We start with **Enumerables**.
An enumerable in .Net is an object that allows you to enumerate a collection of elements.

## Arrays

The most basic enumerable is an array, which can store a fixed number of typed elements.

```c#
int[] numbers = new int[3] { 1, 2, 3};
```

In the example above, we create an integer array that can hold 3 values and initialize the values with 1, 2 and 3.
We assign that array to a variable of type `int[]` named `numbers`.

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

Another common type of enumerables are lists. In contrast to arrays, lists have a variable size.

```c#
var numbers = new List<int>() { 1, 2, 3 };
```

In the example above, we create a list of integers and initialize it with three values 1, 2 and 3.
We assign it to a variable called `numbers`.
This example we use the keyword `var` for the datatype of `numbers`. With `var`, we let the compiler decide which type to use.
As we assign an object of type `List<int>` the type of the variable will be `List<int>`.

Again, you can access the values by index, or enumerate them.

```c#
// Access element by index
var fistNumber = numbers[0]; // 1
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

A third type of enumerables sets.
Sets contain unique elements.
The `HashSet` class for example, provides high-performance set operations (e.g. `UnionWith`, `IntersectWith`...).

```c#
var numbers = new HashSet<int>() {1, 2, 3};
```

In contrast to the previous two examples of arrays and lists, you cannot access an element of a set by it's index. 
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

There are many other types of enumerables in .Net, e.g. dictionaries, queues, stacks as well as other spezilized lists and sets.


# The common ground

Although all enumerable types have different purposes and methods they have on common characteristic.

**They all realize the same interface `IEnumerable<T>`.**

As enumerables are so fundamental in .Net, there is a declarative language construct in C# that makes working with enumerables easy.

We have seen it before: **The `foreach` loop.**

```c#
// Enumerate values
foreach(var element in objectOfTypeIEnumerable)
{
    // work with the element
}
```


## One additional note: Generics types
The interface `IEnumerable<T>` is a generic interface.
This means means that the enumerable is strongly typed, but you can define the concrete type in your code. 
*Strongly typed* means, that it can hold only elements of the specified type (or elements that can be implicitly converted to this type).
`T` is the template type, a placehoder for the type you specify.

The type `List<T>` is also a generic type.
A `List<int>` (list of integers) for example is an `IEnumerable<int>` (enumerable of integers).
You can add `int` values to the list.
You can also add `byte` values to the list (as they can be converted to `int` automatically, i.e. implicitly, without loss).
However, you can not add `string` or `long` values to the list. The former cannot be converted to an integer at all, the latter could be converted to an integer, but with a possible data loss and this is never done automatically.
