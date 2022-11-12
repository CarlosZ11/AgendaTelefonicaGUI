using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class ServicioContactosEmpresariales : IServicios<Empresarial>
    {
        List<Empresarial> empresariales;
        RepositorioEmpresarial repositorioEmpresarial;

        public ServicioContactosEmpresariales()
        {
            repositorioEmpresarial = new RepositorioEmpresarial("Contactos_Empresariales.txt");
            empresariales = repositorioEmpresarial.ObtenerTodo();
        }

        public string Borrar(Empresarial contacto)
        {
            empresariales.Remove(contacto);
            repositorioEmpresarial.Actualizar(empresariales);
            Refresh();
            return $"el contacto se elimino correctamente con el nombre {contacto.RazonSocial}";
        }

        void Refresh()
        {
            empresariales = repositorioEmpresarial.ObtenerTodo();
        }

        public string Editar(Empresarial oldContacto, Empresarial UpdateContacto)
        {
            //oldContacto.Id = UpdateContacto.Id;
            oldContacto.Nombre = UpdateContacto.Nombre;
            oldContacto.Telefono = UpdateContacto.Telefono;
            oldContacto.RazonSocial = UpdateContacto.RazonSocial;
            oldContacto.Correo = UpdateContacto.Correo;
            var estado = repositorioEmpresarial.Actualizar(empresariales);
            Refresh();

            return estado ? $"se actulizo el contacto {UpdateContacto.RazonSocial}" :
                $"ERROR al actulizar el contacto {UpdateContacto.RazonSocial}";
        }

        public string Guardar(Empresarial contacto)
        {
            if (ObtenerPorTelefono(contacto.Telefono) != null)
            {
                return $"el contacto ya existe con este numero de telefono {contacto.Telefono}";
            }
            var estado = repositorioEmpresarial.Guardar(contacto);

            Refresh();

            return estado ? $"el contacto se agrego correctamente con el nombre {contacto.Nombre}" :
                                 $"ERROR al Guardar el contacto con el nombre {contacto.Nombre}";
        }

        public List<Empresarial> ObtenerTodo()
        {
            return empresariales;
        }

        public Empresarial ObtenerPorTelefono(string phone)
        {
            foreach (var item in empresariales)
            {
                if (item.Telefono == phone)
                {
                    return item;
                }
            }
            return null;
        }
    }
}