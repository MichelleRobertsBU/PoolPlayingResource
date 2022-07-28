# PoolPlayingResource

Overview

An application that connects customers with Venues in the Louisville Area that have pool tables. Businesses will be able to update the size of their tables and cost for use. Customers will be able to search for the venue that best suites their needs. 

Technical Summary

Backend: C#
Framework: ASP.NET Core MVC
ORM: EF Core
Server:
DB: SQL Lite
Front End: HTML/JS/CSS

Pool Playing Resource is my final project for Code Louisville Software Development 2 class. It was created using Visual Studio With an ASP.NET 6.0 MVC Framework. While working on the project I commited to GIT for each update. 

I created a Venue class with several objects, that include VenueName, NumberTables, VenueAddress, TableFee, and TableSize. The data is stored in an SQL Lite database. The information is listed in a Venue index, that allows the information for each Venue to show a detailed view and be created, edited, or deleted. As part of the feature list (1) I have created a list, populated with valutes, and used in the program, (2) My application reads data from an external SQL Lite database and uses the information, (3) I have used the inherited class HomeController that implements interfaces. 

