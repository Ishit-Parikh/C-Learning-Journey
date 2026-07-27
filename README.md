# C# Masterclass — Learning Journey

**Course:** [Complete C# Masterclass](https://www.udemy.com/share/1013Gg/) by Denis Panjuta  
**Duration:** 46h 12m · 484 lectures · 28 sections  
**Repo:** Code + notes from every section.

---

## Progress

- [x] **Section 1** — Introduction, DataTypes & Variables
- [x] **Section 2** — Making Decisions
- [x] **Section 3** — Loops
- [x] **Section 4** — Functions and Methods
- [x] **Section 5** — Object Oriented Programming (OOP)
- [x] **Section 6** — Collections
- [x] **Section 7** — Error Handling
- [x] **Section 8** — Inheritance
- [x] **Section 9** — Interfaces and Polymorphism
- [ ] **Section 10** — Structs
- [ ] **Section 11** — Events and Delegates
- [ ] **Section 12** — Regular Expressions
- [ ] **Section 13** — WPF: Windows Presentation Foundation
- [ ] **Section 14** — WPF Project: Currency Converter (Part 1)
- [ ] **Section 15** — Using Databases With C#
- [ ] **Section 16** — WPF Project: Currency Converter (Part 2)
- [ ] **Section 17** — LINQ
- [ ] **Section 18** — WPF Project: Currency Converter with API (Part 3)
- [ ] **Section 19** — Coding Interview Exercises
- [ ] **Section 20** — C# Clean Code
- [ ] **Section 21** — C# Generics
- [ ] **Section 22** — Threads
- [ ] **Section 23** — Unit Testing / TDD
- [ ] **Section 24** — Unity Basics
- [ ] **Section 25** — Unity: Pong
- [ ] **Section 26** — Unity: Zig Zag Clone
- [ ] **Section 27** — Unity: Fruit Ninja Clone
- [ ] **Section 28** — Thank You & Next Steps

---

## Notes

### Section 1 — Introduction, DataTypes & Variables

- Visual Studio Community setup, Hello World
- Comments, top-level statements, `using` directives
- Variables: `string`, `int`, `double`, `char`, `bool`
- Value types vs reference types
- Type conversion: implicit, explicit (`Parse`, `Convert`)
- `var` keyword (implicitly typed)
- Operators, order of evaluation, math
- Debugging: breakpoints, runtime vs compile-time errors
- String manipulation, formatting, indexing, escape sequences
- Char and UTF-16 (emojis)
- Mini project: Addition Calculator

### Section 2 — Making Decisions

- Logical operators (AND, OR, NOT), bool datatype
- If, else, else-if, nested if
- Relational operators (==, !=, <, >, <=, >=)
- Switch statements, when to pick switch vs if
- One-line if (ternary-style)
- String methods: Trim, ToLower (input sanitization)
- Increment/decrement (++/--), modulo operator
- TryParse for safe numeric conversion
- Random class for generating random numbers
- Mini project: Quiz app, conditional calculator

### Section 3 — Loops

- For loop: syntax, init, condition, iterator
- While loop: counter and condition-based iteration
- Do-while (guaranteed one execution)
- Break and continue statements
- Arrays: declaration, indexing, length, inline init
- Foreach loop
- Multi-dimensional arrays (2D, 3D), jagged arrays
- Escape characters (\r, \n), Thread.Sleep
- Challenges: Rocket Landing, Guess the Number, text adventure, Average Calculator

### Section 4 — Functions and Methods

- Void methods: no params, single param, multiple params
- Parameter modifiers: ref, out, in
- Argument promotion (automatic type widening)
- Top-level statements → classical Program class template
- Fields: instance vs local variables
- Expression-bodied members (=> syntax)
- Recursion (methods calling themselves)
- Mini project: WeatherSimulator (arrays, Random, for loops)

### Section 5 — Object Oriented Programming (OOP)

- Classes vs objects, creating custom classes
- Member variables, custom constructors, constructor overloading
- Auto-generated properties, custom get/set logic
- Computed properties, read-only / write-only properties
- Static methods and fields
- Expression-bodied members, nested/partial classes
- Optional and named parameters
- Operator overloading, pass by value vs by reference
- Access modifiers: public, private, const vs readonly
- `is` and `as` operators (type checking)
- ID Key pattern, the `this` keyword
- Mini project: Quiz App (Question class, scoring, console colors)

### Section 6 — Collections

- Lists: creation, Add/Remove, indexing, foreach iteration
- Pre-initialized lists, sorting with `Sort()`
- `Any()` and `FindAll()` with lambda predicates
- Lists of class objects, `Where()` clause with LINQ
- Dictionaries: `Dictionary<TKey, TValue>`, Add, key-based access
- `KeyValuePair` iteration, dictionary of complex objects
- Dictionary with `List<int>` values, nested iteration
- Exercises: List implementation, predicate delegates, dictionary exercises

### Section 7 — Error Handling

- Try-catch-finally blocks
- `TryParse` for safe input validation
- Throwing exceptions with `throw new Exception()`
- Multiple catch blocks for different exception types (`FormatException`, `IndexOutOfRangeException`)
- `finally` block guarantees execution regardless of exception
- Exercises: Finally demo, multi-exception handler

### Section 8 — Inheritance

- Base class vs derived class (`:` syntax)
- IS-A relationship (Dog IS-A Animal)
- `virtual` and `override` for method overriding
- `base` keyword to call parent class methods
- Constructor inheritance: `base(name)` chaining
- Multi-level inheritance (Animal → Dog → Cat)
- Exercises: Animal/Dog override, Person/Employee constructors, multi-level override

### Section 9 — Interfaces and Polymorphism

- Interface syntax: `interface IName { void Method(); }`
- Implementing interfaces with `: IInterface` on class declaration
- Polymorphism via interface references (one interface, multiple implementations)
- `IPayment` example: `CreditCardPayment` and `PayPalPayment` with shared `ProcessPayment()`
- Dependency Injection patterns:
  - Constructor Injection — service passed via constructor, stored as `readonly` field
  - Setter Injection — service set via property
  - Interface Injection — class implements `IDependencyInjector`, service set via method
- Polymorphism with `IShape` array containing `Circle` and `Rectangle` (each with `GetArea()`)
- Exercises: IVehicle/Car, IPayment polymorphism, DI patterns, IShape area calculator

---

## Projects

### QuizApp

A console-based multiple-choice quiz application built during Section 5 (OOP).

- **Files:** `Question.cs`, `Quiz.cs`, `Program.cs`
- `Question` class — holds question text, options array, correct answer index, and an `IsCorrect()` method
- `Quiz` class — manages the quiz lifecycle: display questions, validate user input, track score, show results
- Console colors for feedback: green for correct questions, red for options, cyan for "Great Work", red for "Try again"
- Input validation with `int.TryParse`, bounds checking on user choice (1-4)
- Score evaluation: 0-33% "Try again", 34-66% "Great Work", 67-100% "Excellent"
- Uses `ref` parameter to increment score
- Constructor-based initialization, array of `Question` objects

### Self-Challenge: Student Report Card

A menu-driven student management system built as a self-challenge after Sections 1-5.

- **Files:** `Student.cs`, `User.cs`
- `Student` class — stores name and grades array, calculates average with `CalculateAverage()`
- `User` class — manages a fixed-capacity array of students with a console menu
- Menu operations: Add Student, Add Grades, View Report Cards, Exit
- Manual array management (no Lists), capacity validation, graceful handling of empty states
- Report card displays per-subject marks and calculated average

---

## Running the Code

Each section is its own console project. Run a section with:

```bash
dotnet run --project section-XX-name
```

### Examples

```bash
dotnet run --project section-01-intro
dotnet run --project section-02-decisions
dotnet run --project section-06-collections
dotnet run --project section-07-ErrorHandling
dotnet run --project section-09-InterfaceAndPolymorphism
```

Or build everything at once:

```bash
dotnet build
```

## Structure

```
section-01-intro/              # Section 1 — Introduction, DataTypes & Variables
section-02-decisions/          # Section 2 — Making Decisions
section-03-Loops/              # Section 3 — Loops
section-04-Function-and-Methods/ # Section 4 — Functions and Methods
section-05-OOP/                # Section 5 — Object Oriented Programming
section-06-collections/        # Section 6 — Collections
section-07-ErrorHandling/      # Section 7 — Error Handling
section-08-Inheritance/        # Section 8 — Inheritance
section-09-InterfaceAndPolymorphism/ # Section 9 — Interfaces and Polymorphism
QuizApp/                       # Quiz App project (Section 5)
sec-01-to-05-self-challenege/  # Self-challenge exercises (Sections 1-5)
```

Each folder is a separate .NET console project.
