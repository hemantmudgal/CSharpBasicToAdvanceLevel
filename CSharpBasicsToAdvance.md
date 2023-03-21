\# CSharpBasicsToAdvance:

\## Topics to cover:

\- C# VS .NET - CLR (Comman Language Runtime) - Architecutre of .NET
Application

\### C# VS .NET:

\- C# is programming language - .NET is framework for building
application on windows. \<br\>\<br\>\<br\>

\#### .NET \--\> CLR (Comman Langauge Runtime) & Class Library.

\### CLR: - CLR is a application that sitting in the memory whose job is
to translate the code into the machine code. And this process is known
as just in time compiler and JIT.

\- C# \--\> IL (Intermediate language code) / MSIL (Microsoft IL)
\--(CLR) \--\> Native Code \<br\>\<br\>\<Br\>

\### Architecture of .NET Applicatoin:

\- When we build an application with C# our application consist of
building blocks called classes. These classes collaborates with each
other at runtime and as a result the application provide some
functionality.

\### Class:

\- A class is a container that has some data which has some data which
is also called attribute and functions which is also called methods. -
The functions or methods have behavior, they do things for us, Data
represents the state of the application.

\- Class :- Data + Methods

 - For Example:

using System;

namespace HelloWorld\<br\> {\<br\> void static Main(String\[\]
args)\<br\> { Console.WriteLine(\"Function used for printing text on
console.\"); } }

\### NameSpace :-  - As the number of classes is an application grows we
need a way to organize these classes that\'s where we use namespaces. -
So a namespace is a container for related classes.

\### Assembly: - As these namespaces grow we need different way of
partitioning an application and that\'s where we use assembly. -
Physically it\'s a file on the disk which can either be an executable or
a dll file (which stands for dynamic linked library). - So when we
compiler an application the compiler builds one or more assemblies
depending on how you partition library. \<br\>

 - \*\*System\*\* - \<br\>We have all these utility classes and primitve
types.\<br\>\<br\>  - \*\*Collection.generics\*\* -\<br\> Used to work
with list and collections etc.\<br\>\<br\>  - \*\*linq\*\* - \<Br\>Linq
is used to work with data.\<br\>\<br\>  - \*\*text\*\* - \<br\>work with
text and coding and other stuff.\<br\>\<br\>  - \*\*Threading\*\* -
\<br\>Used to build multithreaded application.

### Primitve Types and Expressions :-

\#### Variable and Constants:

\- Variable: A name given to storage location in memory. - Constans: An
immutable value. The value we know at compile time, that value can not
change throught the life of the application. - We use constants for
saftery purpose in our applications. - In C# we can not use variable
unless we initialize it. - For declaring constants variables we declare
const keyword.

\#### Naming convention of variables :-

\- Camel Case : firstName - pascal Case : FirstName - Hungarian Case :
strFirstName
