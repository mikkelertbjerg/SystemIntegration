# System Integration Mini Project EIP
The main objective of this task is to get practical experience in implementing best practices for integrating enterprise applications by use of integration platforms and middleware.

## Group Members
*Nikolai Christiansen*  
*Mikkel Ertbjerg*  
*Nikolaj Dyring*



## Tech Used
* **gRPC with .Net Core**
* **MySQL Database** *(hosted at Unoeuro.com)*
* **RabbitMQ**
* **MySQL Workbench CE** *(for filling dummy data into the table by using a .csv file)*
* **IronPFD** *(For creating PDF files)*

## Summary
**Architecture**
![Architecture](https://github.com/mikkelertbjerg/SystemIntegration/blob/master/EMI/Diagrams/Architecture.png)

### Features

**_This program features a backend powered by GRPC_**


**Patterns**
* File Transfer
* Command Message
* Message
* Facade


**_Business_**
* The customer is able to make a booking.
* The customer is able to specify a location and see all the available vehicles at the given location.
* The customer can sort which vehicle he/she wants to rent. *(Color, is animals allowed? Type such as Sedan, Sport and so on.)*
* The invoice is generated as a pdf and given to the customer.

### Diagrams
**BPMN Diagram**

![BPMN Diagram](https://github.com/mikkelertbjerg/SystemIntegration/blob/master/EMI/Diagrams/BPMN_Diagram.png)

**Domain Model**

![Domain Model](https://github.com/mikkelertbjerg/SystemIntegration/blob/master/EMI/Diagrams/DomainModelBE.png)

**Database Diagram**

![Database Diagram](https://github.com/mikkelertbjerg/SystemIntegration/blob/master/EMI/Diagrams/DatabaseDiagram.png)

## Installation
**_Dependencies_**
* RabbitMQ

Run the "Program.cs" file.

Ultimately when the services a running, a client could hook up to the gRPC service, and call the exposed methods.
The Client needs to implement the "Booking.Proto" file in order to get the desired results.


# Business case

A Customer wishes, through a frontend system, to rent a car, the customer needs to provide the following information:

**Customer**
```
Id
First name
Last name
Drivers license
Gender
```
**Car**
```
Id
License plate
Pickup location
Dropoff location
Brand
Model
Color
Doors
Fuel type
Car type 
Price
Animals
```
**Location**
```
Id
Address
City
Zip code
Country
```
**Booking**
```
Id
Customer
Car
Pickup Location
Dropoff Location
Pickup Time
Drop off Time
```
