======================================================================================<InterViewQuestions>=====================================================
#C# Interview Questions

 1.difference between static , readonly and constant
  constant:
   const keyword is declares a constant varibale,
   the varabileb is constant at compile time and it is manditory to assign the value
   by default it is a static 
   if do reassign in value constructor anyway the  it will give an error
   
  readonly:
    A readonly field can be initialized either at the time of declaration or within the constructor of the same class.
	
	readonly keyword we can change the during runtime or assign it in runtime but only through non-static constructor
	
	like we can take
			public calss Employee{
				 readonly string re;
			 public Employee(){
				re="Hai mahesh";
			}
			public Employee( string s){
				re= s+"Hai mahesh";
			}
			}
			so we can reassign the value using readonly through parmeter constructor
			
	Static:
	static readonly:
	

2.explain about extension methods and its implementation

     extension method allows developers to extend the functionality of an existing type without creating a new derived type,
	 without modifyng the original class
	 C# extension method is a static method of a static class, where the "this" 
	 modifier is applied to the first parameter. 
	 The type of the first parameter will be the type that is extended.
	 
			 public class Class1
			{
				public string Display()
				{
					return ("I m in Display");
				}

				public string Print()
				{
					return ("I m in Print");
				}
			}
			
			 public static class XX
			{
				 public static void NewMethod(this Class1 ob)
				{
					Console.WriteLine("Hello I m extended method");
				}
			}

			class Program
			{
				static void Main(string[] args)
				{
					Class1 ob = new Class1();
					ob.Display();
					ob.Print();
					ob.NewMethod();
				 
				}
			}
			
			Extension methods allow existing classes to be extended without relying on inheritance or changing the class's source code
			if the class is sealed we need to use extension methods otherwise we can not do that
			
3.oops? and its real time example
	
	class
	object
	inheritance
	polymorphism
	encapsulation
 a).Access modifiers
	
4.explain abstraction and interface and its difference
		Data abstraction is the process of hiding certain details and showing only essential information to the user.
		Abstraction can be achieved with either abstract classes or interfaces
	Abstract class vs interface :
		Abstract:	
			An abstract class doesn't provide full abstraction 
			 abstract we cannot achieve multiple inheritance
			 We can not create an object of an abstract class and 
			 can call the method of abstract class with the help of class name only
			
		interface:
			 interface does provide full abstraction
			 Interface we can achieve multiple inheritance.
			 We can not use any access modifier i.e. public, private, protected, internal etc.,
			 because within an interface by default everything is public.
			An Interface member cannot be defined using the keyword static, virtual, abstract or sealed.
		


5.Differnce between ref, out, 

		Out:
		The out is a keyword in C# which is used for the passing the arguments to methods as a reference type. 
		It is generally used when a method returns multiple values
		It is not necessary to initialize parameters before it pass to out
		
		ref:
		The ref keyword passes arguments by reference
		It is necessary the parameters should initialize before it pass to ref.
		ref keyword can help us to give multiple outputs from a function in C#
		
6. value type and reference type, boxing and unoxing

7. what is constructor and and its types

	Constructor:
	constructor is a special method which is invoked automatically at the time of object creation
	class name and constructor name both are same
	constructor is used to initilize the values
	When you have not created a constructor in the class, 
	the compiler will automatically create a default constructor of the class.
	The default constructor initializes all numeric fields in the class to zero and all string and object fields to null.
	
	A class can have any number of constructors.
	A constructor doesn't have any return type, not even void.
	A static constructor can not be a parametrized constructor.
	Within a class, you can create one static constructor only
	
		Default Constructor: we can pass only same value, we can't pass different value.
		Parameterized Constructor: we can pass different value.
		Copy Constructor
		Static Constructor:
			A static constructor does not take access modifiers or have parameters.
			it will be invoked only once for all of the instances of the class 
			and it is invoked during the creation of the first instance of the class
		Private Constructor:
			

8. what is method over loading and overriding

9. what is array and array list, linked list and its differnece

		Array:
		    An array is used to store a collection of similar data
			It as fixed size
			Arrays belong to System.Array namespace
			Array cannot accept null.
			They are stored in contiguous memory locations.
			In the case of arrays, the memory allocation is done at compile time.
			int[] arr = new int[4];
			
		Arraylist:
			In ArrayList we can store different datatype variables.
			ArrayList is dynamic in size 
			ArrayList belongs to System.Collection
			ArrayList can accepts null.
			 ArrayList al = new ArrayList();
		linked list:
			LinkedList internally uses a doubly linked list to store the elements.
			They are not stored in contiguous memory locations.
			In the liked lists, memory allocation is done at run time.
			
			
			


================================================================================

Encapsulation:

 class
atm for abstarction

click the photo on camera

polymorphism:



 book a cab called to one person  compile time poly
 
 book a cab called cab call to office , office boy told ac non ac bentz car  runtime ploy   
 
compile time polymorphism 
 runtime polymorphism
 
 ======================================================================
 Collections are nothing but groups of records
 
 Collections are classified into 4 types such as 
 Indexed Based =+>array and list
 , Key-Value Pair  =>Hashtable., sorted list
 , Prioritized Collection =>stack queue
 , and Specialized Collections =>
 
 Non-Generic== System.Collections 