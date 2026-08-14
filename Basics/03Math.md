## `Math` Class in C#

The **`Math` class** in C# is a built-in class in the `System` namespace that provides methods and constants for performing common mathematical operations.

You normally use it like:

```csharp
Math.MethodName(value);
```

Example:

```csharp
double result = Math.Sqrt(25);

Console.WriteLine(result);  // 5
```

---

# 1. Math Constants

### `Math.PI`

Returns the value of π.

```csharp
Console.WriteLine(Math.PI);
```

Output:

```text
3.141592653589793
```

Example:

```csharp
double radius = 5;

double area = Math.PI * radius * radius;

Console.WriteLine(area);
```

### `Math.E`

Returns Euler's number `e`.

```csharp
Console.WriteLine(Math.E);
```

---

# 2. Absolute Value — `Math.Abs()`

Returns the positive magnitude of a number.

```csharp
Console.WriteLine(Math.Abs(-10));    // 10
Console.WriteLine(Math.Abs(25));     // 25
Console.WriteLine(Math.Abs(-5.5));   // 5.5
```

Useful when you don't care about the sign.

```csharp
int difference = Math.Abs(10 - 25);

Console.WriteLine(difference); // 15
```

---

# 3. Maximum — `Math.Max()`

Returns the larger of two values.

```csharp
int result = Math.Max(10, 20);

Console.WriteLine(result);
```

Output:

```text
20
```

Example:

```csharp
double temperature1 = 25.5;
double temperature2 = 30.2;

double maximum = Math.Max(temperature1, temperature2);
```

---

# 4. Minimum — `Math.Min()`

Returns the smaller value.

```csharp
int result = Math.Min(10, 20);

Console.WriteLine(result);
```

Output:

```text
10
```

---

# 5. Power — `Math.Pow()`

Raises a number to a specified power.

```csharp
double result = Math.Pow(2, 3);

Console.WriteLine(result);
```

Output:

```text
8
```

Mathematically:

```text
2³ = 8
```

Another example:

```csharp
double square = Math.Pow(5, 2);

Console.WriteLine(square); // 25
```

---

# 6. Square Root — `Math.Sqrt()`

Calculates the square root.

```csharp
double result = Math.Sqrt(25);

Console.WriteLine(result);
```

Output:

```text
5
```

Example:

```csharp
double result = Math.Sqrt(2);

Console.WriteLine(result);
```

Output:

```text
1.4142135623730951
```

---

# 7. Rounding Numbers

C# provides several methods for rounding.

## `Math.Round()`

Rounds a number to the nearest value.

```csharp
Console.WriteLine(Math.Round(4.4)); // 4
Console.WriteLine(Math.Round(4.6)); // 5
```

You can specify decimal places:

```csharp
double number = 12.34567;

Console.WriteLine(Math.Round(number, 2));
```

Output:

```text
12.35
```

### Important: midpoint behavior

C# uses **banker's rounding** by default for exact midpoint values.

```csharp
Console.WriteLine(Math.Round(2.5)); // 2
Console.WriteLine(Math.Round(3.5)); // 4
```

If you want traditional "half away from zero" rounding:

```csharp
Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
```

Output:

```text
3
```

---

# 8. `Math.Floor()`

Rounds **down** toward negative infinity.

```csharp
Console.WriteLine(Math.Floor(4.9));  // 4
Console.WriteLine(Math.Floor(4.1));  // 4
Console.WriteLine(Math.Floor(-4.1)); // -5
```

Notice:

```text
4.9 → 4
-4.1 → -5
```

---

# 9. `Math.Ceiling()`

Rounds **up** toward positive infinity.

```csharp
Console.WriteLine(Math.Ceiling(4.1));  // 5
Console.WriteLine(Math.Ceiling(4.9));  // 5
Console.WriteLine(Math.Ceiling(-4.1)); // -4
```

---

# 10. `Math.Truncate()`

Removes the fractional part without rounding.

```csharp
Console.WriteLine(Math.Truncate(4.9));  // 4
Console.WriteLine(Math.Truncate(-4.9)); // -4
```

This differs from `Floor()`:

```text
Math.Floor(-4.9)    → -5
Math.Truncate(-4.9) → -4
```

---

# 11. Exponential — `Math.Exp()`

Calculates:

```text
eˣ
```

Example:

```csharp
double result = Math.Exp(2);

Console.WriteLine(result);
```

Approximately:

```text
7.38905609893065
```

---

# 12. Logarithms

## `Math.Log()`

Natural logarithm:

```csharp
double result = Math.Log(Math.E);

Console.WriteLine(result); // 1
```

You can also specify a base:

```csharp
double result = Math.Log(8, 2);

Console.WriteLine(result); // 3
```

Because:

```text
log₂(8) = 3
```

---

## `Math.Log10()`

Base-10 logarithm.

```csharp
double result = Math.Log10(1000);

Console.WriteLine(result);
```

Output:

```text
3
```

Because:

```text
10³ = 1000
```

---

# 13. Trigonometric Functions

The `Math` class provides:

```text
Math.Sin()
Math.Cos()
Math.Tan()
```

Example:

```csharp
double angle = Math.PI / 2;

Console.WriteLine(Math.Sin(angle));
```

Output approximately:

```text
1
```

### Important

C# trigonometric functions use **radians**, not degrees.

For example:

```csharp
double degrees = 90;

double radians = degrees * Math.PI / 180;

double result = Math.Sin(radians);

Console.WriteLine(result);
```

Output:

```text
1
```

---

# 14. Inverse Trigonometric Functions

You also have:

```csharp
Math.Asin()
Math.Acos()
Math.Atan()
```

Example:

```csharp
double result = Math.Asin(1);

Console.WriteLine(result);
```

Result:

```text
1.5707963267948966
```

which is π/2 radians.

---

# 15. `Math.Atan2()`

`Atan2()` is particularly useful for calculating an angle from X and Y coordinates.

```csharp
double y = 1;
double x = 1;

double angle = Math.Atan2(y, x);

Console.WriteLine(angle);
```

This is commonly useful in:

* Game development
* Graphics
* Robotics
* Coordinate systems
* Direction calculations

---

# 16. Sign — `Math.Sign()`

Returns the sign of a number.

```csharp
Console.WriteLine(Math.Sign(10));   // 1
Console.WriteLine(Math.Sign(-10));  // -1
Console.WriteLine(Math.Sign(0));    // 0
```

Meaning:

```text
Positive →  1
Negative → -1
Zero     →  0
```

---

# 17. Copying the Sign — `Math.CopySign()`

Modern .NET also provides `Math.CopySign()`.

```csharp
double result = Math.CopySign(10, -1);

Console.WriteLine(result);
```

Output:

```text
-10
```

It takes the magnitude from the first argument and the sign from the second.

---

# 18. `Math.Clamp()`

Restricts a value to a particular range.

```csharp
int result = Math.Clamp(150, 0, 100);

Console.WriteLine(result);
```

Output:

```text
100
```

Because the allowed range is:

```text
0 → 100
```

Examples:

```csharp
Console.WriteLine(Math.Clamp(50, 0, 100));   // 50
Console.WriteLine(Math.Clamp(-10, 0, 100));  // 0
Console.WriteLine(Math.Clamp(150, 0, 100));  // 100
```

This is extremely useful for things like:

```text
volume
health
percentage
RGB values
game coordinates
```

---

# 19. `Math.DivRem()`

Returns both the quotient and remainder of integer division.

```csharp
int quotient = Math.DivRem(17, 5, out int remainder);

Console.WriteLine(quotient);
Console.WriteLine(remainder);
```

Output:

```text
3
2
```

Because:

```text
17 / 5 = 3 remainder 2
```

---

# 20. `Math.BigMul()`

Used for multiplying large integers while avoiding intermediate overflow in certain integer operations.

For example:

```csharp
long result = Math.BigMul(100000, 200000);

Console.WriteLine(result);
```

Result:

```text
20000000000
```

---

# 21. Common Math Methods Cheat Sheet

| Method            | Purpose              | Example                         |
| ----------------- | -------------------- | ------------------------------- |
| `Math.Abs()`      | Absolute value       | `Math.Abs(-5)` → `5`            |
| `Math.Max()`      | Maximum              | `Math.Max(5, 10)` → `10`        |
| `Math.Min()`      | Minimum              | `Math.Min(5, 10)` → `5`         |
| `Math.Pow()`      | Power                | `Math.Pow(2,3)` → `8`           |
| `Math.Sqrt()`     | Square root          | `Math.Sqrt(25)` → `5`           |
| `Math.Round()`    | Round                | `Math.Round(4.6)` → `5`         |
| `Math.Floor()`    | Round down           | `Math.Floor(4.9)` → `4`         |
| `Math.Ceiling()`  | Round up             | `Math.Ceiling(4.1)` → `5`       |
| `Math.Truncate()` | Remove decimals      | `Math.Truncate(4.9)` → `4`      |
| `Math.Sign()`     | Get sign             | `Math.Sign(-5)` → `-1`          |
| `Math.Clamp()`    | Restrict range       | `Math.Clamp(150,0,100)` → `100` |
| `Math.Exp()`      | `eˣ`                 | `Math.Exp(2)`                   |
| `Math.Log()`      | Natural logarithm    | `Math.Log(10)`                  |
| `Math.Log10()`    | Base-10 log          | `Math.Log10(100)` → `2`         |
| `Math.Sin()`      | Sine                 | `Math.Sin(x)`                   |
| `Math.Cos()`      | Cosine               | `Math.Cos(x)`                   |
| `Math.Tan()`      | Tangent              | `Math.Tan(x)`                   |
| `Math.Asin()`     | Inverse sine         | `Math.Asin(x)`                  |
| `Math.Acos()`     | Inverse cosine       | `Math.Acos(x)`                  |
| `Math.Atan()`     | Inverse tangent      | `Math.Atan(x)`                  |
| `Math.Atan2()`    | Angle from x/y       | `Math.Atan2(y,x)`               |
| `Math.DivRem()`   | Quotient + remainder | `Math.DivRem(17,5,...)`         |

---

## A practical example

Suppose you want to calculate the distance between two points:

```text
(x1, y1) = (2, 3)
(x2, y2) = (7, 8)
```

Using the distance formula:

```text
distance = √((x₂-x₁)² + (y₂-y₁)²)
```

C#:

```csharp
double x1 = 2;
double y1 = 3;

double x2 = 7;
double y2 = 8;

double distance = Math.Sqrt(
    Math.Pow(x2 - x1, 2) +
    Math.Pow(y2 - y1, 2)
);

Console.WriteLine(distance);
```

Output:

```text
7.0710678118654755
```

### One important distinction

`Math` is a **static class**, so you don't create an object like:

```csharp
Math math = new Math(); // ❌
```

Instead, you directly call its static members:

```csharp
double x = Math.Sqrt(100); // ✅
```

Also, `Math` primarily works with `double`, while related types such as `decimal` have some corresponding operations through `decimal` itself.
