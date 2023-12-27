# CQRS (Command Query Responsibility Segregation)
## Definition:

CQRS, which stands for Command Query Responsibility Segregation, is an architectural pattern that suggests separating the read and write operations for a data store. In a traditional architecture, a single model is often used for both reading and writing data. CQRS, however, advocates having separate models for reading and writing. The idea is to optimize each model for its specific purpose, resulting in a more scalable and maintainable system.

# Key Concepts:

## Commands:

Commands represent operations that modify the state of the system.
They are responsible for creating, updating, or deleting data.
Commands are typically asynchronous and are used to trigger actions.
Queries:

Queries represent operations that retrieve data without modifying the state of the system.
They are responsible for reading and presenting data to the user.
Queries are often synchronous and optimized for efficient data retrieval.
Separation of Concerns:

CQRS promotes a clear separation of concerns between the write and read sides of the application.
This separation allows each side to be independently optimized for its specific requirements.
Event Sourcing (Optional):

CQRS is often used in conjunction with event sourcing, where changes to the state of the system are captured as a series of events.
Events provide a historical record of state changes and can be used to rebuild the system's state at any point in time.
Benefits:

## Scalability: 
CQRS allows for independent scaling of the read and write components, enabling better performance optimization.

## Flexibility: 
The separation of read and write models provides flexibility to choose different data storage and retrieval strategies based on specific requirements.

## Maintainability: 
With distinct models for reading and writing, it becomes easier to manage and evolve the system over time.

Complex Domain Logic: CQRS is well-suited for systems with complex domain logic, allowing developers to model write and read concerns independently.

# MediaTr Pattern
## Definition:

MediaTr (or Mediator) is a behavioral design pattern that defines an object that encapsulates how a set of objects interact. It promotes loose coupling between components by allowing them to communicate through a mediator rather than directly with each other. This pattern is commonly used to centralize communication logic in a system.

# Key Concepts:

## Mediator:

The mediator is a central component that facilitates communication between other components.
It knows how to route messages between different objects.
Colleague:

Colleagues are the components that communicate with each other through the mediator.
Colleagues are often unaware of each other's existence.
# Benefits:

## Decoupling:

Mediator promotes loose coupling by preventing direct communication between components.
Components are only aware of the mediator, not each other.
Reusability:

The mediator encapsulates communication logic, making it easier to reuse across different parts of the system.
Simplified Communication:

Components can communicate without knowing the details of each other's implementation, simplifying the overall system architecture.
Centralized Control:

The mediator provides a central point of control for managing communication and collaboration.
