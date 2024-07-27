***Project Overview***

***Setup Instructions***

To run this project, follow these steps:

**Clone the Project:**

Clone the project repository to your local folder using Git.

**Configure the Database Connection:**

Update the appsettings.json file with your local database configuration. Change the line:

"Server=**Local DB**;Database=BlazorTasksContext;Trusted_Connection=True;MultipleActiveResultSets=true;trustservercertificate=true"

To use your local database name and ensure the database name is set to **BlazorTasksContext**.

**Application Features**

**Home Page**

Here is a screenshot of the home page:

![image](https://github.com/user-attachments/assets/d414f83a-e38e-4bf1-a551-241dc77f6798)


***Task 1: Create a Simple Blazor Component***

Create a Blazor component named `Counter.razor` that implements a simple counter. The counter shouldhave the following features:

1. A button to increment the count.
2. Display the current count value.
3. The initial count value should be set to zero.

**Result Screenshots:**

Initial count value of zero:
![image](https://github.com/user-attachments/assets/4aa01931-7420-4059-9b2b-703edf41a8cc)

Displaying the count value:
![image](https://github.com/user-attachments/assets/9a217e37-e500-4d4a-9fcd-2f8248d89491)

***Task 2: Create a CRUD Application***

Create a simple CRUD application to manage a list of books using Blazor and ASP.NET Core. The application should have the following features:

Features:

****1. Display a List of Books:****
Properties: Id, Title, and Author.
   ![image](https://github.com/user-attachments/assets/8fe04aa4-38a9-4e9d-8c84-d6fca4a2559a)

****2. Add a new book to the list.****
  Use the Create New link on the Index page to navigate to the create new page where you can enter the details (Title and Author). The Id is automatically generated.
  
  Below is the screenshot of **create new Page**
    ![image](https://github.com/user-attachments/assets/c815db36-5d83-4b43-8316-e402668a1841)


   **After adding:**
  ![image](https://github.com/user-attachments/assets/28587b2b-2172-42eb-93b9-ce54edc9c4e1)

****3. Edit an existing book.****

   Use the Edit link on the Index page to edit an existing book’s title and author.
   **Edit Page:**

    ![image](https://github.com/user-attachments/assets/66b7c152-7d01-4b11-922b-286355236f5e)


   **After editing:**
  ![image](https://github.com/user-attachments/assets/da96860b-a628-4c9d-a065-e2996d8710b3)


   
****4. Delete a book from the list.****

   Use the Delete link for the book you want to delete. It will prompt for confirmation and provide a delete button.
   **Delete Page:**

  ![image](https://github.com/user-attachments/assets/062555a0-7c96-465e-b8b8-cb61565d5050)

  **After Deleting**
![image](https://github.com/user-attachments/assets/5f6cdad4-d7f1-4763-b3a0-69fd72d0cb73)

Click the Details link to view detailed information about a book.

**Details Page:**
![image](https://github.com/user-attachments/assets/edd64d65-6de4-4442-ba28-9d02f33cdb8d)


Database Screenshot

**Here’s a screenshot showing the database:**
![image](https://github.com/user-attachments/assets/b479bb3d-86dd-4588-a72e-3703d31c5cab)






