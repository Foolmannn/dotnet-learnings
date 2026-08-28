# Arrays in C# — Detailed Guide

An **array** in C# is a collection of elements of the **same data type**, stored in a fixed-size structure.

For example, instead of creating five separate variables:

```csharp
int mark1 = 80;
int mark2 = 75;
int mark3 = 90;
int mark4 = 65;
int mark5 = 88;
```

we can use an array:

```csharp
int[] marks = { 80, 75, 90, 65, 88 };
```

Now all five values are stored in one variable.

---

# 1. What is an Array?

An array has three important characteristics:

### 1. Same data type

All elements must have the same type.

```csharp
int[] numbers = { 10, 20, 30, 40 };
```

You cannot do:

```csharp
int[] numbers = { 10, 20, "Hello" }; // ❌
```

---

### 2. Fixed size

Once an array is created, its size cannot be changed.

```csharp
int[] numbers = new int[5];
```

This array can contain exactly **5 elements**.

You cannot directly make it 10 elements:

```csharp
numbers.Length = 10; // ❌
```

If you need a dynamically growing collection, you'll generally use `List<T>` instead.

---

### 3. Zero-based indexing

The first element has index `0`.

```text
Value:    10    20    30    40    50
Index:     0     1     2     3     4
```

So:

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };

Console.WriteLine(numbers[0]); // 10
Console.WriteLine(numbers[2]); // 30
Console.WriteLine(numbers[4]); // 50
```

---

# 2. Declaring an Array

The basic syntax is:

```csharp
dataType[] arrayName;
```

For example:

```csharp
int[] numbers;
string[] names;
double[] prices;
bool[] results;
```

At this point, the arrays have only been **declared**.

They don't contain an actual array object yet.

---

# 3. Creating an Array

You can create an array using `new`.

```csharp
int[] numbers = new int[5];
```

This creates an array capable of storing 5 integers.

Initially, the elements get their default values:

```text
0  0  0  0  0
```

Example:

```csharp
int[] numbers = new int[5];

Console.WriteLine(numbers[0]); // 0
Console.WriteLine(numbers[1]); // 0
```

---

# 4. Initializing an Array

You can initialize an array directly with values.

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };
```

You can also write:

```csharp
int[] numbers = new int[] { 10, 20, 30, 40, 50 };
```

Both are valid.

Modern C# also supports:

```csharp
int[] numbers = [10, 20, 30, 40, 50];
```

---

# 5. Accessing Array Elements

Use the index.

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };

Console.WriteLine(numbers[0]);
```

Output:

```text
10
```

Change an element:

```csharp
numbers[0] = 100;

Console.WriteLine(numbers[0]);
```

Output:

```text
100
```

For example:

```csharp
int[] marks = { 80, 70, 90, 60 };

marks[1] = 85;

Console.WriteLine(marks[1]);
```

Output:

```text
85
```

---

# 6. Array Index Out of Range

Since an array is zero-indexed, an array of size 5 has indices:

```text
0 1 2 3 4
```

This is invalid:

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };

Console.WriteLine(numbers[5]); // ❌
```

You'll get:

```text
System.IndexOutOfRangeException
```

The last valid index is:

```csharp
numbers.Length - 1
```

---

# 7. `Length` Property

Every array has a `Length` property.

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };

Console.WriteLine(numbers.Length);
```

Output:

```text
5
```

You can use it with loops:

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
```

Output:

```text
10
20
30
40
50
```

This is preferable to hardcoding:

```csharp
for (int i = 0; i < 5; i++)
```

because the array size could change.

---

# 8. Looping Through Arrays

Arrays and loops are commonly used together.

## Using `for`

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
```

Here:

```csharp
i = 0
```

accesses:

```csharp
numbers[0]
```

Then:

```csharp
i = 1
```

accesses:

```csharp
numbers[1]
```

and so on.

---

## Using `foreach`

You can make this simpler:

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };

foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```

The `foreach` loop automatically goes through each element.

### `for` vs `foreach`

Use `for` when you need the index:

```csharp
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Index: {i}, Value: {numbers[i]}");
}
```

Use `foreach` when you only need the values:

```csharp
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```

---

# 9. Taking Array Input from the User

Suppose you want to take 5 numbers from the user.

```csharp
int[] numbers = new int[5];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Enter number {i + 1}: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
```

Then display them:

```csharp
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```

A complete example:

```csharp
int[] numbers = new int[5];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Enter number {i + 1}: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Numbers are:");

foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```

---

# 10. Different Types of Arrays

C# supports several forms of arrays.

The important ones are:

1. One-dimensional arrays
2. Multidimensional arrays
3. Jagged arrays

---

# 11. One-Dimensional Array

This is the normal array you've seen so far.

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };
```

Visually:

```text
+----+----+----+----+----+
| 10 | 20 | 30 | 40 | 50 |
+----+----+----+----+----+
  0    1    2    3    4
```

---

# 12. Multidimensional Arrays

A multidimensional array has multiple dimensions.

A common example is a 2D array, similar to a matrix.

```csharp
int[,] matrix =
{
    { 1, 2, 3 },
    { 4, 5, 6 }
};
```

It looks like:

```text
       Column
        0  1  2
      +---------
Row 0 | 1  2  3
Row 1 | 4  5  6
```

Access elements using two indices:

```csharp
Console.WriteLine(matrix[0, 0]); // 1
Console.WriteLine(matrix[0, 2]); // 3
Console.WriteLine(matrix[1, 1]); // 5
```

The syntax is:

```csharp
array[row, column]
```

---

# 13. Creating a 2D Array with `new`

```csharp
int[,] matrix = new int[2, 3];
```

This means:

```text
2 rows
3 columns
```

Initially:

```text
0 0 0
0 0 0
```

You can assign values:

```csharp
matrix[0, 0] = 10;
matrix[0, 1] = 20;
matrix[0, 2] = 30;

matrix[1, 0] = 40;
matrix[1, 1] = 50;
matrix[1, 2] = 60;
```

---

# 14. Looping Through a 2D Array

You normally use nested loops.

```csharp
int[,] matrix =
{
    { 1, 2, 3 },
    { 4, 5, 6 }
};

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }

    Console.WriteLine();
}
```

Output:

```text
1 2 3
4 5 6
```

But instead of hardcoding dimensions, use:

```csharp
matrix.GetLength(0)
```

for the number of rows and:

```csharp
matrix.GetLength(1)
```

for the number of columns.

Therefore:

```csharp
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }

    Console.WriteLine();
}
```

---

# 15. Multidimensional Arrays with More Dimensions

C# can have more than two dimensions.

For example:

```csharp
int[,,] data = new int[2, 3, 4];
```

This is a **3-dimensional array**.

Access it with:

```csharp
data[0, 1, 2]
```

Similarly:

```csharp
int[,,,] data = new int[2, 3, 4, 5];
```

However, in normal application development, 1D and 2D arrays are much more common.

---

# 16. Jagged Arrays

A jagged array is an **array of arrays**.

Unlike a rectangular multidimensional array, each inner array can have a different length.

Example:

```csharp
int[][] numbers =
{
    new int[] { 1, 2 },
    new int[] { 3, 4, 5 },
    new int[] { 6, 7, 8, 9 }
};
```

Visually:

```text
numbers
   |
   +----> [1, 2]
   |
   +----> [3, 4, 5]
   |
   +----> [6, 7, 8, 9]
```

Notice that the rows have different lengths.

---

# 17. Accessing Jagged Arrays

```csharp
Console.WriteLine(numbers[0][1]); // 2
Console.WriteLine(numbers[1][2]); // 5
Console.WriteLine(numbers[2][3]); // 9
```

The first index selects the inner array.

The second index selects the element inside that inner array.

---

# 18. Looping Through a Jagged Array

Because each row can have a different length, use:

```csharp
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = 0; j < numbers[i].Length; j++)
    {
        Console.Write(numbers[i][j] + " ");
    }

    Console.WriteLine();
}
```

Output:

```text
1 2
3 4 5
6 7 8 9
```

---

# 19. Rectangular vs Jagged Arrays

This distinction is important.

### Rectangular array

```csharp
int[,] matrix =
{
    { 1, 2, 3 },
    { 4, 5, 6 }
};
```

Every row has the same number of columns.

```text
1 2 3
4 5 6
```

Access:

```csharp
matrix[1, 2]
```

---

### Jagged array

```csharp
int[][] matrix =
{
    new int[] { 1, 2 },
    new int[] { 3, 4, 5 },
    new int[] { 6 }
};
```

Rows can have different lengths.

```text
1 2
3 4 5
6
```

Access:

```csharp
matrix[1][2]
```

---

# 20. Array of Strings

Arrays aren't limited to numbers.

```csharp
string[] names =
{
    "Ram",
    "Sita",
    "Hari",
    "Gita"
};
```

Access:

```csharp
Console.WriteLine(names[0]);
```

Output:

```text
Ram
```

Loop:

```csharp
foreach (string name in names)
{
    Console.WriteLine(name);
}
```

---

# 21. Array of Characters

```csharp
char[] letters = { 'A', 'B', 'C', 'D' };
```

You can access:

```csharp
Console.WriteLine(letters[0]);
```

Output:

```text
A
```

You can also convert a string to a character array:

```csharp
string name = "Suman";

char[] characters = name.ToCharArray();
```

Now:

```text
S u m a n
0 1 2 3 4
```

---

# 22. Array of Boolean Values

```csharp
bool[] results = { true, false, true, true };
```

Example:

```csharp
foreach (bool result in results)
{
    Console.WriteLine(result);
}
```

---

# 23. Default Values of Arrays

When you create an array with `new`, elements receive default values.

### `int`

```csharp
int[] numbers = new int[3];
```

Result:

```text
0 0 0
```

### `double`

```csharp
double[] values = new double[3];
```

Result:

```text
0 0 0
```

### `bool`

```csharp
bool[] values = new bool[3];
```

Result:

```text
false false false
```

### `string`

```csharp
string[] names = new string[3];
```

Result:

```text
null null null
```

The important idea is that the array elements are initialized according to the type's default value.

---

# 24. Important Array Properties

C# arrays provide several useful properties and methods.

## `Length`

Returns the total number of elements.

```csharp
int[] numbers = { 10, 20, 30, 40 };

Console.WriteLine(numbers.Length);
```

Output:

```text
4
```

---

## `Rank`

Returns the number of dimensions.

```csharp
int[] a = { 1, 2, 3 };
Console.WriteLine(a.Rank);
```

Output:

```text
1
```

For a 2D array:

```csharp
int[,] matrix = new int[2, 3];

Console.WriteLine(matrix.Rank);
```

Output:

```text
2
```

---

## `GetLength()`

Gets the size of a particular dimension.

```csharp
int[,] matrix = new int[2, 3];

Console.WriteLine(matrix.GetLength(0)); // 2
Console.WriteLine(matrix.GetLength(1)); // 3
```

---

## `GetUpperBound()`

Returns the highest index of a dimension.

```csharp
int[] numbers = { 10, 20, 30, 40 };

Console.WriteLine(numbers.GetUpperBound(0));
```

Output:

```text
3
```

---

# 25. Useful Methods in `Array`

C# provides the `System.Array` class with useful methods.

## `Array.Sort()`

Sorts an array.

```csharp
int[] numbers = { 50, 20, 40, 10, 30 };

Array.Sort(numbers);

foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```

Output:

```text
10
20
30
40
50
```

---

# 26. `Array.Reverse()`

Reverses the array.

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };

Array.Reverse(numbers);
```

Now:

```text
50 40 30 20 10
```

---

# 27. `Array.IndexOf()`

Finds the index of an element.

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };

int index = Array.IndexOf(numbers, 30);

Console.WriteLine(index);
```

Output:

```text
2
```

If the element doesn't exist, it generally returns:

```text
-1
```

---

# 28. `Array.Copy()`

Copies elements from one array to another.

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };

int[] copy = new int[5];

Array.Copy(numbers, copy, numbers.Length);
```

Now `copy` contains:

```text
10 20 30 40 50
```

---

# 29. `Array.Clear()`

Sets elements back to their default values.

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };

Array.Clear(numbers, 0, numbers.Length);
```

For an `int` array, the result is:

```text
0 0 0 0 0
```

---

# 30. Searching an Array

You can manually search:

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };

int target = 30;
bool found = false;

foreach (int number in numbers)
{
    if (number == target)
    {
        found = true;
        break;
    }
}

Console.WriteLine(found);
```

Output:

```text
True
```

You can also use:

```csharp
int index = Array.IndexOf(numbers, target);
```

---

# 31. Finding Maximum and Minimum

You can manually calculate them:

```csharp
int[] numbers = { 10, 50, 20, 80, 30 };

int max = numbers[0];

foreach (int number in numbers)
{
    if (number > max)
    {
        max = number;
    }
}

Console.WriteLine(max);
```

Output:

```text
80
```

With LINQ, you can also write:

```csharp
int max = numbers.Max();
int min = numbers.Min();
```

You need:

```csharp
using System.Linq;
```

---

# 32. Finding the Sum

Using a loop:

```csharp
int[] numbers = { 10, 20, 30, 40 };

int sum = 0;

foreach (int number in numbers)
{
    sum += number;
}

Console.WriteLine(sum);
```

Output:

```text
100
```

Using LINQ:

```csharp
int sum = numbers.Sum();
```

---

# 33. Average

Using LINQ:

```csharp
int[] marks = { 80, 70, 90, 60, 85 };

double average = marks.Average();

Console.WriteLine(average);
```

Output:

```text
77
```

---

# 34. Array Initialization with `var`

You can use `var` when the compiler can infer the type:

```csharp
var numbers = new int[] { 10, 20, 30 };
```

The compiler understands that:

```csharp
numbers
```

is:

```csharp
int[]
```

You can also use:

```csharp
var names = new string[] { "Ram", "Sita", "Hari" };
```

But this is invalid:

```csharp
var numbers = { 10, 20, 30 }; // ❌
```

Use:

```csharp
var numbers = new[] { 10, 20, 30 };
```

---

# 35. Implicitly Typed Arrays

C# can infer the array type:

```csharp
var numbers = new[] { 10, 20, 30 };
```

The compiler determines:

```csharp
int[]
```

Similarly:

```csharp
var names = new[] { "Ram", "Sita", "Hari" };
```

becomes:

```csharp
string[]
```

All elements must have a compatible type.

---

# 36. Passing Arrays to Methods

Arrays can be passed to methods.

```csharp
static void PrintNumbers(int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
}
```

Call it:

```csharp
int[] numbers = { 10, 20, 30 };

PrintNumbers(numbers);
```

---

# 37. Returning an Array from a Method

A method can return an array.

```csharp
static int[] GetNumbers()
{
    return new int[] { 10, 20, 30, 40 };
}
```

Then:

```csharp
int[] numbers = GetNumbers();
```

---

# 38. Arrays and Reference Types

This is an important concept in C#.

An array is a **reference type**, even if it contains value types such as `int`.

For example:

```csharp
int[] a = { 10, 20, 30 };

int[] b = a;

b[0] = 100;

Console.WriteLine(a[0]);
```

Output:

```text
100
```

Why?

Because:

```csharp
int[] b = a;
```

doesn't create a new array.

Both variables refer to the **same array object**.

Conceptually:

```text
a ──────────┐
            ↓
       [10, 20, 30]
            ↑
b ──────────┘
```

After:

```csharp
b[0] = 100;
```

the array becomes:

```text
[100, 20, 30]
```

Therefore `a[0]` is also `100`.

---

# 39. Copying an Array Properly

If you want an independent copy, use:

```csharp
int[] a = { 10, 20, 30 };

int[] b = (int[])a.Clone();

b[0] = 100;

Console.WriteLine(a[0]);
Console.WriteLine(b[0]);
```

Output:

```text
10
100
```

You can also use:

```csharp
int[] b = a.ToArray();
```

with LINQ.

---

# 40. Array vs `List<T>`

This is extremely important when developing applications.

### Array

```csharp
int[] numbers = new int[5];
```

Size is fixed.

### List

```csharp
List<int> numbers = new List<int>();
```

Size can grow.

For example:

```csharp
numbers.Add(10);
numbers.Add(20);
numbers.Add(30);
```

Then:

```text
10 20 30
```

You can add another:

```csharp
numbers.Add(40);
```

So the basic difference is:

| Feature       | Array           | List                |
| ------------- | --------------- | ------------------- |
| Size          | Fixed           | Dynamic             |
| Syntax        | `int[]`         | `List<int>`         |
| Indexing      | Yes             | Yes                 |
| Add easily    | No              | Yes                 |
| Remove easily | No              | Yes                 |
| Performance   | Very efficient  | Slight overhead     |
| Common use    | Fixed-size data | Dynamic collections |

---

# 41. Array vs List Example

Suppose you know there will always be exactly 5 exam marks:

```csharp
int[] marks = new int[5];
```

An array is perfectly reasonable.

But if you are storing users who can register at any time:

```csharp
List<string> users = new List<string>();
```

is generally more appropriate.

```csharp
users.Add("Ram");
users.Add("Sita");
users.Add("Hari");
```

---

# 42. Common Array Mistakes

### Mistake 1: Forgetting zero-based indexing

```csharp
int[] numbers = { 10, 20, 30 };

Console.WriteLine(numbers[1]); // 20
```

Not `10`.

---

### Mistake 2: Going beyond the array

```csharp
int[] numbers = new int[3];

numbers[3] = 100; // ❌
```

Valid indices are:

```text
0, 1, 2
```

---

### Mistake 3: Using `<=` instead of `<`

Incorrect:

```csharp
for (int i = 0; i <= numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
```

At the end, it tries:

```csharp
numbers[numbers.Length]
```

which doesn't exist.

Correct:

```csharp
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
```

---

### Mistake 4: Expecting an array to grow

```csharp
int[] numbers = new int[3];

// Want to add another element
```

You cannot simply do:

```csharp
numbers.Add(40); // ❌
```

Use:

```csharp
List<int>
```

if dynamic size is required.

---

# 43. A Practical Example

Let's create a small program that accepts student marks and calculates the total, average, maximum, and minimum.

```csharp
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] marks = new int[5];

        for (int i = 0; i < marks.Length; i++)
        {
            Console.Write($"Enter mark {i + 1}: ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nMarks:");

        foreach (int mark in marks)
        {
            Console.WriteLine(mark);
        }

        Console.WriteLine($"Total: {marks.Sum()}");
        Console.WriteLine($"Average: {marks.Average()}");
        Console.WriteLine($"Maximum: {marks.Max()}");
        Console.WriteLine($"Minimum: {marks.Min()}");
    }
}
```

This example combines:

* Array declaration
* Array creation
* User input
* Indexing
* `for`
* `foreach`
* `Length`
* LINQ
* `Sum()`
* `Average()`
* `Max()`
* `Min()`

---

# 44. Important Syntax Cheat Sheet

### Declare

```csharp
int[] numbers;
```

### Create

```csharp
numbers = new int[5];
```

### Declare + create

```csharp
int[] numbers = new int[5];
```

### Initialize

```csharp
int[] numbers = { 10, 20, 30 };
```

### Modern initialization

```csharp
int[] numbers = [10, 20, 30];
```

### Access

```csharp
numbers[0];
```

### Modify

```csharp
numbers[0] = 100;
```

### Size

```csharp
numbers.Length;
```

### Loop

```csharp
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
```

### Foreach

```csharp
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```

### Sort

```csharp
Array.Sort(numbers);
```

### Reverse

```csharp
Array.Reverse(numbers);
```

### Search

```csharp
Array.IndexOf(numbers, 20);
```

### 2D array

```csharp
int[,] matrix = new int[3, 3];
```

### Jagged array

```csharp
int[][] matrix = new int[3][];
```

---

## The mental model to remember

Think of an array as a **fixed-size row of boxes**:

```text
int[] numbers = { 10, 20, 30, 40 };

             Index
               ↓
        ┌────┬────┬────┬────┐
        │ 10 │ 20 │ 30 │ 40 │
        └────┴────┴────┴────┘
          0    1    2    3
```

`numbers` refers to the whole array, while `numbers[2]` refers to one element.

The most important things to master are:

**declaration → creation → initialization → indexing → `Length` → loops → 2D arrays → jagged arrays → array methods → arrays vs `List<T>`.**
