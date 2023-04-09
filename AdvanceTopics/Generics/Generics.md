# Generics

#### What problem generics needs to solve:<Br>
- Generaics concpet is not available in .NET version 1.0. 
- If we want to create a list of any object then we have to create function for each object which required a list of that type which leads to code duplicaiton in our project.
- And if there is any bug occur then we have to change it on multiple places which is bad practice in programming.
-So for every new type we have to create new class of that type which is not productive way for doing things that's why generics came into picture.
 
- For solving this problem we can Replace any type with object type because object is parent of any other class in C#.
 - But this can create perfomance penalty becuase if use this class to store value types it has to boxed in the object type first. So this will cause extra boxing and unboxing which can create a performance penalty on our project. And for reference type upcasting and downcasting happens each time so that's why we can't use this approach.

- But in generic we can create class once and we can use it at multiple time and mutliple places and it doesn't have perfomance penalty.