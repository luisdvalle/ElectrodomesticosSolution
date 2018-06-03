# Winning Group technical assessment
Rest service built in .Net Core 2.0 that returns JSON formatted data from a Mongo collection of Products 

## Capabilities:
* Connects to the mongo collection to retrieve results.
* Can filter the product set based on price, min / max
* Can filter the product set based on the fantastic attribute
* Can filter the product set based on the rating attribute min / max

## Structure of this solution

* Client WebApp: an Asp.Net Core 2.0 MVC applications with an user interface that displays the JSON formatted data returned from the Mongo collection
* Web API: an Asp.Net Core 2.0 WebAPI application with the required API endpoints to serve the capabilities described above.
* Two libraries in .Net Core Standard 2.0 to provide abstractions and model classes in this solution.
* Test Project in .Net Core 2.0 providing the necessary unit tests to test the application repository.
