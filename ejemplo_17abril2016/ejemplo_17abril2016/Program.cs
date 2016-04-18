using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_17abril2016


{
    interface IImprimible {

        void imprime();
        void imprime(int n);
    }






    //SE CREA CLASE USUARIO QUE IMPLEMENTA INTERFAZ COMPARABLE
    class Usuario:IComparable, IImprimible
    {
        public string nombre, correo;
        public Usuario(string n, string c) { this.nombre = n; this.correo = c; }

        //para darle formato a lo que se va a imprimir
        public override string ToString()
        {   //nombre y correo
            return string.Format("{0}:{1}", this.nombre, this.correo);
            //si se quiere solo nombre :                        return  this.nombre;
        }


        //ESTO ES COMPLEMENTO DE LA INTERFAZ COMPARABLE, ES LO QUE ORDENA
        public int CompareTo(object o) 
        {
            //casting: para que la variable o haga referencia a usuario y se ordene por nombre
            return this.nombre.CompareTo(((Usuario) o).nombre);


            //tambien se puede hacer asi
            //USuario usr=(Usuario) o;
            //return this.nombre.CompareTo(usr.nombre );
            
        }



        public void imprime()
        {
            throw new NotImplementedException();
        }

        public void imprime(int n)
        {
            throw new NotImplementedException();
        }
    }

    class Program

    {

        //se crea un lista de nombres
        static List<Usuario> usuarios = new List<Usuario>();
        static void Main(string[] args)
        {
            //se agregan los usuarios
            usuarios.Add(new Usuario("Alan", "roxkstar@gmail.com"));
            usuarios.Add(new Usuario("johana", "caramel43@gmail.com"));
            usuarios.Add(new Usuario("Laura", "latinhot@gmail.com"));
            usuarios.Add(new Usuario("Maria", "zoe1223@gmail.com"));
            usuarios.Add(new Usuario("Ana", "Ana@gmail.com"));
            //SE IMPRIMEN LOS NOMBRES DE USUARIOS DESORDENADOS
            Console.WriteLine("Desordenados");
            foreach (Usuario u in usuarios)
            {
                Console.WriteLine(u);
            }

            //SE IMPRIMEN LOS NOMBRES DE USUARIOS ORDENADOS
            Console.WriteLine("Ordenados");
            usuarios.Sort();
            foreach (Usuario u in usuarios)
            {
                Console.WriteLine(u);
            }




            Console.ReadKey();

        }




    }
}
