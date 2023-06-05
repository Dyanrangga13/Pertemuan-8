using System;

namespace pertemuan8_rangga;
public class Program
{
    static void Main(string[] args)
    {
        Console.Write('\n');
        Person person1 = new Person();
        person1.Name = "Dyan rangga saputra";
        person1.Age = 19;
        person1.infoPerson();
        Person person2 = new Person("Rangga", 19);


        Karyawan karyawan1 = new Karyawan();
        karyawan1.karyawanID = 22114864;
        karyawan1.subject = "Dyan Rangga";
        karyawan1.infoKaryawan();

        Karyawan karyawan2 = new Karyawan("Engineering");
    }
}

