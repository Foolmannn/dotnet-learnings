## Loops in C#

Loops are used to **repeat a block of code** until a condition is met. C# mainly provides four types of loops.

### 1. `for` loop

Best when you know how many times the code should repeat.

```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
```

Output:

```text
1
2
3
4
5
```

The structure is:

```csharp
for (initialization; condition; update)
{
    // code
}
```

### 2. `while` loop

Repeats **while a condition is true**.

```csharp
int i = 1;

while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}
```

Be careful to update the variable; otherwise you can accidentally create an **infinite loop**.

### 3. `do-while` loop

Similar to `while`, but the code runs **at least once** because the condition is checked afterward.

```csharp
int i = 1;

do
{
    Console.WriteLine(i);
    i++;
}
while (i <= 5);
```

### 4. `foreach` loop

Used to go through the elements of an array, list, or other collection.

```csharp
string[] fruits = { "Apple", "Banana", "Orange" };

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}
```

Output:

```text
Apple
Banana
Orange
```

### `break` and `continue`

`break` immediately exits a loop:

```csharp
for (int i = 1; i <= 10; i++)
{
    if (i == 5)
        break;

    Console.WriteLine(i);
}
```

`continue` skips the current iteration and moves to the next one:

```csharp
for (int i = 1; i <= 5; i++)
{
    if (i == 3)
        continue;

    Console.WriteLine(i);
}
```

A simple rule to remember: **`for` = known repetitions, `while` = repeat based on a condition, `do-while` = execute at least once, `foreach` = process every item in a collection.**
