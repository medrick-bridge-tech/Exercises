# Exercise: Vehicle Racing Game

## Background:
You are developing a racing game that features various types of vehicles. Each vehicle has common characteristics, but different types of vehicles may have unique attributes and behaviors.

## Requirements:

### Vehicle Class:

Create a base class called Vehicle with the following attributes and methods:

**Attributes**
- **brand**: The brand or make of the vehicle.
- **speed**: The current speed of the vehicle in kilometers per hour.
- **fuel**: The remaining fuel level in liters.

**Methods**
- Constructor to initialize the vehicle with a brand, speed, and fuel level.
- A method to increase the speed of the vehicle.
- A method to decrease the speed of the vehicle.
- A method to refuel the vehicle.

### Car Class:

Create a class called Car that inherits from the Vehicle class.

**New attribute**
- **doorCount**: The number of doors on the car.
**New method**
- A method representing the car honking its horn.

### Motorcycle Class:

Create a class called Motorcycle that also inherits from the Vehicle class.

**New attribute**
- **HasSideCar**: Indicates whether the motorcycle has a sidecar.

**New method**
- A method representing the motorcycle performing a wheelie.

### Interface:

**Create an interface called Drivable with methods**
- SteerLeft: This method should be implemented by any class that wants to steer left.
- SteerRight: This method should be implemented by any class that wants to steer right.


**Implement the Interface**
Make the Car and Motorcycle classes implement the Drivable interface. The steer_left and steer_right methods should print messages indicating the vehicle is steering left or right.
