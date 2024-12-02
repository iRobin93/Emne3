using Studentadministrasjonssystem;


Student student1 = new Student("Robin", 30, "Programmering", "30Fc");
Student student2 = new Student("Ole Morten", 63, "Programmering", "30Fd");
Fag fag1 = new Fag("ProgramFag101", "Programmering", 20);
Fag fag2 = new Fag("GUI100", "GUI", 30);
Fag fag3 = new Fag("Backend101", "Backend", 25);
//Karakter karakter1 = new Karakter(student1, fag1, 3);
//Karakter karakter2 = new Karakter(student2 , fag2, 3);

List<Fag> fags = new List<Fag>();
fags.Add(fag1);
fags.Add(fag2);
fags.Add(fag3);


student1.Fagliste = new List<Fag>();
student2.Fagliste = new List<Fag>();
foreach (Fag fag in fags)
{
    student1.Fagliste.Add(fag);
    student2.Fagliste.Add(fag);
}

int i = 3;
foreach(Fag fag in student1.Fagliste)
{
    Karakter.karakterer.Add(new Karakter(student1, fag, i));
    i++;
}
i = 2;
foreach(Fag fag in student2.Fagliste)
{

    Karakter.karakterer.Add(new Karakter(student2, fag, i));
    if (i == 2)
        i++;
    i++;
}





student1.writeInfo();
student2.writeInfo();
fag1.writeInfo();
fag2.writeInfo();
foreach (Karakter karakter in Karakter.karakterer)
{
    karakter.writeInfo();
}

Console.WriteLine($"Navn: {student1.GetName()} sin gjennomsnittskarakter er: " + student1.GetMean());
Console.WriteLine($"Navn: {student2.GetName()} sin gjennomsnittskarakter er: " + student2.GetMean());