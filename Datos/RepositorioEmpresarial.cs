using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Datos
{
    public class RepositorioEmpresarial : Archivos, ICrudArchivos<Empresarial>
    {
        public RepositorioEmpresarial(String filename) : base(filename)
        {

        }

        public List<Empresarial> ObtenerTodo()
        {
            try
            {
                StreamReader srE = new StreamReader(ruta);
                List<Entidades.Empresarial> empresarios = new List<Empresarial>();

                while (!srE.EndOfStream)
                {
                    empresarios.Add(Mappear(srE.ReadLine()));
                }
                srE.Close();
                return empresarios;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Empresarial Mappear(String LineaDatosE)
        {
            try
            {
                Entidades.Empresarial Contacto = new Entidades.Empresarial();

                Contacto.Id = int.Parse(LineaDatosE.Split(';')[0]);
                Contacto.Nombre = (LineaDatosE.Split(';')[1]);
                Contacto.Telefono = (LineaDatosE.Split(';')[2]);
                Contacto.Nit = (LineaDatosE.Split(';')[3]);
                Contacto.RazonSocial = (LineaDatosE.Split(';')[4]);
                Contacto.Correo = (LineaDatosE.Split(';')[5]);
                return Contacto;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public bool Actualizar(List<Empresarial> Empresarios)
        {
            try
            {
                StreamWriter srE = new StreamWriter(ruta, false);
                foreach (Empresarial Empresarial in Empresarios)
                {
                    srE.WriteLine(Empresarial.ToString());
                }
                srE.Close();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}