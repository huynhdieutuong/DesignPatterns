# DesignPatterns
 ## Creational
- **Factory method** - defines an interface for creating an object, but lets subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.
![Factory Method UML](./CSharp/Creational/FactoryMethod/UML.png)
![Pizza diagram](./CSharp/Creational/FactoryMethod/diagram.png)

 ## Structural
- **Decorator** - attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.
![Decorator UML](./CSharp/Structural/Decorator/UML.png)
![Duck diagram](./CSharp/Structural/Decorator/diagram.png)

 ## Behavioral
- **Strategy** - defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.
![Strategy UML](./CSharp/Behavioral/Strategy/UML.png)
![Duck diagram](./CSharp/Behavioral/Strategy/diagram.png)

- **Observer** - defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
![Observer UML](./CSharp/Behavioral/Observer/UML2.png)
![WeatherData diagram](./CSharp/Behavioral/Observer/diagram.png)

# SOLID
 ## Single Responsibility
 - Decorator
 - Factory Method
 ## Open for Extension / Closed for Modification
 - Strategy
 - Observer
 - Decorator
 - Factory Method
 ## Liskov Substitution
 ## Interface Segregation
 ## Dependency Inversion

# OO Principles
- Encapsulate what varies
- Favor composition over inheritence
- Program to interfaces, not implementations
- Strive for loosely coupled designs between objects that interact
- Classes should be open for extension but closed for modification
- Depend on abstractions. Do not depend on concrete classes