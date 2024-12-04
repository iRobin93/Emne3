using NyreTransplantasjon;


Person person1 = new Person("Bernt", 25, new Nyre("Nyre1Bernt", 0), new Nyre("Nyre2Bernt", 0));
Person person2 = new Person("Kåre", 26, new Nyre("Nyre1Kåre", 100), new Nyre("Nyre2Kåre", 100));

Console.WriteLine("Før Transplantasjon");
person1.WriteInfo();
person2.WriteInfo();


bool success = person1.Transplantasjon(person2);
Console.WriteLine("Transplantasjon var vellykket: " + success);

Console.WriteLine("Etter Transplantasjon");
person1.WriteInfo();
person2.WriteInfo();


Console.WriteLine("");
Console.WriteLine("Press enter to exit");
Console.ReadLine();
