
using ProyectoHerencia;

Vehiculo vehiculo = new Vehiculo();
Vehiculo avion= new Avion();
Vehiculo auto = new Coche();


vehiculo.arrancarMotor();
avion.arrancarMotor();
auto.arrancarMotor();

Console.WriteLine("-----------------");

vehiculo.conducir("tierra");
avion.conducir("tierra");
auto.conducir("tierra");

Console.WriteLine("-----------------");

vehiculo.conducir("aire");
avion.conducir("aire");
auto.conducir("aire");

Console.WriteLine("-----------------");
vehiculo.pararMotor();
avion.pararMotor(); 
auto.pararMotor();