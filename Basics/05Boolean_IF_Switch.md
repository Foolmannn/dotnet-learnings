In C#, **Boolean, `if-else`, ternary operator, and `switch`** are fundamental for making decisions in a program. Here's a detailed explanation with examples.

---

# 1. Boolean in C#

A Boolean represents one of two values:

```csharp
true
false
```

The C# type is `bool`.

```csharp
bool isLoggedIn = true;
bool isAdmin = false;
```

You can print them:

```csharp
Console.WriteLine(isLoggedIn); // True
Console.WriteLine(isAdmin);    // False
```

### Boolean expressions

Boolean values are often produced by comparisons:

```csharp
int age = 20;

bool result = age >= 18;

Console.WriteLine(result); // True
```

Common comparison operators:

| Operator | Meaning       | Example   |
| -------- | ------------- | --------- |
| `==`     | Equal         | `x == 10` |
| `!=`     | Not equal     | `x != 10` |
| `>`      | Greater than  | `x > 10`  |
| `<`      | Less than     | `x < 10`  |
| `>=`     | Greater/equal | `x >= 10` |
| `<=`     | Less/equal    | `x <= 10` |

---

# 2. Logical Operators

Boolean expressions can be combined using logical operators.

### AND `&&`

Both conditions must be true.

```csharp
int age = 25;
bool hasLicense = true;

if (age >= 18 && hasLicense)
{
    Console.WriteLine("You can drive.");
}
```

### OR `||`

At least one condition must be true.

```csharp
bool isWeekend = true;
bool isHoliday = false;

if (isWeekend || isHoliday)
{
    Console.WriteLine("You don't have to work.");
}
```

### NOT `!`

Reverses a Boolean value.

```csharp
bool isLoggedIn = false;

if (!isLoggedIn)
{
    Console.WriteLine("Please log in.");
}
```

So:

```text
true  → !true  → false
false → !false → true
```

---

# 3. `if` Statement

The `if` statement executes code when a condition is `true`.

Syntax:

```csharp
if (condition)
{
    // code
}
```

Example:

```csharp
int age = 20;

if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}
```

If `age >= 18` is `true`, the message is printed.

---

# 4. `if-else`

Use `else` when you want to execute something when the condition is false.

```csharp
int age = 16;

if (age >= 18)
{
    Console.WriteLine("You can vote.");
}
else
{
    Console.WriteLine("You cannot vote.");
}
```

Output:

```text
You cannot vote.
```

The structure is:

```text
        condition
           |
      +----+----+
    true       false
     |            |
    if           else
```

---

# 5. `if-else if-else`

When you have multiple conditions:

```csharp
int marks = 75;

if (marks >= 80)
{
    Console.WriteLine("A");
}
else if (marks >= 70)
{
    Console.WriteLine("B");
}
else if (marks >= 60)
{
    Console.WriteLine("C");
}
else if (marks >= 50)
{
    Console.WriteLine("D");
}
else
{
    Console.WriteLine("F");
}
```

Output:

```text
B
```

### Important

C# checks conditions **from top to bottom**.

For example:

```csharp
int marks = 85;

if (marks >= 50)
{
    Console.WriteLine("Pass");
}
else if (marks >= 80)
{
    Console.WriteLine("A");
}
```

This prints:

```text
Pass
```

because `marks >= 50` is already true.

So put **more specific/high conditions first** when necessary.

---

# 6. Nested `if`

An `if` can exist inside another `if`.

```csharp
int age = 25;
bool hasLicense = true;

if (age >= 18)
{
    if (hasLicense)
    {
        Console.WriteLine("You can drive.");
    }
}
```

However, this can often be simplified:

```csharp
if (age >= 18 && hasLicense)
{
    Console.WriteLine("You can drive.");
}
```

---

# 7. Ternary Operator

The ternary operator is a **short form of `if-else`**.

Syntax:

```csharp
condition ? valueIfTrue : valueIfFalse;
```

Example:

```csharp
int age = 20;

string result = age >= 18 ? "Adult" : "Minor";

Console.WriteLine(result);
```

Output:

```text
Adult
```

This:

```csharp
string result = age >= 18 ? "Adult" : "Minor";
```

is equivalent to:

```csharp
string result;

if (age >= 18)
{
    result = "Adult";
}
else
{
    result = "Minor";
}
```

### Another example

```csharp
int number = 10;

string result = number % 2 == 0 ? "Even" : "Odd";

Console.WriteLine(result);
```

Output:

```text
Even
```

### Ternary with numbers

```csharp
int a = 10;
int b = 20;

int max = a > b ? a : b;

Console.WriteLine(max);
```

Output:

```text
20
```

### When should you use ternary?

Good:

```csharp
string status = age >= 18 ? "Adult" : "Minor";
```

Avoid making complicated nested ternaries such as:

```csharp
string result = x > 10 ? "A" : x > 5 ? "B" : x > 0 ? "C" : "D";
```

For complex logic, normal `if-else` is much easier to read.

---

# 8. `switch` Statement

`switch` is useful when you want to compare **one value against multiple possible values**.

Example:

```csharp
int day = 3;

switch (day)
{
    case 1:
        Console.WriteLine("Sunday");
        break;

    case 2:
        Console.WriteLine("Monday");
        break;

    case 3:
        Console.WriteLine("Tuesday");
        break;

    case 4:
        Console.WriteLine("Wednesday");
        break;

    default:
        Console.WriteLine("Invalid day");
        break;
}
```

Output:

```text
Tuesday
```

### How it works

If:

```csharp
day = 3;
```

C# looks for:

```csharp
case 3:
```

and executes:

```csharp
Console.WriteLine("Tuesday");
```

`break` exits the switch.

---

# 9. `default`

`default` runs when none of the cases match.

```csharp
int choice = 10;

switch (choice)
{
    case 1:
        Console.WriteLine("Add");
        break;

    case 2:
        Console.WriteLine("Delete");
        break;

    default:
        Console.WriteLine("Invalid choice");
        break;
}
```

Output:

```text
Invalid choice
```

---

# 10. Switch with Strings

`switch` is not limited to numbers.

```csharp
string role = "admin";

switch (role)
{
    case "admin":
        Console.WriteLine("Full access");
        break;

    case "user":
        Console.WriteLine("Limited access");
        break;

    case "guest":
        Console.WriteLine("Guest access");
        break;

    default:
        Console.WriteLine("Unknown role");
        break;
}
```

---

# 11. Multiple Cases

You can combine cases when they should execute the same code.

```csharp
int day = 6;

switch (day)
{
    case 1:
    case 7:
        Console.WriteLine("Weekend");
        break;

    case 2:
    case 3:
    case 4:
    case 5:
    case 6:
        Console.WriteLine("Weekday");
        break;
}
```

Output:

```text
Weekend
```

---

# 12. Modern Switch Expression

Modern C# provides a shorter form called a **switch expression**.

Instead of:

```csharp
int day = 3;
string dayName;

switch (day)
{
    case 1:
        dayName = "Sunday";
        break;

    case 2:
        dayName = "Monday";
        break;

    case 3:
        dayName = "Tuesday";
        break;

    default:
        dayName = "Invalid";
        break;
}
```

You can write:

```csharp
int day = 3;

string dayName = day switch
{
    1 => "Sunday",
    2 => "Monday",
    3 => "Tuesday",
    _ => "Invalid"
};

Console.WriteLine(dayName);
```

Here:

```csharp
_ => "Invalid"
```

means **anything that didn't match the previous cases**.

---

# 13. `if-else` vs `switch` vs Ternary

A simple way to decide:

| Situation                                  | Use               |
| ------------------------------------------ | ----------------- |
| One condition                              | `if`              |
| Two alternatives                           | `if-else`         |
| Multiple conditions                        | `if-else if-else` |
| Simple value assignment based on condition | Ternary `?:`      |
| One value with many possible values        | `switch`          |
| Modern concise value mapping               | Switch expression |

### Example

**`if-else`:**

```csharp
if (age >= 18)
{
    Console.WriteLine("Adult");
}
else
{
    Console.WriteLine("Minor");
}
```

**Ternary:**

```csharp
string status = age >= 18 ? "Adult" : "Minor";
```

**Switch:**

```csharp
switch (role)
{
    case "admin":
        Console.WriteLine("Administrator");
        break;

    case "user":
        Console.WriteLine("User");
        break;

    default:
        Console.WriteLine("Unknown");
        break;
}
```

---

# 14. A Practical Example

Suppose you're creating a simple student grading program:

```csharp
Console.Write("Enter your marks: ");

int marks = Convert.ToInt32(Console.ReadLine());

if (marks >= 80)
{
    Console.WriteLine("Grade A");
}
else if (marks >= 70)
{
    Console.WriteLine("Grade B");
}
else if (marks >= 60)
{
    Console.WriteLine("Grade C");
}
else if (marks >= 50)
{
    Console.WriteLine("Grade D");
}
else
{
    Console.WriteLine("Fail");
}
```

Or using a switch expression:

```csharp
Console.Write("Enter your marks: ");

int marks = Convert.ToInt32(Console.ReadLine());

string grade = marks switch
{
    >= 80 => "A",
    >= 70 => "B",
    >= 60 => "C",
    >= 50 => "D",
    _ => "F"
};

Console.WriteLine($"Grade: {grade}");
```

This second version demonstrates an important modern C# feature: **pattern matching in switch expressions**.

### The overall mental model

```text
Boolean
   ↓
true / false
   ↓
if ────────→ general conditions
   ↓
if-else
   ↓
if-else-if
   ↓
ternary ───→ simple if-else
   ↓
switch ────→ many possible values
   ↓
switch expression → concise modern C#
```

For learning **ASP.NET Core/C#**, these are particularly important because you'll constantly use conditions for **validation, authorization, HTTP responses, business logic, model state, and UI behavior**.
