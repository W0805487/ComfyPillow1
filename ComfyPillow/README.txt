Program name: ComfyPillow
program author: Manpreet Kaur
Date created: 2023-02-15 2130UTC
program purpose: Create an MVC ASP.NET application core 3.1

I make a project named ComfyPillow.
Before starting the project, I made proper planning.
I select the properties of the pillow for making my project.
I selected various properties: -
1.	ID
2.	Material
3.	Size
4.	Color
5.	Type
6.	Price
7.	Rating


1. select individual account on Authentication type
create  repository on github named Comfypillow1
create Welcome page
Completed part 1 of tutorial 

2. Start part 2 of tutorial
Add controller named: PillowControllers
Add all content according to tutorial

3.Start part 3 of tutorial: add a view
  Replaced the index method with the code which is given in tutorial.
  Calls the controller's View method.
  create new folder named pillow in the view file then created new file index.cshtml in Pillow folder.
  Replace the contents of the Views/Pillow/Index.cshtml Razor view file with the given coding in tutorial.

Date: 2023-02-16    continue....

 After that, I change the views and layout pages.
 Open the View/Shared/_Layout.cshtml file and make changes in this file. After that,
 Run the project on the IIS server to check the output.

 Everything is good...

 Create variation in Views/Pillow/Index.cshtml file and write code that is given in tutorial.
 completed part 3 of tutorial.


4. Now I start part 4 of the tutorial:  add model.
   Add a data model class in the model folder. The class name is Pillow.cs
   Update the Pillow.cs file with the given code.

   After that, I add NuGet packages from the tools menu. select NuGet Package Manager then Package Manager Console.
   Create a database context class in the Data folder and give the name of this class is
   ComfyPillowContext.cs then add a code in this class.

   Register the database context. For this purpose add the using statement at  the top of the startup.cs file.
   After that write the code in Startup.ConfigureServices file.

   Make some changes in appsetting.json file.

   The next step is Scaffolding. Use the scaffolding tool to produce Create, Read, Update, and Delete (CRUD) pages for the movie model. 
    Add a New scaffolded Item in the Controllers folder then select MVC Controller with views, using Entity Framework.

1.	Then select the Pillow(ComfyPillow.Models in the Model class.
2.	Select the ComfyPillowContext in the Data context class.
 
    It gives error and shown such error  "There was an error running the selected code generator value cannot be null.(Parameter connectionString)"

    Don't panic....

    I add default connection instead of ComfyPillow connection. 

    solve the error....
    create scaffolding.

    move on next step: Initial Migration
       Add migration InitialCreate
       Update-Database

       Running these commands in Package manager console and these run successfully.

        Part 4 is almost finish at the end of the day .












