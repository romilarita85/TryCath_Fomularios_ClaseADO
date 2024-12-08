using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeEmpleados22_11
{
    public class Subgerente:Gerente
    {
        public Subgerente(int id, string nombre, string apellido, int edad, string departamento, double salario, int proyectosManejados)
            : base(id, nombre, apellido, edad, departamento, salario, proyectosManejados)
        {

        }
        public override string MostrarInformacion()
        {
            return "Soy un subgerente";//redefinio su comportamiento
        }


    }
}
