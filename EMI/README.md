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
