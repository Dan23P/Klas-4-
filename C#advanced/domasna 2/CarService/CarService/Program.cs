// See https://aka.ms/new-console-template for more information
using CarService.Class;

Console.WriteLine("Hello, World!");

Car car = new Car();
Truck truck = new Truck();

car.Drive();
truck.Drive();

CarWash carWash = new CarWash();
GasPump gasPump = new GasPump();
RepairService repairService = new RepairService();
CarCenter carCenter = new CarCenter();

carWash.WashCar();
gasPump.PumpGas();
repairService.CheckVehicle();
repairService.FixVehicle();

carCenter.WashCar();
carCenter.PumpGas();
carCenter.CheckVehicle();
carCenter.FixVehicle();