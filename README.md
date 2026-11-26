# .NET and Database Coursework

ITAM coursework on Windows desktop application development, relational databases, C# class libraries, and Excel automation.

| Folder | Contents |
| --- | --- |
| [Student records](student-records/SistemaAlumnos/) | A C# and WPF desktop app for adding, finding, updating, and deleting records in SQL Server. |
| [Ride-sharing SQL](ride-sharing-sql/) | SQL scripts and the original assignment for modeling a ride-sharing database. |
| [.NET libraries](dotnet-libraries/) | C# class-library exercises and a WPF application that loads one of the libraries. |
| [Excel automation](excel-automation/) | A Windows Excel interop exercise and practice workbooks, including a macro-enabled workbook. |
| [Desktop exercises](desktop-exercises/) | SmartCalc, a matrix calculator, and a separate student-records coursework variant. |
| [Exam practice](exam-practice/Repaso2/) | Applicant registration in WPF and a payroll example in ASP.NET Web Forms. |
| [Web Forms exercises](web-forms/) | Video-game examples and exercises in controls, cookies, and sessions. |

## Build and explore

The C# projects target .NET Framework 4.7.2. Use Windows with Visual Studio or Visual Studio Build Tools and the .NET Framework 4.7.2 targeting pack. From a Developer Command Prompt, build the student project with:

~~~cmd
msbuild student-records\SistemaAlumnos\SistemaAlumnos.csproj /t:Build
~~~

The student app reads its SQL Server connection from the project’s App.config settings. The checked-in example uses Windows authentication and LocalDB. Configure a local database with the schema expected by the project’s dataset before testing student-record operations.

Build pruebaDll1 in Debug before building EjecutaPruebaDLL1, which references that build output. The Excel interop project requires desktop Excel and the Office COM references declared in its project file. Review the macro-enabled workbook before enabling macros.

The ride-sharing scripts are independent from the student app. Review them before executing them against a disposable SQL Server database.

## Additional Windows exercises

Open the original solution for each exercise. For SmartCalc, use [SmartCalc.sln](desktop-exercises/SmartCalc/SmartCalc.sln). The [student-records variant](desktop-exercises/SistemaAlumnos/) is separate from the app in student-records. It includes different record handling and form code.

ASP.NET Web Forms projects require the Visual Studio web build tools and a NuGet restore. The payroll and video-game examples read local ODBC connection strings from COURSEWORK_PAYROLL_ODBC and COURSEWORK_VIDEOGAMES_ODBC, respectively. Set them for a disposable local database and use the appropriate ODBC driver. The desktop database exercises use their App.config settings with a LocalDB example. Treat these as local coursework demos.
