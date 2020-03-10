using System;
using System.Collections.Generic;
namespace Peli
{
    class Actor
    {
        public string Nombre;
        public int AA;
        // Constructor con parametros
        public Actor(string N, int A)
        {
            Nombre=N;
            AA=A;
        }
    }
    class Peliculas
   {
    public string Titulo, Director, Pais;
    public int Año;

    List<Actor> LA=new List<Actor>();
    public void AgregaActores(Actor NA)
    { 
        // LA- Nombre de lista que agregue NA= Nombre de actores
        LA.Add(NA);
    }
    public void ImprimeLA()
    {
        foreach(Actor NAS in LA)
        {
            //clase Actor, variable NAS, en la lista LA
         Console.WriteLine("{0},{1}", NAS.Nombre, NAS.AA, Titulo);   
        }
    }

    public string getTitulo()
    {
        return Titulo;
    }
    public void setTitulo(string t)
    {
        Titulo=t;
    }
    public string getPais()
    {
        return Pais;
    }
    public void setPais(string p)
    {
        Pais=p;
    }
    public string getDirector()
    {
        return Director;
    }
    public void setDirector(string d)
    {
        Director=d;
    }
    public int getAño()
    {
        return Año;
    }
    public void setAño(int a)
    {
        Año=a;
    }
    public Peliculas()
    {

    }
    public Peliculas(string Titulo, int Año)
    {
        this.Titulo=Titulo;
        this.Año=Año;
    }
    public void Imprime()
    {
    Console.WriteLine("{0}({1})",this.Titulo,this.Año);
    }

   }
  
    class Program
    {
        static void Main(string[] args)
        {
        Peliculas Pelicula1=new Peliculas();
        Peliculas Pelicula2=new Peliculas();

        Pelicula1.setTitulo("Spider-Man");
        Pelicula1.setAño(2004);
        Pelicula1.setDirector("Sam Raimi");
        Pelicula1.setPais("USA");
        
        Pelicula2.setTitulo("Joker");
        Pelicula2.setAño(2019);
        Pelicula2.setDirector("Todd Phillips");
        Pelicula2.setPais("USA");
        
        //Uso de método imprimir 
        Pelicula1.Imprime();
        Pelicula2.Imprime();

        //Lista
        Pelicula1.AgregaActores(new Actor("Tobey Maguire",1976));
        Pelicula2.AgregaActores(new Actor("Joaquin Phoenix", 1972));

        Pelicula1.ImprimeLA();
        Pelicula2.ImprimeLA();       
        } 
    }
}