using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
    public interface ICrudArchivos<T>
    {
        bool Actualizar(List<T> contactos);
        List<T> ObtenerTodo();
        T Mappear(string linea);
    }
}