using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class ServicioContactosFamiliares : IServicios<Familiar>
    {
        List<Familiar> familiares;
        RepositorioFamiliar repositorioFamiliar;

        public ServicioContactosFamiliares()
        {
            repositorioFamiliar = new RepositorioFamiliar("Contactos_Familiares.txt");

            familiares = repositorioFamiliar.ObtenerTodo();
        }

        void Refresh()
        {
            familiares = repositorioFamiliar.ObtenerTodo();
        }

        public string Borrar(Familiar contacto)
        {
            familiares.Remove(contacto);
            repositorioFamiliar.Actualizar(familiares);
            Refresh();
            return $"el contacto se elimino correctamente con el nombre {contacto.Nombre}";
        }

        public string Editar(Familiar oldContacto, Familiar UpdateContacto)
        {
            //oldContacto.Id = UpdateContacto.Id;
            oldContacto.Nombre = UpdateContacto.Nombre;
            oldContacto.Telefono = UpdateContacto.Telefono;
            oldContacto.FechaNacimiento = UpdateContacto.FechaNacimiento;
            var estado = repositorioFamiliar.Actualizar(familiares);
            Refresh();
            return estado ? $"se actulizo el contacto {UpdateContacto.Nombre}" : $"ERROR al actulizar el contacto {UpdateContacto.Nombre}";
        }

        public Familiar ObtenerPorTelefono(string phone)
        {
            foreach (var item in familiares)
            {
                if (item.Telefono == phone)
                {
                    return item;
                }
            }
            return null;
        }

        public string Guardar(Familiar contacto)
        {
            if (ObtenerPorTelefono(contacto.Telefono) != null)
            {
                return "contacto ya existe con este numero de telefono";
            }

            var estado = repositorioFamiliar.Guardar(contacto);

            Refresh();

            return estado ? $"el contacto se agrego correctamente con el nombre {contacto.Nombre}" :
                                 $"ERROR al Guardar el contacto con el nombre {contacto.Nombre}";
        }

        public List<Familiar> ObtenerTodo()
        {
            return familiares;
        }
    }
}