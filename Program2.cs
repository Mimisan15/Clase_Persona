using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca;

namespace programa2 {
    public class Program {
        static void Main (string [] args) {
            Persona p= new Persona("Cacho");
            p.edad = 25;
            p.comer("Ensalada");
            p.morir();
            Console.WriteLine(p.edad);
            Console.WriteLine(p.vive);
        }
    }
}