Example From:

https://github.com/yanshengjie/Design-Pattern/tree/master/PrototypePattern
https://dotnetcodr.com/2013/08/05/design-patterns-and-practices-in-net-the-prototype-pattern/
https://www.dotnettricks.com/learn/designpatterns/prototype-design-pattern-dotnet
https://dzone.com/articles/design-patterns-c-prototype
RealLife Example and Explanation:

https://www.c-sharpcorner.com/UploadFile/db2972/prototype-design-pattern-with-real-world-scenario624/
https://stackoverflow.com/questions/13887704/whats-the-point-of-the-prototype-design-pattern
https://www.dotnettricks.com/learn/designpatterns/prototype-design-pattern-dotnet

* Prototype pattern is used to create a duplicate object or clone of the current object to enhance performance.
This pattern is used when creation of object is costly or complex.

For Example: An object is to be created after a costly database operation. We can cache the object,
returns its clone on next request and update the database as and when needed thus reducing database calls.


* The Prototype pattern is a creation pattern based on cloning a pre-configured object. 
The idea is that you pick an object that is configured for either the default or in the ballpark of 
some specific use case and then you clone this object and configure to your exact needs.

The pattern is useful to remove a bunch of boilerplate code, when the configuration required would be onerous. 
I think of Prototypes as a preset object, where you save a bunch of state as a new starting point.

* Shallow clone: can be performed with using the Object.MemberWise Clone Method, which copies the nonstatic fields 
of the original object. With reference types the reference is copied meaning the original and cloned object reference 
to the same instance, so if a value is changed in the original object the shallow cloned object with be updated. 

Deep Clone: A deep clone copies both reference and value types, giving 2 distinct instances of an object, 
so if object A is modified the cloned object (object B) remains unchanged. While this may be preferred in some cases,
remember that there is more overhead when performing a deep clone.

