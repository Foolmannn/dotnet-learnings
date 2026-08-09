## Variables in C#

A **variable** is a named location in memory used to store a value. In C#, every variable has a **data type**, which determines what kind of value it can store.

The basic syntax is:

```csharp
dataType variableName = value;
```

For example:

```csharp
int age = 21;
string name = "Suman";
double salary = 50000.50;
bool isStudent = true;
```

---

# 1. Declaring a Variable

You can declare a variable without immediately assigning a value:

```csharp
int age;
```

Then assign a value later:

```csharp
age = 21;
```

Or do both at once:

```csharp
int age = 21;
```

### Important

Local variables in C# **must be assigned before you read them**.

```csharp
int age;

Console.WriteLine(age); // ❌ Error
```

But:

```csharp
int age;

age = 21;

Console.WriteLine(age); // ✅
```

---

# 2. Common Variable Types

C# has several built-in data types.

### Integer

```csharp
int age = 21;
```

Stores whole numbers.

```text
-10
0
21
1000
```

### Decimal numbers

```csharp
double price = 99.99;
```

For high-precision financial calculations, `decimal` is generally preferable:

```csharp
decimal salary = 50000.50m;
```

### Character

```csharp
char grade = 'A';
```

A `char` stores **one character**.

```csharp
char symbol = '$';
```

Use **single quotes** for `char`.

```csharp
'A'    // char
```

---

### String

```csharp
string name = "Suman";
```

A string contains multiple characters.

Use **double quotes**:

```csharp
"Suman"
"Hello World"
```

---

### Boolean

```csharp
bool isLoggedIn = true;
```

A `bool` can only contain:

```text
true
false
```

---

# 3. Value Types vs Reference Types

This is an important concept in C#.

### Value types

Examples:

```csharp
int
double
float
decimal
char
bool
struct
enum
```

They directly contain their value.

```csharp
int x = 10;
int y = x;

y = 20;

Console.WriteLine(x); // 10
Console.WriteLine(y); // 20
```

Changing `y` doesn't change `x`.

---

### Reference types

Examples:

```csharp
string
class
array
object
interface
delegate
```

They work with references to objects.

For example:

```csharp
int[] numbers1 = { 1, 2, 3 };

int[] numbers2 = numbers1;

numbers2[0] = 100;

Console.WriteLine(numbers1[0]);
```

Output:

```text
100
```

Both variables refer to the same array object.

---

# 4. Variable Naming Rules

A variable name can contain:

* Letters
* Numbers
* `_`

But it **cannot start with a number**.

Valid:

```csharp
int age;
int studentAge;
int student_age;
int age2;
```

Invalid:

```csharp
int 2age;       // ❌
int student-age; // ❌
```

---

## C# is case-sensitive

These are different variables:

```csharp
int age = 20;
int Age = 30;
int AGE = 40;
```

So:

```csharp
Console.WriteLine(age); // 20
Console.WriteLine(Age); // 30
Console.WriteLine(AGE); // 40
```

---

# 5. Naming Convention

For C#, a common convention is **camelCase** for local variables:

```csharp
int studentAge;
string studentName;
double accountBalance;
```

For classes and methods, **PascalCase** is commonly used:

```csharp
class Student
{
    public void GetStudentName()
    {
    }
}
```

---

# 6. Changing Variable Values

Variables can be reassigned.

```csharp
int age = 20;

age = 21;

Console.WriteLine(age);
```

Output:

```text
21
```

You can also perform operations:

```csharp
int count = 10;

count = count + 5;

Console.WriteLine(count); // 15
```

Shorter:

```csharp
count += 5;
```

---

# 7. Constants

Sometimes you don't want a variable's value to change.

Use `const`.

```csharp
const double PI = 3.14159;
```

You cannot change it:

```csharp
PI = 4; // ❌ Error
```

Example:

```csharp
const int DAYS_IN_WEEK = 7;

Console.WriteLine(DAYS_IN_WEEK);
```

A constant must be assigned when it is declared:

```csharp
const int x; // ❌
```

---

# 8. `var` Keyword

C# allows you to let the compiler determine the variable's type.

```csharp
var age = 21;
var name = "Suman";
var price = 99.99;
var isStudent = true;
```

The compiler determines:

```text
age       → int
name      → string
price     → double
isStudent → bool
```

This:

```csharp
var age = 21;
```

is essentially a strongly typed variable whose type is inferred at compile time.

It does **not** mean the variable can change type.

```csharp
var age = 21;

age = "Hello"; // ❌ Error
```

---

# 9. `dynamic`

`dynamic` is different from `var`.

```csharp
dynamic value = 10;

value = "Hello";

value = 10.5;
```

The type can change at runtime.

Compare:

```csharp
var x = 10;
// x = "Hello"; ❌
```

versus:

```csharp
dynamic x = 10;
x = "Hello"; // ✅
```

`dynamic` should be used carefully because many type errors are discovered only at runtime.

---

# 10. Nullable Variables

Normally, value types cannot contain `null`.

For example:

```csharp
int age = null; // ❌
```

You can make a value type nullable using `?`:

```csharp
int? age = null;
```

Later:

```csharp
age = 21;
```

Other examples:

```csharp
double? salary = null;
bool? isActive = null;
DateTime? birthDate = null;
```

This is particularly useful when working with databases, APIs, and optional values.

---

# 11. Multiple Variables

You can declare multiple variables of the same type:

```csharp
int x = 10, y = 20, z = 30;
```

But for readability, separate declarations are often better:

```csharp
int x = 10;
int y = 20;
int z = 30;
```

---

# 12. Variable Scope

A variable only exists within its **scope**.

```csharp
if (true)
{
    int age = 21;

    Console.WriteLine(age); // ✅
}

Console.WriteLine(age); // ❌
```

`age` only exists inside the `{ }` block.

---

## Method scope

```csharp
static void Test()
{
    int x = 10;

    Console.WriteLine(x);
}
```

`x` is a local variable of `Test()`.

You cannot directly access it outside that method.

---

# 13. Local Variables vs Fields

This distinction becomes important when you start learning classes.

### Local variable

Declared inside a method:

```csharp
class Student
{
    void Display()
    {
        int age = 21;
    }
}
```

`age` is a local variable.

### Field

Declared inside a class but outside methods:

```csharp
class Student
{
    int age = 21;

    void Display()
    {
        Console.WriteLine(age);
    }
}
```

`age` is a **field** of the `Student` class.

---

# 14. Object Variables

Suppose you have:

```csharp
class Student
{
    public string name;
    public int age;
}
```

You can create an object:

```csharp
Student student1 = new Student();

student1.name = "Suman";
student1.age = 21;
```

Here:

```text
Student  → data type
student1 → variable
new Student() → object
```

This distinction is very important in C#:

```csharp
Student student1 = new Student();
```

The variable `student1` contains a reference to the `Student` object.

---

# 15. Type Conversion

Variables can sometimes be converted between types.

### Implicit conversion

Safe conversions happen automatically:

```csharp
int x = 10;

double y = x;
```

Here:

```text
int → double
```

is safe because a `double` can represent the integer value.

---

### Explicit conversion / Casting

Sometimes you must explicitly convert:

```csharp
double x = 10.5;

int y = (int)x;

Console.WriteLine(y);
```

Output:

```text
10
```

The decimal part is removed.

---

# 16. `Convert`

You can also use `Convert`:

```csharp
string value = "100";

int number = Convert.ToInt32(value);

Console.WriteLine(number);
```

---

# 17. Parsing

Another common approach:

```csharp
string value = "100";

int number = int.Parse(value);
```

For safer input handling:

```csharp
string value = "100";

if (int.TryParse(value, out int number))
{
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Invalid number");
}
```

`TryParse()` is especially useful when accepting user input.

---

# 18. Example Program

Putting the concepts together:

```csharp
using System;

class Program
{
    static void Main()
    {
        string name = "Suman";
        int age = 21;
        double height = 5.8;
        decimal salary = 50000.50m;
        bool isStudent = true;
        char grade = 'A';

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Salary: {salary}");
        Console.WriteLine($"Student: {isStudent}");
        Console.WriteLine($"Grade: {grade}");
    }
}
```

Output:

```text
Name: Suman
Age: 21
Height: 5.8
Salary: 50000.50
Student: True
Grade: A
```

### The main things to remember

```text
Variable       → stores a value
Data type      → determines what kind of value
var            → compiler infers the type
const          → value cannot be changed
dynamic        → type resolved at runtime
?              → nullable value type
Scope          → where the variable can be accessed
Field          → variable belonging to a class
Local variable → variable declared inside a method/block
```

For learning C#, the natural next step after variables is **C# data types → type conversion → operators → input/output → conditions → loops → methods → arrays → classes/objects**.
