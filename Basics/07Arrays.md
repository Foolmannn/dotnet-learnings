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
