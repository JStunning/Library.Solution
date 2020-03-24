# Library

#### _Library C# app, mm/dd/yyyy_

#### By _**Jack Dunning**_

## Description

_Description._

## Setup/Installation Requirements

* _Download .NET from here: https://dotnet.microsoft.com/download/dotnet-core/current_
* _Download .NET script in the Terminal with this command { dotnet tool install -g dotnet-script }_
* _Download MySQL from here: https://dev.mysql.com/downloads/_
  * _In MySQL_
    * CREATE DATABASE to_do_list;
    * USE to_do_list;
    * CREATE TABLE categories (CategoryId serial PRIMARY KEY, Name LONGTEXT);
    * CREATE TABLE categoryitem (CategoryItemId serial PRIMARY KEY, ItemId Int, CategoryId INT);
    * CREATE TABLE items (ItemId serial PRIMARY KEY, Description LONGTEXT);
* _Git clone Or download the zip file from gihub { https://github.com/JackStunning/HairSalon.Solution }_
* _In the Terminal run this command { dotnet build }_
* _In the Terminal run this command { dotnet run }_

## Specs

  * _Spec:_ When user opens localhost:5000.
      * _Input:_ user opens web app
      * _Output:_ homepage should open "Welcome to the TodoList!" and also give you a link "See TodoList"

## Known Bugs

_No none bugs_

## Support and contact details
 
_Email: JackStunning9001@gmail.com_

## Technologies Used

_C#, .NET, MSTest, MySQL, Html, Bootstrap_

### License

*Copyright (c)

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN*

Copyright (c) 2020 **_Jack Dunning_**