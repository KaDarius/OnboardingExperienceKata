# OnboardingExperienceKata
Onboarding Experience in C# .NET Framework Console

This project will give you the experience you need to work well with Console Apps. We've already built this project out to support adding a User with a first and last name, whether the user is the account owner, and the login pin used.

However, this app isn't very extensive or dynamic. So, let's expand it.

## Step 1
Fork and clone the repository to your local machine.

## Step 2
Refactor, refactor, refactor. Let's work on making this project more extensive and dynamic.

Brainstorm. Use ReSharper. Do what you think is best to make this better. Some suggestions:

* Use an OnboardingParser class to confirm that the type passed is the correct type
* Use subclasses to define different types of parsing
* Use an Interface (perhaps IParsable) to subscribe these subclasses to

IParsable could have a method like this:

```csharp
public T Parse(string answer) {}; // T is the generic type for the parser subclass
```

## Step 3
Let's add more data that the user can support.

## Step 4
Make a Pull Request with this repo's `master` branch as the base, and your forked repo `master` branch for the compare.
