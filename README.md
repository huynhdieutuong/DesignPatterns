# I. Design Patterns
## 1. Creational Patterns
### Factory method
**Factory method** - defines an interface for creating an object, but lets subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.
![Factory Method UML](./CSharp/Creational/FactoryMethod/UML.png)
![Pizza diagram](./CSharp/Creational/FactoryMethod/diagram.png)

### Abstract factory
**Abstract factory** - provides an interface for creating families of related or dependent objects without specifying their concrete classes.
![Factory Method UML](./CSharp/Creational/AbstractFactory/UML.png)
![Pizza diagram](./CSharp/Creational/AbstractFactory/diagram.png)

## 2. Structural
### Decorator
**Decorator** - attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.
![Decorator UML](./CSharp/Structural/Decorator/UML.png)
![Duck diagram](./CSharp/Structural/Decorator/diagram.png)

### Adapter
**Adapter** - converts the interface of a class into another interface the client expect. Adapter lets classes work together that coun't otherwise because of incompatible interfaces.
Object adateprs and class adapters (composition vs ingeritance). Here is the Object Adapter UML:
![Adapter UML](./CSharp/Structural/Adapter/UML.png)
![TurkeyAdapter diagram](./CSharp/Structural/Adapter/diagram.png)

### Facade
**Facade** - provide a unified interface to a set of interfaces in a subsytem. Facade defines a higher-level interface that makes the subsystem easier to use.
Object adateprs and class adapters (composition vs ingeritance). Here is the Object Adapter UML:
![Facade UML](./CSharp/Structural/Facade/UML.png)
![HomeTheater diagram](./CSharp/Structural/Facade/diagram.png)

**The Principle of Least Knowledge** talk only to your immediate friends.
![Image](./CSharp/Structural/Facade/image.png)
![Image1](./CSharp/Structural/Facade/image1.png)
![Image2](./CSharp/Structural/Facade/image2.png)

## 3. Behavioral
### Strategy
**Strategy** - defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.
![Strategy UML](./CSharp/Behavioral/Strategy/UML.png)
![Duck diagram](./CSharp/Behavioral/Strategy/diagram.png)

### Observer
**Observer** - defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
![Observer UML](./CSharp/Behavioral/Observer/UML2.png)
![WeatherData diagram](./CSharp/Behavioral/Observer/diagram.png)

### Command
**Command** - encapsulates a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.
![Command UML](./CSharp/Behavioral/Command/UML.png)
![Remote diagram](./CSharp/Behavioral/Command/diagram.png)
![Remote image](./CSharp/Behavioral/Command/image1.png)
![Remote image](./CSharp/Behavioral/Command/image2.png)

### Template Method
**Template method** - defines the skeleton of an algorithm in a method, deferring some steps to subclasses. Template method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
![Template Method UML](./CSharp/Behavioral/TemplateMethod/UML.png)
![CaffeineBeverage diagram](./CSharp/Behavioral/TemplateMethod/diagram.png)

### Iterator
**Iterator** - provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
![Iterator UML](./CSharp/Behavioral/Iterator/UML.png)
![Menus diagram](./CSharp/Behavioral/Iterator/diagram1.png)

# II. SOLID
 ## 1. Single Responsibility
 - Decorator
 - Factory Method
 - Abstract Factory
 - Command
 - Adapter
 ## 2. Open for Extension / Closed for Modification
 - Strategy
 - Observer
 - Decorator
 - Factory Method
 - Abstract Factory
 - Command
 - Adapter
 ## 3. Liskov Substitution
 ## 4. Interface Segregation
 ## 5. Dependency Inversion

# III. OO Principles
- Encapsulate what varies
- Favor composition over inheritence
- Program to interfaces, not implementations
- Strive for loosely coupled designs between objects that interact
- Classes should be open for extension but closed for modification
- Depend on abstractions. Do not depend on concrete classes
- Only talk to your friends (The Principle of Least Knowledge)
- Don't call us, we'll call you (Hollywood Principle)
- A class should have only one reason to change