# Filtering data witn LINQ methods

> The **L**anguage-**In**tegrated **Q**uery (LINQ) is the name for a set of technologies based on the integration of query capabilities directly into the C# language. [...]
>
> For a developer who writes queries, the most visible "language-integrated" part of LINQ is the query expression. Query expressions are written in a declarative query syntax. By using query syntax, you can perform filtering, ordering, and grouping operations on data sources with a minimum of code. You use the same basic query expression patterns to query and transform data in SQL databases, XML documents and streams, and .NET collections.

([from Microsoft docs](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/))


## Scope of LINQ in this tutorial

In this tutorial we focus on **LINQ method syntax** another form of writing your queries (in conctrast to the integrates *query syntax*).
With LINQ method syntax you use method calls instead of declarative queries to operate on your data.
Once you understand the methods you can go on and learn about query syntax (but not in this tutorial), as the queries are translated to LINQ methods during compile time.

We will just look at LINQ methods in the context of collections (`IEnumerable<T>`) and no other data sources like databases or XML documents.


# How can LINQ improve our example from before

So how can we apply LINQ to our example of filtering positive and negative numbers?

Let's jump right down to the code level. 
As you allready know about lambda expressions and how to pass them as argument to a method, writing LINQ method syntax queries is quite self explaining.

@[Filtering with lambda expressions]({"stubs": ["Exercises/FilterWithLinq.cs"],"command": "TechIo.FilterWithLinqTest.Verify"})

## The code explained

Yes, this is it! What should I say?

`KeepPositiveNumbers` returns all numbers `x`, where `x` is larger than 0.
`KeepNegativeNumbers` returns all numbers `x`, where `x` is smaller than 0.