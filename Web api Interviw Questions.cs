======================================================================================<InterViewQuestions>=====================================================

#Web api Interviw Questions

1. Return typess in asp.net core

		Specific type , int , string ieneumrable<Employee>,
		IActionResult it will return status code
		ActionResult<T>  it will return status code and primitive data

2. Differnce between asp.net and asp.net core

		windos dependency injection third class library
		
3. explane about middleware and it simportance

		Middeleware is to handle the http request and resopnce
		Each middleware component performs a specific task and
		can modify the request or response before passing it to the next middleware in the pipeline.
		To add middleware in an ASP.NET Core Web API project, 
		you typically use the Use extension methods provided by the IApplicationBuilder interface.
		
4. Explain dependency injection and what are differnt type sof di

		Dependency Injection (DI) is a design pattern used in software development to achieve loose coupling between components in an application
		
   diff between singlton, scoped and transient 
   
   Singleton: A single instance is created and shared across the entire application.
    Scoped: A single instance is created per client request or scope.
	Transient: A new instance of the dependency is created every time it is requested.
  
    
5  what is  status codes explain 

		Http status codes are 3 digit numeric code to indicate the outcome of http request  to the server
		when the client request to the web api the server responds with http status codes which provides the information about success or failure of the request
		
		Http is to communicate between client and server
		
		(1xx)Information:
		2xx Successfull:
		this status code represent the request was successfully recieved and procesod my server
		200 ok :the request was successfull and the server has returnde the request data in responce body
		200 created: the request resulted in successfull creation of a new resource on the server
		204 No Content: the request was succefull and but there is no data to send in the responnce body
		Redirection (3xx):These status codes indicate that further action is needed by the client to fulfill the request
		Client Errors (4xx): this status codes indicate there was on error in the client request
		400 Bad Request: the request was invalid or contains the invalid data
		401 Unauthorized: the client must authenticate to get the requested resopnce
		403 Forbidden: the clinet doesnot have neccessary permission to access the requested responce
		404 Not Found: The request rosource could not found on the server
		Server Errors (5xx):These status codes indicate that there was an error on the server's side while processing the request
		500 Internal Server Error:An unexpected condition was encountered on the server
		


6. What are the different types of HTTP methods used in Web API?

		 The most commonly used HTTP methods in ASP.NET Core Web API are: 
		 GET, POST, PUT PATCH , DELETE, HEAD, CONNECT AND TRACE
		 
			GET
			(Read or retrieve data)
			The GET method is used to retrieve data from the server

			POST
			(Add new data)
			The POST method is used to submit data to be processed to a specified resource.
			It is often used to create new resources on the server.

			PUT
			(Update data that already exists)
			The PUT method is used to update or replace the entire representation of a resource at a specified URL.
			It is used for full updates
			
			PATCH: The PATCH method is used to partially update a resource.
			Unlike PUT, which requires sending the entire resource representation, PATCH allows you to send only the specific changes to be applied.

			DELETE
			(Remove data)
			: The DELETE method is used to request the removal of a resource at a specified URL.

			Route: This attribute allows you to explicitly specify a custom route for a controller action. 
			It is useful when you want to define complex or non-standard route templates.
			
			Which HTTP method is more secure GET or POST?
				GET is less secure because the URL contains part of the data sent. 
				On the other hand, POST is safer because the parameters are not stored in web server logs or the browser history.

7.How can you handle errors in Web API?
		using status code 
		ication resultedactionresult<g>
		
	Use Exception Middleware: ASP.NET Core provides a built-in exception handling middleware that catches unhandled exceptions
	and returns an appropriate error response to the client. You can configure this middleware in the Startup.cs file.
	
8.Difference between rest and restful api  

????????????????????????????????????

		REST (Representational State Transfer)::
		Rest is using hhp methos and  uniform resource identifiers (URIs) to communicate and interact with resources
		REST is stateless, meaning each request from a client to a server must contain all the information needed to understand and process the request
		
		SOAP (Simple Object Access Protocol):
		SOAP is a protocol for exchanging structured information in the implementation of web services.
		It uses XML as its message format and can be carried over a variety of lower-level protocols, such as HTTP, SMTP, and TCP.
		
		RESTful API:
		RESTful APIs use standard HTTP methods (GET, POST, PUT, DELETE, etc.) to perform CRUD (Create, Read, Update, Delete) operations on resources.
		Resources are identified by URIs, and responses can be in various formats, such as JSON or XML.
		
9, what is repostory pattern and what is onion structure
		Domain Model (Product.cs):
		Repository Interface (IProductRepository.cs):
		Repository Implementation (ProductRepository.cs):
		Service Layer (ProductService.cs):
		Controller (ProductController.cs):
		Dependency Injection Configuration (Startup.cs):

10. what are differnt type of filters in asp.net core

		In ASP.NET Core, filters are used to modify the behavior of an action method or the result returned by an action
		
		Authorization Filters:
		Resource Filters
		Action Filters:
			ActionFilter=>Executes code before and after an action method is executed. 
							It is suitable for common tasks like logging, authentication checks, or modifying the action result.
			AsyncActionFilter: Similar to ActionFilter, but works with asynchronous action methods.				
		Result Filters:
			ResultFilter: Executes code before and after the execution of a result (e.g., ViewResult, JsonResult, ContentResult)
			but before the result is executed. It is used to modify or log the result.
			AsyncResultFilter: Similar to ResultFilter, but works with asynchronous action results.
		Exception Filters:  	
							ExceptionContext: Provides context information when an exception is thrown.
							ExceptionFilter: Handles exceptions that occur during the execution of an action method.
							It is used to log or customize the response for unhandled exceptions.
11. what is authentication and authorization

		Authentication:Authentication is the process of verifying the identity of a user or system.
		In ASP.NET Core, authentication is handled by the authentication middleware, 
		which processes incoming requests, validates user credentials
			Cookie Authentication
			JWT (JSON Web Token) Authentication  :The token is then sent in the request headers for authentication.
			
		Authorization:

				Authorization is the process of determining whether a user or system has the necessary permissions to access specific resources or perform certain actions within the application. 
				   Role-Based Authorization    
				   Claim-Based Authorization
				   Policy-Based Authorization
				   
12. what is linq , where u r used the linq query can you implement that
		firstorderdefault, find,
		
			LINQ to Objects:
			var numbers = new List<int> { 1, 2, 3, 4, 5 };
			var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
			
			LINQ to Entities:
			
			var dbContext = new AppDbContext(); // Assuming you have an instance of AppDbContext
			var products = dbContext.Products.Where(p => p.Price <= 100).ToList();
			
		Sorting Queries:

		OrderBy: The OrderBy
		
		Aggregation Queries:
		Count: The Count operator returns the number of elements in a sequence.
		
		var firstProduct = products.FirstOrDefault(p => p.Category == "Electronics"); It return first elsemnt else it will return 0 and not showing exception
		var product = productsList.Find(p => p.Id == 1);    
		var products = new List<Product>
		{
			new Product { Id = 1, Name = "Product A", Price = 10.99m },
			new Product { Id = 2, Name = "Product B", Price = 15.49m },
			new Product { Id = 3, Name = "Product C", Price = 7.99m }
		};

		var productNames = products.Select(p => p.Name);
		
13.how to intercat db with api(ado or linq or orm) can you explain indetal
14. Ado( executenonquery, execute scalar)

ok

15. what is entity framwork

Entity Framework (EF) is an Object-Relational Mapping (ORM) framework provided by Microsoft.


16. what is Routing?

		process of mapping the incoming HTTP Request (URL) to a particular resource i.e. controller action method. 
		
		For the Routing Concept in ASP.NET Core Web API, we generally set some URLs for each resource.
		When we run the application, then it will create the Route table and the Route table will contain the mapping information between the URL and the Resource. 
		So, when we are sending a request from the client to the server, then the application will check the URL in the Route table and if it found an exact, 
		then the application will forward the request to that particular resource else it will throw an error saying resource not found.
		
17.what is Congigure(), configureService()

 By using ConfigureServices(), you can set up the required services for your application, 
 while Configure() defines how the incoming requests should be handled and processed.
18. what is micro services

		using Microservice architecture the application is divided into various components or modules, 
		with each module serving a particular purpose. And these components are called Microservices all to gather.
		 These components are not dependent on the application itself.
		 Each of these components is truly independent in all technical manners.
		 Because of this robust separation, you can have separately dedicated Databases for each component 
		 i.e., Microservice as well as can deploy them to separate Hosts & Servers.
		 
		 
		 Ability to choose multiple technologies/languages for each microservice.
		 Loosely Coupled Architecture because of the modular approach.

use ocelot

API Gateway is nothing but a middleware layer of directing incoming HTTP request calls from Client applications 
to specific Microservice without directly exposing the Microservice details to the Client and returning the responses generated from the respective Microservice.


 It mimics masking multiple microservices existing behind that the client does not have to worry about the location of each and every Microservic
 api gate way, mediater, messagig, same port with using upstream and downstream, docketimages and docker container
 
 
 without intarcting micro service we can go by using api gateway ocelot
 
 studentadmis  2034
 studnetatrte   3984
 
 ocelot sslport same   4318
 suppose:  

 mutiple project sin one solution 
 api gateway
 stuent admi
 student attend
 
 
 
