using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge_WinForm
{
    //TODO: Reemplazar caracteres desconocidos en nombres (letras con tilde). 
    //      Realizar una encapsulacion correcta para proteger los datos sensitivos.
    class MostrarArreglo
    {
        public Form1 f1;
        ArrayList Lista = new ArrayList();
        string[] lineas;

        public MostrarArreglo()
        {

            try
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\db");
                string pather = AppDomain.CurrentDomain.BaseDirectory;
                #if (DEBUG)
                pather = Path.GetFullPath(Path.Combine(pather, @"..\..\"));
                #endif
                lineas = File.ReadAllLines(pather + @"\db\socios.csv");
            }
            catch (Exception de)
            {
                
                Console.WriteLine(de);
                MessageBox.Show("No se ha podido localizar la base de datos.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.Start(AppDomain.CurrentDomain.BaseDirectory + @"\db");
                throw;

            }

        }

        


        public Usuario CrearHincha(int edad, string nombre, string cuadro, string estadoCivil, string estudios)
        {
            Usuario nuevoHincha = new Usuario();
            nuevoHincha.edad = edad;
            nuevoHincha.nombre = nombre;
            nuevoHincha.cuadro = cuadro;
            nuevoHincha.estudios = estudios;
            nuevoHincha.estadoCivil = estadoCivil;
            return nuevoHincha;
        }

        public Equipo CrearEquipo(List<Usuario> miembros, string nombre)
        {
            Equipo nuevoEquipo = new Equipo();
            int nSocios = miembros.Count;
            int edadMenor = 999;
            int edadMayor = 0;
            int edadSum = 0;
            double promedioEdad = 0;



            foreach (Usuario item in miembros)
            {
                edadSum += item.edad;
                if (edadMenor > item.edad)
                {
                    edadMenor = item.edad;
                }

                if (edadMayor < item.edad)
                {
                    edadMayor = item.edad;
                }
            }
            promedioEdad = edadSum / nSocios;

            nuevoEquipo.nSocios = nSocios;
            nuevoEquipo.edadMenor = edadMenor;
            nuevoEquipo.edadMayor = edadMayor;
            nuevoEquipo.nombre = nombre;
            nuevoEquipo.promedioEdad = promedioEdad;
            return nuevoEquipo;
        }

        public void CantidadDatos()
        {
            Console.WriteLine("Cantidad total de personas registradas: " + lineas.Length);
            string titulo = "Cantidad total de personas registradas";
            string[] row0Data = { lineas.Length.ToString() };
            f1.FormatearGDV(1, titulo);
            f1.PopularGDV(row0Data);
        }

        public void PromedioEdadSociosRacin()
        {

            int edad = 0;
            int contSociosRacing = 0;

            foreach (var linea in lineas)
            {
                string[] valores = linea.Split(';');
                if (valores[2] == "Racing")
                {
                    contSociosRacing++;

                    edad = edad + Convert.ToInt32(valores[1]);
                }
            }

            double promedioEdad = (edad / contSociosRacing);
            Console.WriteLine("Edad promedio de los socios de Racing: "+promedioEdad);

            string titulo = "Edad promedio de los socios de Racing";
            string[] row0Data = { promedioEdad.ToString() };
            f1.FormatearGDV(2, titulo);
            f1.PopularGDV(row0Data);
        }

        public void ListadoPersonasCasadasYUniversitarios()
        {

            List<Usuario> hinchas = new List<Usuario>();

            foreach (string linea in lineas)
            {
                string[] valores = linea.Split(';');
                if (valores[3] == "Casado" && valores[4] == "Universitario")
                {
                    hinchas.Add(CrearHincha(int.Parse(valores[1]), valores[0], valores[2], valores[3], valores[4]));
                }
            }

            hinchas = hinchas.OrderBy(z => z.edad).ToList();
            Console.WriteLine("Listado de las 100 primeras personas con estudios universitarios y casadas en orden descendiente de edad\n");
            string titulo = "Listado de las 100 primeras personas con estudios universitarios y casadas en orden descendiente de edad";
            f1.FormatearGDV(3, titulo);

            for (int i = 0; i < 99; i++)
            {            
                Console.WriteLine("Edad: " + hinchas[i].edad.ToString() + " Nombre: " + hinchas[i].nombre + " Equipo: " + hinchas[i].cuadro);
                string[] row0Data = { hinchas[i].edad.ToString() , hinchas[i].nombre, hinchas[i].cuadro };
                f1.PopularGDV(row0Data);
            }
        }

        public void ListaHinchaRiver()
        {
            List<Usuario> hinchasRiver = new List<Usuario>();
            Dictionary<string, List<Usuario>> diccionarioRiver = new Dictionary<string, List<Usuario>>();
            List<Usuario> nombreSumados = new List<Usuario>();

            foreach (string linea in lineas)
            {
                string[] valores = linea.Split(';');
                if (valores[2] == "River")
                {
                    hinchasRiver.Add(CrearHincha(int.Parse(valores[1]), valores[0], valores[2], valores[3], valores[4]));
                }
            }

            foreach (Usuario item in hinchasRiver)
            {
                if (!diccionarioRiver.ContainsKey(item.nombre))
                {
                    diccionarioRiver.Add(item.nombre, new List<Usuario>());
                }

                diccionarioRiver[item.nombre].Add(item);
            }


            foreach (var item in diccionarioRiver)
            {
                nombreSumados.Add(CrearHincha(item.Value.Count, item.Key, "", "", ""));
            }

            nombreSumados = nombreSumados.OrderByDescending(z => z.edad).ToList();

            Console.WriteLine("Listado de los 5 Nombres mas comunes entre los hinchas de river\n");
            string titulo = "Listado de los 5 nombres mas comunes entre los hinchas de river";
            f1.FormatearGDV(4, titulo);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nombre: " + nombreSumados[i].nombre + " || Cantidad de hinchas: " + nombreSumados[i].edad.ToString());
                string[] row0Data = { nombreSumados[i].nombre, nombreSumados[i].edad.ToString() };
                f1.PopularGDV(row0Data);
            }
        }

        public void ListadoCantidadSocios()
        {
            List<Usuario> hinchas = new List<Usuario>();
            Dictionary<string, List<Usuario>> diccionarioEquipos = new Dictionary<string, List<Usuario>>();
            List<Equipo> equipos = new List<Equipo>();

            foreach (string linea in lineas)
            {
                string[] valores = linea.Split(';');

                hinchas.Add(CrearHincha(int.Parse(valores[1]), valores[0], valores[2], valores[3], valores[4]));

            }

            foreach (Usuario item in hinchas)
            {
                if (!diccionarioEquipos.ContainsKey(item.cuadro))
                {
                    diccionarioEquipos.Add(item.cuadro, new List<Usuario>());
                }

                diccionarioEquipos[item.cuadro].Add(item);
            }


            foreach (var item in diccionarioEquipos)
            {
                equipos.Add(CrearEquipo(item.Value, item.Key));

            }

            equipos = equipos.OrderByDescending(z => z.nSocios).ToList();

            Console.WriteLine("Datos de edades de los socios en los clubes\n");
            string titulo = "Datos de edades de los socios en los clubes";
            f1.FormatearGDV(5, titulo);
            foreach (Equipo item in equipos)
            {
                Console.WriteLine("Equipo: " + item.nombre + " || Numero de Socios: " + item.nSocios + " || Promedio de edades: " + item.promedioEdad + " || Menor edad registrada: " + item.edadMenor + " || Mayor edad registrada: " + item.edadMayor + "\n");
                string[] row0Data = { item.nombre, item.nSocios.ToString(), item.promedioEdad.ToString(), item.edadMenor.ToString(), item.edadMayor.ToString()};
                f1.PopularGDV(row0Data);
            }


        }
    }
}
