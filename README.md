# _Eau Claire's_

<h1 align="center">
  <img width="500" height="350" src="HairSalon/wwwroot/img/NeonLightHairSalon.png">
</h1>


#### _An MVC Application to help an owner manage their Salon, 7.31.20_

#### By _**Taylor Phillips**_

<br>

## Description

_This is an application to help a salon owner manage and keep track of their stylists and the clients that belong to each stylist.  Each Stylist will have their own page where their specialty and their list of clients will be shown.  The user will have the abiliy to add new stylists and clients when needed_

<br>

## Specifications

| Spec | Input | Output |
| :--- | :---: | ---: |
| User will be first directed to the homepage where they can select to see a list of stylists at the salon  |   |   |
| On the stylists page, User can select a specific stylist to see their specialty and a list of their clients |   |   |
| User is able to return to the homepage from multiple pages  |   |     |
| New Stylists can be added, as well as new Clients, and Clients will need to have specified Stylist that they are Client for |     |     |


<br>

## Software/Installation Requirements
* Install [Git v2.62.2+](https://git-scm.com/downloads/)
* Install [.NET version 3.1 SDK v2.2+](https://dotnet.microsoft.com/download/dotnet-core/2.2)
* Install [Visual Studio Code](https://code.visualstudio.com/)
* Install [MySql Workbench](https://www.mysql.com/products/workbench/)


## Setup 💻

Copy this url to clone this project to your local system using computer's Command Line terminal: 
```https://github.com/tayphill13/EauClaireSalon.Solution.git```

If you wish to edit the code base: Open the project in your code editor; with Bash, this is done by navigating to the project directory `cd EauClaireSalon.Solution`, then `code .`


## Database Setup/Migration

* Run MySQL by entering ```mysql -uroot -pepicodus``` in the terminal (In this example, 'epicodus' is the password, so if the word `password` was your password then you'd have ```msql -uroot -ppassword```)
* Directly import the file taylor_phillips.sql file included in the project into your SQL management tool.
* You can use the SQL query below in your SQL management tool to execute the schema creation yourself:

```
DROP DATABASE IF EXISTS `taylor_phillips`;
CREATE DATABASE `taylor_phillips`;

USE `taylor_phillips`;

CREATE TABLE `Clients` (
  `ClientId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `StylistId` int DEFAULT NULL,
  PRIMARY KEY (`ClientId`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `Stylists` (
  `StylistId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Specialty` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
```

* If you are using mysql workbench then the database can be generated by importing `taylor_phillips.sql` located in the `EauClaireSalon.Solution` directory.
* This can be found in the MySql Workbench `Server` menu as `Data Import`, then choose `Import from Self-Contained File`.  Use the browsing tool to select the `taylor_phillips.sql` file that is included with the project and finally select `Start Import`.

[![Image from Gyazo](https://i.gyazo.com/96703b1a98bb5bb1680a403575780910.gif)](https://gyazo.com/96703b1a98bb5bb1680a403575780910)
* Within the project file, `appsettings.json` you will need to be sure that the password (pwd) matches the password that you are using for your MySql Workbench.

### Running the program:
1. In your command line terminal, type `cd Desktop` then navigate to project folder using `cd EauClaireSalon.Solution`
2. To run the program, you'll need navigate to the project folder by entering `cd HairSalon`, then to compile the code enter: `dotnet restore`. This will create a compiled application in the bin/ folder.  Do not touch the files in the bin/ or obj/ folders, you will not need to and the application will not run as intended.
3. You can then run the program directly with `dotnet run` while still within the HairSalon directory.

<br>

## Known Bugs

_No known bugs_

<br>

## Support and contact details

_Please reach out through my GitHub account._

<br>

## Technologies Used

_**Written in:** [Visual Studio Code](https://code.visualstudio.com/)_

_**Database Mgmt:** [MySql Workbench](https://www.mysql.com/products/workbench/)_

_Using C# and .Net Core_

_This was completed using MacOS_

<br>

### License

Copyright (c) 2020 **_Taylor Phillips_**   
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

*Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:*

*The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.*

*THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.*