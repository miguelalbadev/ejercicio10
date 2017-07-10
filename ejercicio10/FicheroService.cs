using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10 {
    public class FicheroService : IFicheroService {

        public void GuardarNumero(int c) {

            FicheroUtil ficheroUtil = new FicheroUtil();

            ficheroUtil.Almacenar(c, "miFichero.txt");
        }
    }
}
