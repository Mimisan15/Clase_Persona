using System;
namespace Biblioteca {
    class Persona {
        //Atributos
        public string nombre;
        public string apellido;
        public int edad;
        public bool vive;

        //Ahora voy a crear mi constructor
        public Persona(){
            vive = true;
        }
        public Persona(string pNombre){
            nombre = pNombre;
            vive = true;
        }
        ~Persona(){
            Console.WriteLine("Programa terminado se ejecutó el destructor");
        }
        public void caminar(){}
        public void comer(string tipoComida){
            Console.WriteLine("Comiendo {0}", tipoComida);
        }
        public void morir(){
            Console.WriteLine("se murió {0}", nombre);
        }
    }
}
