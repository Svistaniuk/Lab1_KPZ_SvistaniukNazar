# **Zoo Management System in C#**

# **Description**:
This project is a zoo management system developed using C#. It includes classes representing animals, enclosures, food, employees, and zoo inventory.

# **Adherence to Programming Principles**:
1. Single Responsibility Principle: Each class in the project adheres to the Single Responsibility Principle, focusing on a specific area of functionality:

- Animal: Contains information about animals.
- Enclosure: Manages enclosures within the zoo.
- AnimalFood: Represents details about food items.
- ZooKeeper: Defines employees responsible for managing enclosures.
- Inventory: Handles the zoo’s inventory management.
  
2. Open/Closed Principle: The project's classes are designed to be open for extension but closed for modification. For instance, the addition of new animal subclasses or food types can be seamlessly integrated without altering the core logic of the Inventory class.

3. Liskov Substitution Principle: The subclasses, such as Mammal and Reptile, maintain interchangeability with the Animal class object, ensuring consistent behavior throughout the program.

4. Interface Segregation Principle: While not explicitly implemented using interfaces in this code, the concept can be applied by segregating functionalities into separate interfaces for different types of animals, enclosures, and zoo equipment.

5. Dependency Inversion Principle: The code employs constructors and properties to introduce dependencies, exemplified by the Inventory class receiving data about animals, enclosures, food, and employees through its constructor. This decouples dependencies, allowing for easy modification without altering the core logic of the Inventory class.
# **Conclusion**
This project adheres to fundamental principles of object-oriented programming, enhancing its flexibility and extensibility.
