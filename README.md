# CSharp-FizzBuzzChallenge

A simple C# program that prints numbers from 1 to 100, replacing multiples of 3 with "Fizz", 5 with "Buzz", and both with "FizzBuzz".

## 📄 Description

This project implements the classic FizzBuzz challenge in C#. It's often used as a beginner programming exercise or in coding interviews to test basic logic and loop control.

## 💻 Code

```csharp
using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 15 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }
    }
}
```

## 🛠️ How to Run

1. Open your terminal or command prompt.
2. Navigate to the directory containing the `.cs` file.
3. Compile the code using the C# compiler:

```bash
csc Program.cs
```

4. Run the executable:

```bash
Program.exe
```

## 📦 Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) or any C# compiler (e.g., `csc`)

## 🧠 Purpose

FizzBuzz is a great way to practice:
- Control flow (if-else)
- Loops
- Modulus operator
- Basic syntax in C#

## 📝 License

This project is open source and available under the [MIT License](LICENSE).
