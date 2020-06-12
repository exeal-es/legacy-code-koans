# Legacy code koans

This repository contains some small exercises to practice different techniques used while working with legacy code.

> The name *kōan* comes from [Zen](https://en.wikipedia.org/wiki/Zen), and means *a story, dialogue, question, or statement which is used to provoke the "great doubt" and to practice or test a student's progress*. Applicability to software development is inspired by [Ruby koans](http://rubykoans.com/).

At the moment, only C# exercises are provided. If you want exercises in another language, please open an issue and/or submit a pull request.

## Requirements

To practice C# exercises, you will need:
- .NET Core 3.1
- A C# IDE with automated refactoring capabilities, such as Visual Studio + Resharper extension, or Rider.

## The koans
### Hardwired dependencies koans

The `Service` class implements some logic that requires collaboration with `Dependency` class, which we want to unit test. However, calls to `Dependency` class trigger some side effects that are undesirable in a unit test.
 
Each example contains a scenario in which the `Dependency` is so coupled to the `Service` it cannot be unit tested directly. We need to change the code to make it testable, but we cannot change the code without unit tests. Only automated IDE refactors are considered safe enough to change the code while having no tests.

Your goal is, by applying a series of automated refactoring, transform the source code to a state where implementing a unit test that verifies the collaboration with `Dependency` is feasible.

Cases include:
- [Unmockable](src/LegacyCodeKoans/Unmockable): a test double of `Dependency` cannot be created and provided to `Service`, since `Dependency` class methods are final.
- [Hardwired](src/LegacyCodeKoans/Hardwired): a test double of `Dependency` cannot be provided, because an instance is created from inside `Service`.
- [Singleton](src/LegacyCodeKoans/Singleton): a test double of `Dependency` cannot be used, because `Service` references directly to a global, single instance of `Dependency`.
- [Static class](src/LegacyCodeKoans/StaticClass): a test double of `Dependency` cannot be created and provided to `Service` because calls to static methods cannot be intercepted. 

## Credits

Legacy code koans are designed and maintained by [Exeal](https://twitter.com/exeal_es), which is a consultancy that helps companies become better at delivering software through education and coaching. If you are interested in learning more about working with legacy code, please check out the [Exeal Legacy Code Training](https://twitter.com/exeal_es).

## License

![](http://i.creativecommons.org/l/by-nc-sa/3.0/88x31.png)

This project is released under a Creative Commons,
Attribution-NonCommercial-ShareAlike, Version 3.0
(http://creativecommons.org/licenses/by-nc-sa/3.0/) License.