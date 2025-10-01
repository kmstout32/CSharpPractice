# # 🐦 C# Exercism Solutions 🍲

This repository contains my completed solutions for various exercises from the **C# Track** on [Exercism](https://exercism.org/tracks/csharp).

The goal of these exercises is to practice core C# language features, object-oriented principles, and standard library usage by solving small, focused problems.

## 📁 Repository Structure

Each exercise solution is typically contained within a single .cs file.

| File | Exercise | Concepts Practiced |
| :--- | :--- | :--- |
| `BirdCount.cs` | Bird Count | Array indexing, iteration (loops/LINQ), instance methods, static methods. |
| `Lasagna.cs` | Lasagna | Class definitions, instance methods, basic arithmetic, re-using methods. |
| `[OtherFile].cs` | [Exercise Name] | [Key concepts] |

---

## 📝 Completed Exercises

### BirdCount

This exercise involved creating a `BirdCount` class to track bird sightings over several days, using an array of integers.

**Key Implementations:**
* **`LastWeek()`**: A static method returning a fixed array.
* **`Today()`**: Returning the last element of the array (the most recent day).
* **`IncrementTodaysCount()`**: Mutating the last element of the array.
* **`HasDayWithoutBirds()`**: Checking if any array element is `0`.
* **`CountForFirstDays()`**: Summing a subarray based on a specified number of days.
* **`BusyDays()`**: Counting days that met or exceeded a specific threshold (e.g., 5 birds).

### Lasagna

This exercise focused on implementing simple methods for a `Lasagna` class, practicing method definition, returning values, and basic arithmetic based on cooking rules.

**Key Implementations:**
* **`ExpectedMinutesInOven()`**: Returning a constant value (`40`).
* **`RemainingMinutesInOven()`**: Calculating `40 - actualMinutesInOven`.
* **`PreparationTimeInMinutes()`**: Calculating preparation time based on `layers * 2`.
* **`ElapsedTimeInMinutes()`**: Summing preparation time and actual oven time, demonstrating method reuse.

---

## 🚀 Getting Started

If you are following along, you can download the exercises yourself using the Exercism CLI:

1.  **Install the Exercism CLI.**
2.  **Download the exercise:**
    ```bash
    exercism download --track=csharp --exercise=lasagna
    exercism download --track=csharp --exercise=bird-count
    ```
3.  **Run the tests** locally to verify the solution:
    ```bash
    dotnet test
    ```

---

*This README was generated to document the progress on the C# Exercism track.*