### Epicodus Independent Code Review - Basic Web Applications

### By Collin Chapman

## Technologies Used

* Git
* C#
* .NET 5.0
* ASP.NET Core
* Razor View Engine
* MVC
* MSTest
* RESTful Routing & CRUD

## Description

This is a C# MVC application for Pierre's Bakery. This application will help Pierre track the vendors that purchase baked goods from him and the orders belonging to those vendors. 

* The homepage is a splash page welcoming Pierre and providing him with a link to a Vendor's page
* The vendor's page will contain a link to a page presenting Pierre with a form he can fill out to create a new Vendor object
* After the form is submitted, the new Vendor object will be saved into a static List and Pierre will be routed back to the homepage
* Pierre is able to click a vendor's name and go to a new page that will display all of their orders
* Pierre will be provided a link to a page presenting him with a form to create a new order for a particular vendor

## Setup/Installation Requirements

* _Open the terminal on your local machine_
* _Navigate to the directory inside of which you wish to house this project_
* _Clone this project with the following command  `$ git clone <https://github.com/colchapm/VendorTracker.Solution.git>`_
* _Navigate to the test level of the repository with the command `$ cd VendorTracker.Tests`_
* _Retrieve and install packages listed in the .csproj files with the command `$ dotnet restore`_
* _Compile and run the application with the command `$ dotnet test`_
* _Navigate to the root level of the repository with the command `$ cd VendorTracker`_
* _Retrieve and install packages listed in the .csproj files with the command `$ dotnet restore`_
* _Run and launch the application with the command `$ dotnet run`_

## Specificatons

| Behavior | Input | Output |
|:---: |:---:|:---:|
| The program should successfully create a Vendor object | When it instantiates a new Vendor object | Return type Vendor |
| The program should properly get the value of a property of the Vendor | When it uses a getter method | Return name of Vendor |
| The program should successfully alter the value of a property of the Vendor | When it uses a setter method | Return updated description of the Vendor |
| The program should successfully create a list of Vendors | When it declares a static variable to the class called _instances | Return an empty Vendor list |
| The program should successfully create a list of Vendors | When it declares a static variable to the class called _instances | Return a list of all created Vendor objects |
| The program should successfully assign a unique ID number to each Vendor | When it instantiates a new Vendor and uses a Getter method | Return Id of 1 |
| The program should successfully locate specific Vendors based on their unique Id  | When it calls a static Find method | Return Id of 2 |

## Known Bugs

No known bugs at this time 

## Link

This project is not hosted on GitHub Pages

## License

Copyright (c) 2021 Collin Chapman

This software is licensed under the MIT license

## Contact Information

cchap14@gmail.com