using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Studentadministrasjonssystem
{
    internal class Karakter
    {
        public static List<Karakter> karakterer = new List<Karakter>();
        public Student _student {  get; private set; }
        private Fag _fag;
        public int _karakter {  get; private set; }
        
        public Karakter(Student Student, Fag Fag, int karakter)
        {
            _student = Student;
            _fag = Fag;
            _karakter = karakter;
        }
        public void writeInfo()
        {
            Console.WriteLine($"Student: {_student.GetName()}\n Fag: {_fag.GetName()} Karakter: {_karakter}");
        }

        
    }
}
