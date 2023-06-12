# Csharp1_Delegate

In C#, delegates are a type that allows you to define and work with references to methods. They provide a way to encapsulate and pass around methods as first-class objects. Delegates are often used in event handling scenarios, where they allow you to subscribe to and invoke multiple methods when a certain event occurs.

Here's an example that demonstrates how to define and use delegates in C#:

```csharp
// Step 1: Define a delegate
delegate int Calculate(int x, int y);

// Step 2: Define methods that match the delegate signature
int Add(int a, int b)
{
    return a + b;
}

int Subtract(int a, int b)
{
    return a - b;
}

// Step 3: Create delegate instances and use them
static void Main()
{
    // Create delegate instances and associate them with methods
    Calculate calc1 = new Calculate(Add);
    Calculate calc2 = new Calculate(Subtract);

    // Invoke the methods through the delegates
    int result1 = calc1(5, 3);  // Calls Add(5, 3)
    int result2 = calc2(7, 2);  // Calls Subtract(7, 2)

    Console.WriteLine(result1);  // Output: 8
    Console.WriteLine(result2);  // Output: 5
}

```

In the code above, we define a delegate named Calculate that represents a method with two integer parameters and an integer return value. We then create two instances of the delegate addition and subtraction using anonymous methods to define the logic for performing addition and subtraction operations.

The anonymous methods are defined using the delegate keyword, followed by the parameter list in parentheses, and then the method body enclosed in curly braces. The parameters and return type of the anonymous method must match the delegate's signature.

In the Main method, we invoke the addition and subtraction delegates by passing the required arguments. The results are printed to the console.

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 2, 8, 3, 1, 9 };

        // Sort the list using different comparison strategies
        Sort(numbers, AscendingComparison);
        Console.WriteLine("Ascending order:");
        PrintList(numbers);

        Sort(numbers, DescendingComparison);
        Console.WriteLine("Descending order:");
        PrintList(numbers);
    }

    static void Sort(List<int> list, Comparison<int> comparison)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                if (comparison(list[i], list[j]) > 0)
                {
                    int temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }
        }
    }

    static int AscendingComparison(int a, int b)
    {
        return a.CompareTo(b);
    }

    static int DescendingComparison(int a, int b)
    {
        return b.CompareTo(a);
    }

    static void PrintList(List<int> list)
    {
        foreach (int number in list)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}

```

In this example, we have a list of numbers that we want to sort in ascending and descending order. Instead of implementing separate sorting algorithms, we use a Sort method that takes a delegate of type Comparison<int>. The Comparison<T> delegate type is a built-in delegate that represents a method that compares two objects of type T and returns an int indicating their relative order.

We define two comparison methods, AscendingComparison and DescendingComparison, that match the Comparison<int> delegate signature. These methods use the CompareTo method of the int type to perform the comparison.

The Sort method takes the list to be sorted and the comparison delegate as parameters. It uses a simple bubble sort algorithm to sort the list based on the comparison provided.

In the Main method, we create a list of numbers and call the Sort method twice with different comparison strategies. We pass the AscendingComparison delegate to sort the list in ascending order and the DescendingComparison delegate to sort the list in descending order. After sorting, we print the sorted lists using the PrintList method.

This example demonstrates how delegates can be used to decouple the sorting algorithm from the comparison logic, allowing for greater flexibility and code reusability.
