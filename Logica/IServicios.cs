using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public interface IServicios<T>
    {
        string Guardar(T contacto);

        string Borrar(T contacto);

        string Editar(T oldContacto, T UpdateContacto);

        List<T> ObtenerTodo();

        //T GetById(int id);

        T ObtenerPorTelefono(string phone);

        //bool Exist(T Contacto);
    }
}