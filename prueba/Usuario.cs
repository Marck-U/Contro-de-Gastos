using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    class Usuario
    {
        private String rut, nombre, clave;
        private int idEstado, idTipo;


        public Usuario(String rut, String nombre, String clave, int idEstado, int idTipo)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.idEstado = idEstado;
            this.idTipo = idTipo;
            this.clave = clave;
        }

        public String getRut()
        {
            return rut;
        }

        public void setRut(String rut)
        {
            this.rut = rut;
        }


        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public int getIdEstado()
        {
            return idEstado;
        }

        public void setIdEstado(int idEstado)
        {
            this.idEstado = idEstado;
        }

        public int getIdTipo()
        {
            return idTipo;
        }

        public void setIdTipo(int idTipo)
        {
            this.idTipo = idTipo;
        }

        public String getClave()
        {
            return clave;
        }

        public void setClave(String clave)
        {
            this.clave = clave;
        }

    }
}
