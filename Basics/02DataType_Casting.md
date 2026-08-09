# Data Types and Type Casting in C#

In C#, **data types** tell the compiler what kind of data a variable can store, while **type casting/conversion** is the process of changing a value from one type to another.

---

# 1. Data Types in C#

C# is a **strongly typed language**. Every variable has a type.

```csharp
int age = 21;
double salary = 50000.50;
string name = "Suman";
bool isStudent = true;
```

Here:

```text
age        → int
salary     → double
name       → string
isStudent  → bool
```

The major categories are:

```text
C# Data Types
│
├── Value Types
│   ├── Integral
│   ├── Floating-point
│   ├── decimal
│   ├── bool
│   ├── char
│   ├── struct
│   └── enum
│
└── Reference Types
    ├── string
    ├── object
    ├── class
    ├── array
    └── interface
```

---

# 2. Integer Types

These store whole numbers.

| Type     |    Size | Approximate range            |
| -------- | ------: | ---------------------------- |
| `byte`   |  1 byte | 0 to 255                     |
| `sbyte`  |  1 byte | -128 to 127                  |
| `short`  | 2 bytes | -32,768 to 32,767            |
| `ushort` | 2 bytes | 0 to 65,535                  |
| `int`    | 4 bytes | -2.1 billion to 2.1 billion  |
| `uint`   | 4 bytes | 0 to 4.29 billion            |
| `long`   | 8 bytes | Very large integers          |
| `ulong`  | 8 bytes | Very large positive integers |

The most commonly used is:

```csharp
int age = 21;
```

For very large integers:

```csharp
long population = 8000000000L;
```

---

# 3. Floating-Point Types

Used for numbers containing decimal values.

## `float`

```csharp
float temperature = 36.5f;
```

Notice the `f`.

```csharp
float x = 10.5f;
```

Without `f`, `10.5` is normally treated as a `double`.

---

## `double`

```csharp
double price = 99.99;
```

`double` is the usual choice for general-purpose decimal calculations.

---

## `decimal`

```csharp
decimal accountBalance = 50000.50m;
```

Notice the `m`.

`decimal` is particularly useful for **financial calculations**, where decimal precision is important.

---

# 4. `char`

Stores a **single character**.

```csharp
char grade = 'A';
char symbol = '$';
char letter = 'X';
```

Use **single quotes**:

```csharp
'A'
```

Not:

```csharp
"A" // string
```

---

# 5. `string`

Stores text.

```csharp
string name = "Suman";
string message = "Hello World";
```

Strings use double quotes:

```csharp
"Hello"
```

---

# 6. `bool`

Stores either `true` or `false`.

```csharp
bool isLoggedIn = true;
bool isAdmin = false;
```

Commonly used with conditions:

```csharp
if (isLoggedIn)
{
    Console.WriteLine("Welcome!");
}
```

---

# 7. `object`

`object` is the base type of all C# types.

You can store different types in an `object` variable:

```csharp
object value = 10;

value = "Hello";

value = 10.5;
```

However, you'll often need to convert/unbox the value before using it as a specific type.

---

# 8. Value Types vs Reference Types

This is very important for understanding type casting.

### Value types

Examples:

```text
int
double
float
decimal
bool
char
struct
enum
```

Example:

```csharp
int x = 10;
int y = x;

y = 20;

Console.WriteLine(x); // 10
Console.WriteLine(y); // 20
```

`x` and `y` have independent values.

### Reference types

Examples:

```text
class
array
string
object
interface
```

For example:

```csharp
int[] a = { 10, 20, 30 };
int[] b = a;

b[0] = 100;

Console.WriteLine(a[0]); // 100
```

Both `a` and `b` refer to the same array.

---

# Type Casting and Type Conversion

There are several ways to convert one type into another in C#.

The important ones are:

```text
1. Implicit conversion
2. Explicit conversion / casting
3. Convert class
4. Parse()
5. TryParse()
6. Boxing
7. Unboxing
8. Reference type casting
```

Let's go through them.

---

# 9. Implicit Type Conversion

An **implicit conversion** happens automatically when the conversion is considered safe.

For example:

```csharp
int x = 100;

double y = x;
```

C# automatically converts:

```text
int → double
```

You don't need to write anything.

```csharp
Console.WriteLine(y);
```

Output:

```text
100
```

Another example:

```csharp
int number = 100;

long largeNumber = number;
```

Generally:

```text
byte → short → int → long → float → double
```

can involve implicit numeric conversions, subject to C#'s exact conversion rules.

---

# 10. Explicit Type Casting

Sometimes the conversion isn't guaranteed to preserve the value, so C# requires you to explicitly tell it to convert.

Syntax:

```csharp
(targetType)value
```

Example:

```csharp
double x = 10.75;

int y = (int)x;

Console.WriteLine(y);
```

Output:

```text
10
```

The `.75` is discarded.

### Important

Casting does **not** round the number.

```csharp
double x = 10.99;

int y = (int)x;

Console.WriteLine(y);
```

Output:

```text
10
```

If you want rounding:

```csharp
double x = 10.99;

int y = (int)Math.Round(x);

Console.WriteLine(y);
```

Output:

```text
11
```

---

# 11. Another Example of Casting

```csharp
int x = 10;

double y = (double)x;
```

Although this cast is unnecessary because `int → double` is implicit, it is still valid.

```csharp
Console.WriteLine(y); // 10
```

---

# 12. Character to Integer

A `char` internally represents a numeric Unicode code unit.

```csharp
char letter = 'A';

int number = (int)letter;

Console.WriteLine(number);
```

Output:

```text
65
```

Because Unicode/ASCII-compatible encoding gives:

```text
'A' → 65
```

Reverse:

```csharp
int number = 65;

char letter = (char)number;

Console.WriteLine(letter);
```

Output:

```text
A
```

---

# 13. `Convert` Class

C# provides the `Convert` class for common conversions.

For example:

```csharp
string value = "100";

int number = Convert.ToInt32(value);

Console.WriteLine(number);
```

Output:

```text
100
```

Other examples:

```csharp
double x = Convert.ToDouble("10.5");

int y = Convert.ToInt32("100");

string text = Convert.ToString(123);

bool result = Convert.ToBoolean("true");
```

---

# 14. `Parse()`

`Parse()` converts a string into a specific type.

```csharp
string value = "100";

int number = int.Parse(value);

Console.WriteLine(number);
```

For `double`:

```csharp
string value = "10.5";

double number = double.Parse(value);
```

For `decimal`:

```csharp
string value = "50000.50";

decimal amount = decimal.Parse(value);
```

---

# 15. `Parse()` Can Throw an Exception

Suppose:

```csharp
string value = "Hello";

int number = int.Parse(value);
```

This cannot be converted into an integer, so a `FormatException` can occur.

That's why `TryParse()` is often safer when processing user input.

---

# 16. `TryParse()`

`TryParse()` attempts the conversion without throwing an exception for ordinary invalid input.

```csharp
string input = "100";

if (int.TryParse(input, out int number))
{
    Console.WriteLine($"Number = {number}");
}
else
{
    Console.WriteLine("Invalid number");
}
```

Output:

```text
Number = 100
```

Invalid input:

```csharp
string input = "Hello";

if (int.TryParse(input, out int number))
{
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Invalid number");
}
```

Output:

```text
Invalid number
```

This is extremely useful with:

```csharp
Console.ReadLine();
```

For example:

```csharp
Console.Write("Enter your age: ");

string input = Console.ReadLine();

if (int.TryParse(input, out int age))
{
    Console.WriteLine($"Your age is {age}");
}
else
{
    Console.WriteLine("Please enter a valid number.");
}
```

---

# 17. Boxing

**Boxing** means converting a value type into an `object`.

```csharp
int number = 10;

object obj = number;
```

Here:

```text
int → object
```

The value is wrapped inside an object.

Example:

```csharp
int number = 100;

object obj = number;

Console.WriteLine(obj);
```

This is called **boxing**.

---

# 18. Unboxing

Unboxing is the reverse operation.

```csharp
object obj = 100;

int number = (int)obj;

Console.WriteLine(number);
```

Here:

```text
object → int
```

This is called **unboxing**.

The type must match appropriately:

```csharp
object obj = 100;

double value = (double)obj; // ❌ InvalidCastException
```

Even though `int` can normally convert to `double`, an object containing an `int` isn't directly unboxed as a `double`.

You could instead do:

```csharp
int number = (int)obj;
double value = number;
```

---

# 19. Reference Type Casting

Suppose we have inheritance:

```csharp
class Animal
{
}

class Dog : Animal
{
}
```

A `Dog` can be implicitly treated as an `Animal`:

```csharp
Dog dog = new Dog();

Animal animal = dog;
```

This is **upcasting**.

```text
Dog → Animal
```

because `Dog` inherits from `Animal`.

---

# 20. Downcasting

You can convert the base type back to the derived type using casting:

```csharp
Animal animal = new Dog();

Dog dog = (Dog)animal;
```

This is **downcasting**.

```text
Animal → Dog
```

But it can fail if the object isn't actually a `Dog`.

```csharp
Animal animal = new Animal();

Dog dog = (Dog)animal; // ❌ InvalidCastException
```

---

# 21. `is` Operator

You can safely check the type before casting:

```csharp
Animal animal = new Dog();

if (animal is Dog)
{
    Dog dog = (Dog)animal;
}
```

Modern C# provides pattern matching:

```csharp
if (animal is Dog dog)
{
    Console.WriteLine("It is a Dog");
}
```

This is cleaner because the cast and type check happen together.

---

# 22. `as` Operator

Another option for reference types is `as`.

```csharp
Animal animal = new Dog();

Dog dog = animal as Dog;
```

If the conversion succeeds:

```text
dog → Dog object
```

If it fails:

```text
dog → null
```

Example:

```csharp
Animal animal = new Animal();

Dog dog = animal as Dog;

if (dog == null)
{
    Console.WriteLine("Not a Dog");
}
```

`as` is generally used with reference types and nullable value types, not ordinary numeric conversions.

---

# 23. Casting vs Conversion

This distinction is important.

### Casting

Usually changes how the compiler treats an existing value/reference:

```csharp
double x = 10.5;

int y = (int)x;
```

### Conversion

Usually uses a conversion mechanism to create a value of another type:

```csharp
string x = "100";

int y = Convert.ToInt32(x);
```

or:

```csharp
int y = int.Parse(x);
```

---

# 24. Quick Comparison

| Technique     | Example                     | Common use                |
| ------------- | --------------------------- | ------------------------- |
| Implicit      | `double x = intValue;`      | Safe numeric conversion   |
| Explicit cast | `int x = (int)doubleValue;` | Numeric/reference casting |
| `Convert`     | `Convert.ToInt32("10")`     | General conversions       |
| `Parse`       | `int.Parse("10")`           | String → type             |
| `TryParse`    | `int.TryParse(...)`         | Safe string conversion    |
| Boxing        | `object x = 10;`            | Value → object            |
| Unboxing      | `int x = (int)obj;`         | Object → value            |
| `is`          | `x is Dog dog`              | Type checking             |
| `as`          | `x as Dog`                  | Safe reference conversion |

---

# 25. A Complete Example

```csharp
using System;

class Program
{
    static void Main()
    {
        // Different data types

        int age = 21;
        double height = 5.8;
        decimal salary = 50000.50m;
        char grade = 'A';
        string name = "Suman";
        bool isStudent = true;

        // Implicit conversion

        int number = 100;
        double decimalNumber = number;

        Console.WriteLine(decimalNumber);

        // Explicit casting

        double price = 99.99;
        int roundedDown = (int)price;

        Console.WriteLine(roundedDown);

        // String conversion

        string input = "500";

        int convertedNumber = Convert.ToInt32(input);
        int parsedNumber = int.Parse(input);

        Console.WriteLine(convertedNumber);
        Console.WriteLine(parsedNumber);

        // TryParse

        string userInput = "123";

        if (int.TryParse(userInput, out int result))
        {
            Console.WriteLine($"Valid number: {result}");
        }
        else
        {
            Console.WriteLine("Invalid number");
        }
    }
}
```

## The key concept to remember

```text
DATA TYPE
    ↓
Determines what a variable can store

TYPE CONVERSION
    ↓
Changes a value from one type to another

IMPLICIT
    ↓
Automatically done when safe

EXPLICIT CAST
    ↓
(type)value

Convert
    ↓
General-purpose conversion

Parse
    ↓
String → specific type

TryParse
    ↓
String → specific type safely

Boxing
    ↓
Value type → object

Unboxing
    ↓
object → value type
```

For C# fundamentals, **data types + type conversion/casting** are especially important before moving into **operators, methods, arrays, and OOP**, because you'll use these concepts throughout all of them.
