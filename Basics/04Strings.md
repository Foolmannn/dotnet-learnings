# Strings in C# - Complete Guide

A **string** in C# is a sequence of Unicode characters used to store text. It is represented by the `string` keyword, which is an alias for the `System.String` class.

```csharp
string name = "John";
Console.WriteLine(name);
```

Output:

```
John
```

---

# 1. What is a String?

A string stores text data such as:

* Names
* Addresses
* Emails
* Messages
* Passwords (usually hashed before storing)

Example:

```csharp
string city = "New York";
string course = "C# Programming";
string phone = "9876543210";
```

---

# 2. Creating Strings

### Method 1: Using String Literal

```csharp
string language = "C#";
```

### Method 2: Using String Constructor

```csharp
char[] letters = { 'H', 'e', 'l', 'l', 'o' };

string word = new string(letters);

Console.WriteLine(word);
```

Output

```
Hello
```

---

# 3. String is a Reference Type

Although `string` is a reference type, it behaves much like a value type.

```csharp
string s1 = "Hello";
string s2 = s1;

s2 = "World";

Console.WriteLine(s1);
Console.WriteLine(s2);
```

Output

```
Hello
World
```

Changing `s2` does not affect `s1` because strings are immutable.

---

# 4. Strings are Immutable

**Immutable** means **cannot be changed after creation**.

Example

```csharp
string text = "Hello";

text += " World";

Console.WriteLine(text);
```

What happens internally?

```
Original string
"Hello"

↓

New string created
"Hello World"
```

The original string remains unchanged.

---

# 5. String Length

Use the `Length` property.

```csharp
string name = "Programming";

Console.WriteLine(name.Length);
```

Output

```
11
```

---

# 6. Accessing Characters

Strings are indexed starting from 0.

```csharp
string word = "Apple";

Console.WriteLine(word[0]);
Console.WriteLine(word[1]);
Console.WriteLine(word[4]);
```

Output

```
A
p
e
```

---

# 7. String Concatenation

### Using +

```csharp
string first = "John";
string last = "Smith";

string full = first + " " + last;

Console.WriteLine(full);
```

Output

```
John Smith
```

### Using `Concat()`

```csharp
string result = string.Concat("Hello", " ", "World");

Console.WriteLine(result);
```

---

# 8. String Interpolation

The recommended modern approach.

```csharp
string name = "Alice";
int age = 22;

Console.WriteLine($"Name: {name}, Age: {age}");
```

Output

```
Name: Alice, Age: 22
```

---

# 9. String Formatting

```csharp
string name = "Tom";
int marks = 95;

Console.WriteLine("Name: {0}, Marks: {1}", name, marks);
```

Output

```
Name: Tom, Marks: 95
```

---

# 10. Escape Characters

| Escape | Meaning         |
| ------ | --------------- |
| `\n`   | New line        |
| `\t`   | Tab             |
| `\"`   | Double quote    |
| `\\`   | Backslash       |
| `\r`   | Carriage return |

Example

```csharp
Console.WriteLine("Hello\nWorld");
```

Output

```
Hello
World
```

---

# 11. Verbatim Strings (`@`)

Used for file paths and multi-line text.

```csharp
string path = @"C:\Users\Admin\Documents";

Console.WriteLine(path);
```

Without `@`

```csharp
"C:\\Users\\Admin\\Documents"
```

Multi-line example

```csharp
string text = @"Line1
Line2
Line3";

Console.WriteLine(text);
```

---

# 12. Raw String Literals (`"""`)

Introduced in C# 11, raw string literals make it easy to write multi-line text without escaping quotes or backslashes.

```csharp
string json = """
{
  "name": "Alice",
  "age": 22
}
""";

Console.WriteLine(json);
```

---

# 13. Common String Methods

## ToUpper()

```csharp
string text = "hello";

Console.WriteLine(text.ToUpper());
```

Output

```
HELLO
```

---

## ToLower()

```csharp
Console.WriteLine("HELLO".ToLower());
```

Output

```
hello
```

---

## Trim()

Removes spaces from both ends.

```csharp
string name = "   John   ";

Console.WriteLine(name.Trim());
```

Output

```
John
```

---

## Replace()

```csharp
string text = "I like Java";

Console.WriteLine(text.Replace("Java", "C#"));
```

Output

```
I like C#
```

---

## Contains()

```csharp
string text = "Programming";

Console.WriteLine(text.Contains("gram"));
```

Output

```
True
```

---

## StartsWith()

```csharp
Console.WriteLine("Programming".StartsWith("Pro"));
```

Output

```
True
```

---

## EndsWith()

```csharp
Console.WriteLine("Programming".EndsWith("ing"));
```

Output

```
True
```

---

## IndexOf()

```csharp
string text = "Computer";

Console.WriteLine(text.IndexOf('p'));
```

Output

```
3
```

---

## LastIndexOf()

```csharp
string text = "banana";

Console.WriteLine(text.LastIndexOf('a'));
```

Output

```
5
```

---

## Substring()

```csharp
string text = "Programming";

Console.WriteLine(text.Substring(3));
Console.WriteLine(text.Substring(3, 4));
```

Output

```
gramming
gram
```

---

## Split()

```csharp
string data = "Red,Green,Blue";

string[] colors = data.Split(',');

foreach (string color in colors)
{
    Console.WriteLine(color);
}
```

Output

```
Red
Green
Blue
```

---

## Join()

```csharp
string[] names = { "John", "Tom", "Alice" };

Console.WriteLine(string.Join(", ", names));
```

Output

```
John, Tom, Alice
```

---

# 14. Comparing Strings

## Using `==`

```csharp
string s1 = "Hello";
string s2 = "Hello";

Console.WriteLine(s1 == s2);
```

Output

```
True
```

## Using `Equals()`

```csharp
Console.WriteLine(s1.Equals(s2));
```

---

## Case-insensitive Comparison

```csharp
string a = "HELLO";
string b = "hello";

bool same = string.Equals(
    a,
    b,
    StringComparison.OrdinalIgnoreCase);

Console.WriteLine(same);
```

Output

```
True
```

---

# 15. Empty vs Null Strings

```csharp
string s1 = "";
string s2 = null;
```

Check:

```csharp
string.IsNullOrEmpty(s1);

string.IsNullOrWhiteSpace("   ");
```

---

# 16. StringBuilder

Since strings are immutable, repeated concatenation creates many temporary strings. For many modifications, use `StringBuilder`.

```csharp
using System.Text;

StringBuilder sb = new StringBuilder();

sb.Append("Hello");
sb.Append(" ");
sb.Append("World");

Console.WriteLine(sb.ToString());
```

Output

```
Hello World
```

Use `StringBuilder` when:

* Building long strings
* Appending in loops
* Editing text frequently

---

# 17. Useful String Operations

Reverse a string

```csharp
string text = "Hello";

char[] arr = text.ToCharArray();

Array.Reverse(arr);

Console.WriteLine(new string(arr));
```

Count vowels

```csharp
string text = "Programming";
int count = 0;

foreach (char c in text.ToLower())
{
    if ("aeiou".Contains(c))
        count++;
}

Console.WriteLine(count);
```

Palindrome

```csharp
string word = "madam";

char[] arr = word.ToCharArray();

Array.Reverse(arr);

string reverse = new string(arr);

Console.WriteLine(word == reverse);
```

---

# 18. Performance Tips

* Prefer **string interpolation** (`$"..."`) for readable formatting.
* Use **`StringBuilder`** for repeated concatenation in loops.
* Use **`string.Equals`** with an appropriate `StringComparison` (such as `Ordinal` or `OrdinalIgnoreCase`) instead of converting strings with `ToUpper()` or `ToLower()` just to compare them.
* Use `string.IsNullOrWhiteSpace()` when validating user input.

---

# Summary Table

| Feature            | Example                                           |
| ------------------ | ------------------------------------------------- |
| Create string      | `string s = "Hello";`                             |
| Length             | `s.Length`                                        |
| Character          | `s[0]`                                            |
| Concatenate        | `+`, `string.Concat()`                            |
| Interpolation      | `$"{name}"`                                       |
| Uppercase          | `ToUpper()`                                       |
| Lowercase          | `ToLower()`                                       |
| Replace            | `Replace()`                                       |
| Find               | `Contains()`, `IndexOf()`                         |
| Extract            | `Substring()`                                     |
| Split              | `Split()`                                         |
| Join               | `Join()`                                          |
| Compare            | `==`, `Equals()`                                  |
| Trim spaces        | `Trim()`                                          |
| Empty check        | `IsNullOrEmpty()`                                 |
| Whitespace check   | `IsNullOrWhiteSpace()`                            |
| Efficient building | `StringBuilder`                                   |
| Multi-line text    | `@` verbatim strings or `"""` raw string literals |

Mastering strings is essential in C# because text processing is common in almost every application, from console programs and web apps to file processing, APIs, and databases. Understanding immutability, common string methods, and when to use `StringBuilder` will help you write efficient and maintainable C# code.
