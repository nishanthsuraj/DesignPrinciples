Single Responsibility Principle: Each software module or class should have only one reason to change.
---------------------------------------------------------------------------------------------------------------------------------------------------
Open Closed Principle: Software entities, such as modules, classes, functions, etc., should be open for Extension but closed for Modification.
---------------------------------------------------------------------------------------------------------------------------------------------------
Liskov Substitution Principle: This principle states that if S is a subtype of T, then objects of type T should be replaced with objects of type S.

The Liskov Substitution Principle says that the object of a derived class should be able to replace an object of the base class without bringing
any errors in the system or modifying the behavior of the base class. That means child class objects should be able to replace parent class objects
without compromising application integrity.
---------------------------------------------------------------------------------------------------------------------------------------------------
Interface Segregation Principle: Clients should not be forced to implement any methods they don’t use. Rather than one fat interface, numerous little interfaces are preferred 
based on groups of methods, with each interface serving one submodule.
---------------------------------------------------------------------------------------------------------------------------------------------------
Dependency Inversion Principle: High-Level Modules/Classes should not depend on Low-Level Modules/Classes. 
Both should depend upon Abstractions. Secondly, Abstractions should not depend upon Details. Details should depend upon Abstractions.
---------------------------------------------------------------------------------------------------------------------------------------------------