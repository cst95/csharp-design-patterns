# Design Patterns
## Creational
### Builder
Useful for object creation when there are many possible configurations for the object, or when the instatantion is complex resulting in a constructor with many parameters.
* **Fluent builder** - Allows us to chain calls to the builder.
* **Inheritable fluent builder** - Allows us to extend the behaviour of a builder class, but requires the use of recursive generics in order to make it fluent.
* **Functional builder** - Provides abstract class similar to inheritable fluent builder, but uses clean Linq expression for building the final object.
* **Faceted builder** - If required you can encapsulate multiple complex builders within a single 'facade' builder.
