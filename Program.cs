// Step 3: Create delegate instances and use them

    // Create delegate instances and associate them with methods
    Calculate calc1 = new Calculate(Add);
    Calculate calc2 = new Calculate(Subtract);

    // Invoke the methods through the delegates
    int result1 = calc1(5, 3);  // Calls Add(5, 3)
    int result2 = calc2(7, 2);  // Calls Subtract(7, 2)

    Console.WriteLine(result1);  // Output: 8
    Console.WriteLine(result2);  // Output: 5

// Step 2: Define methods that match the delegate signature
int Add(int a, int b)
{
    return a + b;
}

int Subtract(int a, int b)
{
    return a - b;
}

// Step 1: Define a delegate
delegate int Calculate(int x, int y);




