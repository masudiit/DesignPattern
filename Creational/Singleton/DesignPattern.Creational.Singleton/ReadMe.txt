Examples From:

http://csharpindepth.com/Articles/General/Singleton.aspx
https://www.infoworld.com/article/2899033/c-sharp/exploring-the-singleton-design-pattern.html
http://geekswithblogs.net/BlackRabbitCoder/archive/2010/05/19/c-system.lazylttgt-and-the-singleton-design-pattern.aspx

Lazy Loading
https://www.infoworld.com/article/3227207/application-development/how-to-perform-lazy-initialization-in-c.html
https://www.dotnetperls.com/lazy

voilatile
https://www.infoworld.com/article/3229360/application-development/how-to-use-the-volatile-keyword-in-c.html

Is Lazy load threadsafe
https://stackoverflow.com/questions/30076233/is-lazyt-a-good-solution-for-a-thread-safe-lazy-loaded-singleton


* The Singleton class is sealed to prevent inheritance and
it has a private constructor so that no instance of it can be created.

*The volatile keyword is used to ensure that the object is initialized prior to being accessed.
This implementation is thread safe -- a check is made to see if an instance of the Singleton class
has been created prior to creating the instance.

* Note that instead of locking on the typeof(StateManager) you should lock on a static object 
that is private to the StateManager class. This ensures that the potential risks of performance
issues and deadlocks are eliminated.

For both C# and Java, "volatile" tells the compiler that the value of a variable must never be cached as its value may
change outside of the scope of the program itself. The compiler will then avoid any optimisations that may result in
problems if the variable changes "outside of its control".

* When you are reading data that is non-volatile, the executing thread may or may not always get the latest value.
If the object is volatile, the thread always gets the most up-to-date value. You can use the volatile keyword 
with any reference, pointer, and enum types.


** In all cases the Lazy<T> class is thread-safe, but you need to remember that the Value of this type can be
thread-unsafe, and can be corrupted in multithreading environment:

*Lazy instantiation delays certain tasks. It typically improves the startup time of a C# application. 
This has always been possible to implement. But the .NET Framework now offers the Lazy type, which provides this feature.


* This is the most basic singleton, notice the key features:

Static readonly field that contains the one and only instance.
Constructor is private so it can only be called by the class itself.
Static property that returns the single instance.


Looks like it satisfies, right?  There's just one (potential) problem.  
C# gives you no guarantee of when the static field _instance will be created.  
This is because the C# standard simply states that classes (which are marked in the IL as BeforeFieldInit) can have their
static fields initialized any time before the field is accessed.  This means that they may be initialized on first use, 
they may be initialized at some other time before, you can't be sure when.

So what if you want to guarantee your instance is truly lazy.  That is, that it is only created on first call to Instance?
Well, there's a few ways to do this.  First we'll show the old ways, and then talk about how .Net 4.0's 
new System.Lazy<Type can help make the lazy-Singleton cleaner.

Obviously, we could take on the lazy construction ourselves, but being that our Singleton may be accessed by many 
different threads, we'd need to lock it down.