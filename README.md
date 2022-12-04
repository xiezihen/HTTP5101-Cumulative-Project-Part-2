# BlogProject_1
This is the first iteration of our blog project, which has a proof-of-concept to access our MySQL Database.

[Video which goes over codebase](https://youtu.be/uP2kH8tFXIQ)

## How to Install:
- Step 1 : Download [MAMP](https://www.mamp.info/en/downloads/) or similar MySQL environment
- Step 2 : [Download "authors.sql", "articles.sql", "comments.sql", "tags.sql" from the datagenerator](http://sandbox.bittsdevelopment.com/humber/datagenerator/)
- Step 3 : Create a blog database 
    - PhpyMyAdmin -> new database -> blog
- Step 4 : Import Tables [VIDEO GUIDE](https://youtu.be/wWMcIza-k4s)
  - PhpyMyAdmin -> Import -> Upload authors.sql
  - PhpMyAdmin -> Import -> Upload articles.sql
  - PhpMyAdmin -> Import -> Upload comments.sql
  - PhpMyAdmin -> Import -> Upload tags.sql
- Step 5 : Access Connection String properties for your blog DB and change User, Pass, Port, Database, Server in "/Models/BlogDbContext.cs"
- Step 6 : Make sure "MySQL.Data" is installed in your Visual Studio environment
    - If not installed, go to "Tools" > "Nuget Package Manager" > "Manage Nuget Packages for Solution" > "Browse" > type "MySQL.Data" > "Install"
- Step 7 : Run the solution in debugging mode (F5) **while** the database environment is running
- Step 8 : Test to see if the ListAuthors WebAPI method returns information about authors.
    - GET api/AuthorData/ListAuthors
