using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Contracts;

namespace Datos
{
    public class Archivos
    {
        protected string ruta;

        public Archivos()
        {
            ruta = "Contactos.txt";
        }

        public Archivos(String fileName)
        {
            ruta = fileName;
        }

        public bool Guardar(Entidades.Persona Contacto)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, true);
                sw.WriteLine(Contacto.ToString());
                //sw.WriteLine(Contacto);
                sw.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
