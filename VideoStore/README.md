# VideoStore Refactoring Kata (C#)

This repository contains a C# implementation of the VideoStore Refactoring Kata, originally proposed by Martin Fowler. The kata is designed to practice refactoring techniques, improve code quality, and learn how to address common code smells.

## How to Run the Tests

1. Make sure you have [.NET 8 SDK](https://dotnet.microsoft.com/download) installed.
2. Open a terminal in the project root.
3. Run the following command:

```bash
dotnet test tests/VideoStore.Models.Tests/VideoStore.Models.Tests.csproj
```

Or, to run tests in watch mode (auto-reload on changes):

```bash
dotnet watch --project tests/VideoStore.Models.Tests/VideoStore.Models.Tests.csproj test
```

## All Commits

Below is a list of all commits in this solution, each with a link and description:

- [f8270a0](https://github.com/andres-victor-hoyos/katas-refactoring/commit/f8270a0) refactor(customer): remove unnecessary temporary variable 'frequentRenterPoints' from Statement to fix Temporary Variable code smell
- [39c2daa](https://github.com/andres-victor-hoyos/katas-refactoring/commit/39c2daa) refactor(movie, rental): move getCharge method from Rental to Movie to address Feature Envy code smell
- [03443ad](https://github.com/andres-victor-hoyos/katas-refactoring/commit/03443ad) refactor(movie): apply Strategy pattern by injecting Price instead of priceCode, removing Switch Statement code smell
- [abf86f9](https://github.com/andres-victor-hoyos/katas-refactoring/commit/abf86f9) refactor(price): remove magic numbers and unused methods from Price hierarchy
- [8eef013](https://github.com/andres-victor-hoyos/katas-refactoring/commit/8eef013) test(customer): encapsulate Movie creation with MovieBuilder and update tests
- [fbf8b35](https://github.com/andres-victor-hoyos/katas-refactoring/commit/fbf8b35) refactor(customer): remove unnecessary temporary variable 'totalAmount' from Statement to fix Temporary Variable code smell
- [f4230a5](https://github.com/andres-victor-hoyos/katas-refactoring/commit/f4230a5) refactor(models): partial implementation of Price, RegularPrice, ChildrenPrice, and Movie for Switch Statement refactor

For a complete history, see the [commit log](https://github.com/andres-victor-hoyos/katas-refactoring/commits/main).

---

Let me know if you want to add more details or include other commits!
