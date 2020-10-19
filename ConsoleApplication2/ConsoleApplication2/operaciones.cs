using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class operaciones
    {
        private multiplicacion mul;
        private division div;
        private suma sum;
        private resta res;

        public operaciones()
        {
            this.sum = new suma();
            this.res = new resta();
            this.mul = new multiplicacion();
            this.div = new division();
        }
        public void operar(int n1, int n2)
        {
            Console.WriteLine("la Suma es: " + sum.sumar(n1, n2));
            Console.WriteLine("la Resta es: " + res.restar(n1, n2));
            Console.WriteLine("la multiplicacion es: " + mul.multiplicar(n1, n2));
            Console.WriteLine("la division es:" + div.dividir(n1, n2));
        }
    }
}
