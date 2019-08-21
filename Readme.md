# Enumerizer

A mini utility that provides a declarative way to iterate integers:

```csharp
// Import Enumerizer in each file you want to use it
using static Enumerizer;

// 0 1 2 3 4 5 6 7 8 9
foreach (int i in 0 <= i < 10)
    Console.Write(i + " ");

// 10 9 8 7 6 5 4 3 2 1 0
foreach (int i in 10 >= i >= 0)
    Console.Write(i + " ");

// 10 8 6 4 2 0
foreach (int i in 10 >= i >= 0 | 2)
    Console.Write(i + " ");

// -13 -10 -7 -4 -1 2 5 8
foreach (int i in -14 < i <= 10 | 3)
    Console.Write(i + " ");
```

A usage with Linq is also possible:

```csharp
using System.Linq;
using static Enumerizer;

// [ -3, -2, -1, 0, 1, 2, 3 ]
int[] it = (-3 <= i <= 3).ToArray();
```
