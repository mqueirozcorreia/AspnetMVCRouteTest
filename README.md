# Test for the question and answers of [Asp.net MVC 5 Attribute Routing Constraint](https://stackoverflow.com/questions/49523867/asp-net-mvc-5-attribute-routing-constraint/49523891?noredirect=1#comment86065404_49523891)

## Tests using Attribute:
http://localhost:50964/home/edit = OK

http://localhost:50964/home/edit?promoid=5 = OK

http://localhost:50964/home/edit?promoid=a = Error 500


## Tests using MapRoute
http://localhost:50964/home/EditFromMapRoute = OK

http://localhost:50964/home/EditFromMapRoute?promoid=asd = OK

http://localhost:50964/home/EditFromMapRoute?promoid=5 = OK

