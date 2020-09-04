# Design Patterns
## Creational
### Builder
Useful for object creation when there are many possible configurations for the object, or when the instatantion is complex resulting in a constructor with many parameters.
* **Fluent builder** - Allows you to chain calls to the builder.
* **Inheritable fluent builder** - Allows you to extend the behaviour of a builder class, but requires the use of recursive generics in order to make it fluent.
* **Functional builder** - Provides abstract class similar to inheritable fluent builder, but uses clean Linq expression for building the final object.
* **Faceted builder** - If required you can encapsulate multiple complex builders within a single 'facade' builder.

### Factory
A factory can take care of object creation, without exposing the creation logic to the client.

### Prototype
The prototype pattern allows you to copy exisiting objects (deep cloning) without making your code dependent on their classes. The objects that support cloning are called prototypes.

### Singleton