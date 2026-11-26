# .NET Application Development Coursework

Exercises from ITAM’s application development coursework. The projects cover C# desktop applications, ASP.NET Web Forms, relational databases, class libraries, and Excel automation.

## Project index

| Project | What it does | Setup |
| --- | --- | --- |
| [SmartCalc](desktop/smart-calculator/SmartCalc.sln) | A WPF calculator with a dynamically created interface. | WPF |
| [Matrix calculator](desktop/matrix-calculator/matrixCalc.sln) | A WPF exercise for working with matrices. | WPF |
| [Sistema Alumnos](desktop/student-records/original/SistemaAlumnos.csproj) | Adds, searches for, updates, and deletes student records. Start with this version. | WPF, SQL Server |
| [Sistema Alumnos coursework variant](desktop/student-records/coursework-variant/SistemaAlumnos/SistemaAlumnos.sln) | A separate version with different record-handling and form code. | WPF, SQL Server |
| [Applicant registration](desktop/applicant-registration/RegistroAspirantes.sln) | A desktop exercise for registering applicants and generating a report. | WPF, SQL Server |
| [Payroll](web-forms/payroll/Sueldo.sln) | Payroll entry and reporting pages. | Web Forms, ODBC |
| [Video games](web-forms/video-games/videojuegos.sln) | A set of database-backed pages for a video game exercise. | Web Forms, ODBC |
| [Video games lab](web-forms/video-games-lab/videojuegos/videojuegos.sln) | A separate lab version of the video game exercise. | Web Forms, ODBC |
| [Web controls](web-forms/controls/usoControles/usoControles.sln) | Exercises using server-side form controls. | Web Forms |
| [Sessions and cookies](web-forms/sessions-and-cookies/PruebaSessionCookies.sln) | Exercises in maintaining state with sessions and cookies. | Web Forms |
| [Ride-sharing SQL](databases/ride-sharing/) | SQL scripts and an assignment for modeling a ride-sharing database. | SQL Server |
| [Class library 1](libraries/pruebaDll1/pruebaDll1.sln) and [class library 3](libraries/pruebaDll3/pruebaDll3.sln) | Standalone exercises in building C# DLLs. | .NET Framework |
| [DLL demo](libraries/EjecutaPruebaDLL1/EjecutaPruebaDLL1.sln) | A WPF application that uses the first class library. | WPF, Class library 1 |
| [Excel interop](excel/prubeaDll2/prubeaDll2.sln) and [workbooks](excel/Excel/) | An Office interop exercise and Excel practice files, including macros. | Desktop Excel, Office COM |

## Build and run on Windows

Use Visual Studio or Visual Studio Build Tools with the **.NET Framework 4.7.2 targeting pack**. Open a solution above in Visual Studio, or run MSBuild from a Developer Command Prompt at the repository root. For example:

~~~cmd
msbuild desktop\smart-calculator\SmartCalc.sln /t:Build
~~~

- **Desktop database apps:** Configure the local database in each project’s App.config. The examples use Windows authentication with LocalDB. Use the dataset definitions as a schema reference.
- **Web Forms:** Install the Visual Studio web build tools and restore the solution’s NuGet packages. For local database exercises, set `COURSEWORK_PAYROLL_ODBC` or `COURSEWORK_VIDEOGAMES_ODBC` with a connection string for a disposable database and the appropriate ODBC driver.
- **DLL demo:** Build Class library 1 in Debug first. The demo references that output by relative path.
- **Excel interop:** Use desktop Excel and the Office COM references the project declares. Review macro-enabled workbooks before enabling macros.
- **SQL scripts:** Read the assignment and scripts before running them in a disposable SQL Server database.

The folder and solution paths were checked. Building and running the exercises requires the tooling and local databases described above.
