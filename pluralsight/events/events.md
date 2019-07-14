Events are not used for server frameworks
Events are... hard to understand?
Events are popular in forms and in desktop programming
Events build on top of DELEGATES

Delegates - allow you to define a variable that can point to and invoke different methods
the method it points to must have a specific shape and structure

Delegates are very important if you want a single instance to run multiple methods within it





//Events

imagine there are components or pieces of code that need to know when a grade is added to the gradebook
All events in dotnet have 2 parameters - object sender, EventArgs args

object sender -> object is the base type for everything in dotnet
EventArgs -> 