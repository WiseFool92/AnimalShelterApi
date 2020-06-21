# _Animal Shelter Api_

#### June 12th, 2020

## Description

_This application is an Animal Shelter Api_

_This application is meant to be viewed in the browser & connected to a database which holds the shelter information. It will need a .NET Core Sdk 3.1 or 2.2 & ASP.Net 3.1 or 2.2 download. It will need a mysql workbench 8.0 to be connected to it_

_This application is Swagger & CORS ready. With progress towards token authentication and userlogin. I didn't get to fininsh updating the startup file to be functional for Tokens & login_

## Setup/Installation Requirements

_Make sure you have [git version control](https://git-scm.com/downloads) installed on your computer._

1. Click the green 'Clone or Download' button and copy the link / download the zip
2. Open terminal and type... or skip to #4 if you downloaded the zip

**Windows**

```sh
cd desktop
```

Mac & linux

```sh
cd ~/Desktop
```

3.  in terminal type '_git clone {link to repository}_ '

```sh
git clone {link to repository}
```
4. If you downloaded the zip then extract all onto your desktop
5. Open the folder with VSC or an equivalent
6. Install .NET Core using <a href="https://docs.microsoft.com/en-us/dotnet/core/install/runtime?pivots=os-windows">this</a> link
7. Then Run the code below in the terminal to confirm installation
```sh
dotnet -- version
```  
8. In the terminal enter to confirm the proper version installed 
```sh
dotnet tool install -g 
dotnet-script
```
9. Download _[ASP.NET Core](https://dotnet.microsoft.com/download)_ To enable live viewing on a local server
10. You will need to create a file in the root directory of the project run in powershell 
```sh
new-item appsettings.json
```
11. Once created populate this file with
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=your_database_name;uid=root;pwd=YourSqlWorkBenchPassword;"
  }
}
11. Open project, navigate to the containing folder of the project & Run the code below to confirm build stability
```sh
dotnet run build 
```
12. Within that same containing folder Run _dotnet watch run_ To open a live server w/auto updated viewing
13. If you want to run tests navigate to the .tests containing folder and enter
```sh
dotnet test
```
14. Enjoy

## ReCreating MySql Database 
(Setup my vary slightly from system to system)

1. Open MySql Community Installer and reconfigure (legacy password, uncheck windows services)
2. Open MySql Workbench
3. Use Migrations to seed & populate data 
```sh
dotnet ef database update
```

## Specs

### Behavior Driven Development Spec List
#### Animal Shelter Api
|                          Behavior                          | Input  | Output  |
| :--------------------------------------------------------: | :----: | :-----: |
| The user can GET animal information | 'http://localhost:5000/api/Animal' | 'List of animals' |
| The user can POST data sheets about animlas at the shelter | 'http://localhost:5000/api/Animals' | 'Populate a data sheet' |
| The user can GET by Id | '/api/Animal/{id}' | 'Returns animal with matching ID' |
| The user can Edit the animals via PUT request | '/api/Animal/{id}' | 'Edits animal w/matching Id' |
| The user can DELETE an animal bio | 'http://localhost:5000/api/animals/{id}' | 'Deletes bio' |
| Swagger UI endpoint for further exploration @ /index.html


---
## Known Bugs

_N/A_ - 6/12/2020

## gh-pages

WiseFool92.github.io/AnimalShelterApi

## Support

_Email: watkins92@gmail.com_

---
## Built With

- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1)
- [MSTest](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest)

## Useful tools

- [free icons @ icons8](https://icons8.com/)
- [free icons @ fontawesome](https://fontawesome.com/)

---

- [Old School Gifs Search](https://gifcities.org/)
- [free images @ unsplash](https://unsplash.com/)

  - **_source.unsplash.com_ will return a random image at a desired size by simply calling the size after the url followed by a '?' and a keyword. Example below**

  - _https://source.unsplash.com/400x400/?cat_
  - http://unsplash.it/500/500 - This will just return a random image the size of 500x500

---

- [Flex-box Cheat Sheet](http://yoksel.github.io/flex-cheatsheet/)
- [CSS Grid Cheat Sheet](http://grid.malven.co/)

---

- [CSS Gradient BG Generator](https://mycolor.space/gradient)
- [CSS Basic Gradient Generator](https://cssgradient.io/)

---

- [CSS Dropshadow Generator](https://cssgenerator.org/box-shadow-css-generator.html)

### License

This project is licensed under the MIT License

Copyright (c) 2020 **_Nathan Watkins-Hoagland_**
