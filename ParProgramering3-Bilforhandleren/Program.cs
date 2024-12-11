/*1) Bilforhandleren
 * En bilforhandler har ulike biler i shappa si, det kan være biler med ulike merker, årsmodell, registreringsnummer og kilometerstand.
 * Når kunden kommer inn i shappa skal han kunne se hvilke biler som finnes i shappa, eller han kan velge å finne en bil ut fra årsrange, eller en bil som har kjørt mer eller mindre enn en gitt kilometerstand. 
 * Kunden skal også ha mulighet til å kjøpe en av bilene. Bilen må da tilhøre kunden og ikke forhandleren.
 */
using ParProgramering3_Bilforhandleren;


Person person1 = new Person("Robin");
Person BilForhandler = new Person("Forhandler");
List<Car> cars = new List<Car>();
cars.Add(new Car("Mini", 63000, "BS80123", "2013", 100000, "Forhandler", 1));
cars.Add(new Car("BMW", 43000, "BS80124", "2015", 200000, "Forhandler", 2));
cars.Add(new Car("Mercedes", 90000, "BS80125", "2010", 150000, "Forhandler", 3));
cars.Add(new Car("Fiat", 200000, "BS80126", "2006", 20000, "Forhandler", 4));

bool ShowMenu()
{
    Console.WriteLine("Tast 1 for å se alle biler, tast 2 for å se biler etter KM stand, tast 3 for å kjøpe en bil");
    Console.WriteLine("Tast 4 for å se dine biler, tast 5 for å avslutte");
    var input = Console.ReadKey();
    Console.WriteLine();
    if (input.KeyChar == '1')
        foreach (var car in cars)
        {
            Console.WriteLine(car._brand);
        }
    else if (input.KeyChar == '2')
    {
        var carsByKM = cars.OrderBy(car => car._km);

        foreach (var car in carsByKM)
        {

            Console.WriteLine("Bil: " + car._brand + " KM: " + car._km);
        }
    }


    else if (input.KeyChar == '3')
    {
        Console.WriteLine("Tast en ID for å kjøpe bilen");
        foreach (var car in cars)
            Console.WriteLine("Bilen " + car._brand + " har ID " + car._id);
        string input1 = Console.ReadLine();
        Console.WriteLine();

        foreach (var car in cars)
            if (int.Parse(input1) == car._id)
                car.Purchase(person1);
    }
    else if (input.KeyChar == '4')
    {
        Console.WriteLine(person1._name + " eier bilene: ");
        foreach (var car in cars)
        {
            if (car._owner == person1._name)
                Console.WriteLine(car._brand);
        }
    }
    else if (input.KeyChar == '5')
        return false;

    return true;

}





bool myBool = true;
while (myBool)
myBool = ShowMenu();