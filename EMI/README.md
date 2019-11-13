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

## Summary
**Architecture**
### Features
**_Technical_**
* To Be Announced

**_Business_**
* The customer is able to make a booking.
* The customer is able to specify a location and see all the available vehicles at the given location.
* The customer can sort which vehicle he/she wants to rent. *(Color, is animals allowed? Type such as Sedan, Sport and so on.)*
* The invoice is generated as a pdf and given to the customer.

### Diagram
**_To Be Announced_**

## Installation
**_To Be Announced_**


# Business case

En kunder ønsker igennem et frontend system at leje en bil. Kunden skal oplyse:

**Customer**
```
Id
First name
Last name
Drivers license
Gender
```
**Car (Hent data fra ekstern kilde?)**
```
Id
License plate
Location
Brand
Model
Color
Doors
Fuel
Type (SUV, Sport, Family)
Price (Range)
Animals (Bool)
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
Pickup(Location, Date, Time)
Dropoff(Location, Date, Time)
```

Overvej at returnere PDF med brugerens indtastede information. Overvej ligeledes at exportere dataen fra DB til CSV filer.
