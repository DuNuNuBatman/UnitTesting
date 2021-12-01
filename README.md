# Unit Testing/Refactoring

Start with the AccountOperationsTests.cs file for completing the unit tests. There are various noted in the unit tests and the various files.
**The goal is to update the AccountOperations class** in a way that allows you to test the class without involving external dependencies.

When completing think of your SOLID principles. This is going to focus on the "Dependency Inversion Principle" the most. Think of how this would be used in a production system where you are using "Inversion of Control" in the form of a dependency injection framework. 

You can use any Mock framework that you are familiar with to bypass the external dependency. In this project I used Moq https://github.com/moq/moq4

If you have any questions, go ahead and reach out. jdale@corhio.org, or you can hit me up on teams to do a video call.

Here's some resources I'd take a quick look at:
* Overall Unit Testing: https://docs.educationsmediagroup.com/unit-testing-csharp/
* Dependency Inversion: https://docs.educationsmediagroup.com/unit-testing-csharp/unit-testing/dealing-with-dependencies
* Everything Martin Fowler writes is great: https://martinfowler.com/testing/
