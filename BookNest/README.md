
# YtBookStore 📚

YtBookStore is a web application for managing books, authors, genres, and publishers. This version has been upgraded to .NET 8.0.

## How to Run It 🏃‍♂️

1. **Clone the project:**

   ```bash
     https://github.com/DeepakScripter/ASPNetCoreBlaze/tree/3a04c8966e51598fd3e3d548425e6157a442538c/BookNest
   ```


2. **Update the connection string:**

   Open the `appsettings.json` file and update the connection string's `data source` to match your SQL Server instance:

   ```json
   "ConnectionStrings": {
     "conn": "data source=your_server_name;initial catalog=YtBookStore;integrated security=true;encrypt=false"
   }
   ```

3. **Delete the `Migrations` folder:**

   In the project directory, delete the `Migrations` folder.

4. **Apply database migrations:**

   Open the Package Manager Console in Visual Studio:

   - Go to Tools > NuGet Package Manager > Package Manager Console.

   Run the following commands:

   ```
   add-migration init
   update-database
   ```

5. **Run the project:**

   You can now run the project. Press F5 or click the Start button in Visual Studio to start the application.

   Alternatively, you can use the command line:

   ```
   dotnet run
   ```

   The application will be accessible at the specified port.

## Technologies Used 🛠️

- ASP.NET Core
- Entity Framework Core
- Razor Pages
- Bootstrap
- C#
- HTML/CSS/JavaScript
- SQL Server

## Project Structure 📁

- `YtBookStore`: Main project directory containing the ASP.NET Core web application.
- `YtBookStore.Models`: Contains domain models for books, authors, genres, publishers, etc.
- `YtBookStore.Repositories`: Contains repository interfaces and implementations.
- `YtBookStore.Controllers`: Contains MVC controllers for handling web requests.
- `YtBookStore.Views`: Contains Razor views for rendering HTML pages.
- `YtBookStore.Migrations`: Contains database migration files.

## Contributing 🤝

Contributions are welcome! Please feel free to submit pull requests or open issues for any bugs or feature requests.

