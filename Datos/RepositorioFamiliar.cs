using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Datos
{
    public class RepositorioFamiliar : Archivos, ICrudArchivos<Familiar>
    {
        public RepositorioFamiliar(String filename) : base(filename)
        {
            
        }

        public List<Familiar> ObtenerTodo()
        {
            try
            {
                StreamReader srF = new StreamReader(ruta);
                List<Entidades.Familiar> familiares = new List<Familiar>();

                while (!srF.EndOfStream)
                {
                    familiares.Add(Mappear(srF.ReadLine()));
                }
                srF.Close();
                return familiares;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Familiar Mappear(String LineaDatosF)
        {
            Entidades.Familiar Contacto = new Entidades.Familiar();

            Contacto.Id = int.Parse(LineaDatosF.Split(';')[0]);
            Contacto.Nombre = (LineaDatosF.Split(';')[1]);
            Contacto.Telefono = (LineaDatosF.Split(';')[2]);
            Contacto.FechaNacimiento = Convert.ToDateTime(LineaDatosF.Split(';')[3]);
            return Contacto;
        }

        public bool Actualizar(List<Familiar> Familiares)
        {
            try
            {
                StreamWriter srF = new StreamWriter(ruta, false);
                foreach (Familiar Familiar in Familiares)
                {
                    srF.WriteLine(Familiar.ToString());
                }
                srF.Close();

                return true;
            }
            catch (Exception)
            {

                return false; ;
            }
        }

    }
}