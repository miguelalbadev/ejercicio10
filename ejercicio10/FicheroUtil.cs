using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10 {
    public class FicheroUtil {

        private static bool llamado = false;

        public void Almacenar(Object datos, string nombreFichero) {
            llamado = true;
            // TODO
            // throw new Exception("No implementado todavía");
        }

        public static bool IsLlamado() {
            return llamado;
        }
    }
}
