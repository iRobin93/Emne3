/*
 * Lage klassen vehicle.
 * lage subklassene - car, plane, boat 
 * lage metodene - run, print info og compare
 *
 * 
 * 
 * 
 * 
 * 
 */



using AbaxRekruttering;

Car car = new Car(200, "grønn", "lett kjøretøy", "NF123456", 147);
Car car2 = new Car(195, "blå", "lett kjøretøy", "NF654321", 150);
Plane plane1 = new Plane("LN1234", 1000, 30, 2, 10, "JetPlane");
Boat boat = new Boat("ABC123", 100, 30, 500);


//boat.CompareVehicle(boat);
car.PrintInfo();
car2.PrintInfo();
car.CompareVehicle(car2);
plane1.PrintInfo();
plane1.Run();
car.Run();
boat.PrintInfo();