using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    class Util
    {
        private static Form1 f1;
        private static Usuario usuario;

        public static void setF1(Form1 f1)
        {
            Util.f1 = f1;
        }
        public static Form1 getF1()
        {
            return Util.f1;
        }

        public static void setUsuario (Usuario usuario)
        {
            Util.usuario = usuario;
        }
        public static Usuario getUsuario()
        {
            return Util.usuario;
        }


    }
}
