======================================================================================<InterViewQuestions>=====================================================
#Mvc interview questions

1. what is view bag and view data
		
		
			ViewBag and ViewData are two techniques used in ASP.NET MVC to pass data from a Controller to a View. 
			They are both used for the same purpose, but they have different implementations.
			
			ViewBag:
		ViewBag is a dynamic property that allows you to pass data from a Controller to a View without requiring strong typing. 
		It uses C#'s dynamic keyword
		
		ViewData:
		ViewData is a dictionary-based container provided by the ControllerBase class. 
		It allows you to store key-value pairs and pass them from a Controller to a View
		
		public ActionResult Index()
		{
			ViewBag.Message = "Hello, world!";
			return View();
		
		<p>@ViewBag.Message</p>
--
		public ActionResult Index()
		{
			ViewData["Message"] = "Hello, world!";
			return View();
		}
		
		<p>@(string)ViewData["Message"]</p>


2. write any view code to interact with controller without using model class


		public class MyController : Controller
			{
				public ActionResult Index()
				{
					ViewBag.Message = "Hello, world!";
					return View();
				}

				[HttpPost]
				public ActionResult ProcessForm(string userInput)
				{
					// Process the user input and perform any necessary actions
					// ...

					// Redirect to another action or return a view with the result
					return RedirectToAction("Result");
				}

				public ActionResult Result()
				{
					// You can access the ViewBag data in other actions as well
					ViewBag.ResultMessage = "Form successfully processed!";
					return View();
				}
			}


				@{
					ViewBag.Title = "Index";
				}

				<h2>Index</h2>

				<p>@ViewBag.Message</p>

				<form method="post" action="@Url.Action("ProcessForm")">
					<label for="userInput">Enter something:</label>
					<input type="text" name="userInput" id="userInput" />
					<input type="submit" value="Submit" />
				</form>


3. What is MVC, and how does it work?
Answer: MVC stands for Model-View-Controller.
 It is a software architectural pattern that separates an application into three interconnected components.
 The Model represents the data and business logic, the View displays the data to the user, 
 and the Controller handles user input, updating the Model and View accordingly.
 
4.Can you describe the flow of data and control in an MVC application?
		User interacts with the View, triggering an event.
		The Controller receives the event, processes user input, and updates the Model if necessary.
		The Model notifies the View of any changes.
		The View fetches the updated data from the Model and refreshes the user interface.
		
5.Explain the concept of Routing in MVC. How does it relate to handling URLs and requests?

		Routing is the process of mapping incoming URLs to appropriate Controllers and actions in an MVC application. 
		It helps handle HTTP requests and direct them to the correct Controller method, based on the URL and HTTP verb (GET, POST, etc.).
		Routing allows for creating user-friendly URLs and supports the separation of concerns by identifying the appropriate Controller for handling specific requests.
		
6.
What is the ASP.NET Application Life Cycle?
The ASP.NET Application Life Cycle is a series of events that occur during the processing of a web request
. The main events in the life cycle include Init, Load, PreRender, and Unload.		

7. ViewState:
 ViewState is used to persist state information of controls on a single web page across postbacks. 
 It stores the values in a hidden field in the page and can be encrypted for security.
 
 SessionState:
 SessionState is used to persist state information across multiple requests from the same user. 
 It is stored on the server and associated with a unique session identifier for each user.