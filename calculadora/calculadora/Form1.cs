using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class pantalla : Form
    {
        public pantalla()
        {
            InitializeComponent();
        }

        private void abreParentesis_Click(object sender, EventArgs e)
        {
            string cadena = cajaTexto.Text;
            if (cadena ==""){
                cadena = cadena + "( ";
            }
            else
            {
                //string[] prenum = cadena.Split();
                if (cadena[cadena.Length-1].CompareTo(' ')==0){
                    cadena = cadena + "( ";
                }
                else
                {
                    cadena = cadena + " ( ";
                }
            }
            cajaTexto.Text = cadena;
        }

        private void cierraParentesis_Click(object sender, EventArgs e)
        {
            string cadena = cajaTexto.Text;
            if (!cadena.Equals(""))
            {
                string[] prenum = cadena.Split(); //un operador no puede estar despues de otro excepto en el parentesis
                if (cadena[cadena.Length - 1].CompareTo(' ') != 0)
                {  //es diferente de un espacio porque todo los signos vienen con un espacio
                    cadena = cadena + " ) ";
                    cajaTexto.Text = cadena;
                }
            }
        }

        private void exponente_Click(object sender, EventArgs e)
        {
            String cadena = cajaTexto.Text;
            if (!cadena.Equals(""))
            {
                //String prenum[] = cadena.split(""); //un operador no puede estar despues de otro excepto en el parentesis
                if (cadena[cadena.Length - 1].CompareTo(' ') != 0)
                {  //es diferente de un espacio porque todo los signos vienen con un espacio
                    cadena = cadena + " ^ ";
                    cajaTexto.Text = cadena;
                }
                else
                {
                    if (cadena[cadena.Length - 2].CompareTo(')') == 0)
                    {
                        cadena = cadena + "^ ";
                        cajaTexto.Text = cadena;
                    }
                }
            }
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            string cadena = cajaTexto.Text;
            if (!cadena.Equals(""))
            {
                //String prenum[] = cadena.split(""); //un operador no puede estar despues de otro excepto en el parentesis
                if (cadena[cadena.Length - 1].CompareTo(' ') != 0)
                {
                    cadena = cadena + " / ";
                    cajaTexto.Text=cadena;
                }
                else
                {
                    if (cadena[cadena.Length - 2].CompareTo(')') == 0)
                    {
                        cadena = cadena + "/ ";
                        cajaTexto.Text=cadena;
                    }
                }
            }
        }

        private void producto_Click(object sender, EventArgs e)
        {
            string cadena = cajaTexto.Text;
            if (!cadena.Equals(""))
            {
                //string prenum[] = cadena.split(""); //un operador no puede estar despues de otro excepto en el parentesis
                if (cadena[cadena.Length - 1].CompareTo(' ') != 0)
                {
                    cadena = cadena + " * ";
                    cajaTexto.Text=cadena;
                }
                else
                {
                    if (cadena[cadena.Length - 2].CompareTo(')') == 0)
                    {
                        cadena = cadena + "* ";
                        cajaTexto.Text=cadena;
                    }
                }
            }
        }

        private void diferencia_Click(object sender, EventArgs e)
        {
            string cadena = cajaTexto.Text;
            if (!cadena.Equals(""))
            {
                //String prenum[] = cadena.split(""); //un operador no puede estar despues de otro excepto en el parentesis
                if (cadena[cadena.Length - 1].CompareTo(' ') != 0)
                {
                    cadena = cadena + " - ";
                    cajaTexto.Text=cadena;
                }
                else
                {
                    if (cadena[cadena.Length - 2].CompareTo(')')==0)
                    {
                        cadena = cadena + "- ";
                        cajaTexto.Text=cadena;
                    }
                }
            }
        }

        private void suma_Click(object sender, EventArgs e)
        {
            string cadena = cajaTexto.Text;
            if (!cadena.Equals(""))
            {
                //String prenum[] = cadena.split(""); //un operador no puede estar despues de otro excepto en el parentesis
                if (cadena[cadena.Length - 1].CompareTo(' ') != 0)
                {
                    cadena = cadena + " + ";
                    cajaTexto.Text=cadena;
                }
                else
                {
                    if (cadena[cadena.Length - 2].CompareTo(')') == 0)
                    {
                        cadena = cadena + "+ ";
                        cajaTexto.Text=cadena;
                    }
                }
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            cajaTexto.Text = "";
        }

        private void uno_Click(object sender, EventArgs e)
        {
            string cadena = "";
            cadena = cajaTexto.Text;
            cadena = cadena + "1";
            cajaTexto.Text=cadena;
        }

        private void dos_Click(object sender, EventArgs e)
        {
            string cadena = "";
            cadena = cajaTexto.Text;
            cadena = cadena + "2";
            cajaTexto.Text = cadena;
        }

        private void tres_Click(object sender, EventArgs e)
        {
            string cadena = "";
            cadena = cajaTexto.Text;
            cadena = cadena + "3";
            cajaTexto.Text = cadena;
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            string cadena = "";
            cadena = cajaTexto.Text;
            cadena = cadena + "4";
            cajaTexto.Text = cadena;
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            string cadena = "";
            cadena = cajaTexto.Text;
            cadena = cadena + "5";
            cajaTexto.Text = cadena;
        }

        private void seis_Click(object sender, EventArgs e)
        {
            string cadena = "";
            cadena = cajaTexto.Text;
            cadena = cadena + "6";
            cajaTexto.Text = cadena;
        }

        private void siete_Click(object sender, EventArgs e)
        {
            string cadena = "";
            cadena = cajaTexto.Text;
            cadena = cadena + "7";
            cajaTexto.Text = cadena;
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            string cadena = "";
            cadena = cajaTexto.Text;
            cadena = cadena + "8";
            cajaTexto.Text = cadena;
        }

        private void nueve_Click(object sender, EventArgs e)
        {
            string cadena = "";
            cadena = cajaTexto.Text;
            cadena = cadena + "9";
            cajaTexto.Text = cadena;
        }

        private void cero_Click(object sender, EventArgs e)
        {
            string cadena = "";
            cadena = cajaTexto.Text;
            //String prenum[] = cadena.split(""); //un cero a la izquierda no tiene valor
            if (cadena[cadena.Length - 1].CompareTo(' ') != 0)
            {  //es diferente de un espacio porque todo los signos vienen con un espacio
                cadena = cadena + "0";
                cajaTexto.Text=cadena;
            }
        }
        //Evaluar
        private String convertir(String infija)
        {
            String posfija = "";
            //Pila de Strings
            Pila pila = new Pila(100);
            //Separamos la expresion que queremos evaluar
            string[] expresion = infija.Split(' ');
            Console.WriteLine("Valores introducidos: ");
            for (int i = 0; i < expresion.Length; i++)
            {
                Console.WriteLine(expresion[i]);
                //entra si es operador
                if (expresion[i].Equals("(")||expresion[i].Equals(")")||expresion[i].Equals("+")||expresion[i].Equals("-")||expresion[i].Equals("*")||expresion[i].Equals("/")||expresion[i].Equals("^"))
                {
                    //al encontrar un ) vaciamos la pila hasta encontrar un (
                    if (pila.estaVacia())
                    {
                        pila.apilar(expresion[i]);
                    }
                    else
                    {
                        int pe = prioridadExpresion(expresion[i]);
                        //el operador ) no se apila
                        String operador;
                        if (expresion[i].Equals(")"))
                        {
                            //sacamos el ultimo operador para añadir a posfija
                            while (!pila.elementotope().Equals("("))
                            {
                                operador = pila.desapilar();
                                posfija = posfija + operador + " ";
                            }
                            pila.desapilar();
                        }
                        else
                        {
                            while (!pila.estaVacia() && pe <= prioridadPila(pila.elementotope()))
                            {
                                operador = pila.desapilar();
                                posfija = posfija + operador + " ";
                            }
                            pila.apilar(expresion[i]);
                        }
                    }
                    //se añade si es un numero
                }
                else
                {
                    posfija = posfija + expresion[i] + " ";
                }
            }
            //vaciamos si quedo algun operador en la pila
            while (!pila.estaVacia())
            {
                posfija = posfija + pila.desapilar() + " ";
            }
            return posfija;
        }
        private static int prioridadExpresion(string operador)
        {
            switch (operador)
            {
                case "^":
                    return 4;
                case "/":
                    return 2;
                case "*":
                    return 2;
                case "+":
                    return 1;
                case "-":
                    return 1;
                case "(":
                    return 5;
                case ")":
                    return -1;
                default:
                    return 0;
            }
        }
        private static int prioridadPila(string operador)
        {
            switch (operador)
            {
                case "^":
                    return 3;
                case "/":
                    return 2;
                case "*":
                    return 2;
                case "+":
                    return 1;
                case "-":
                    return 1;
                case "(":
                    return 0;
                case ")":
                    return -1;
                default:
                    return 0;
            }
        }
        private int evaluarPosfija(string posfija)
        {
            int[] numeros = new int[50];
            int tope = 0, i;
            double ope1, ope2, ope3;
            //quitar espacios del final de la cadena
            string cadena = posfija.Trim();
            string[] expresion = cadena.Split(' ');
            for (i = 0; i < expresion.Length; i++)
            {//recorrera nuestra cadena posfija
             //si el elemento es un operador se evalua 2 numeros
                if (expresion[i].Equals("+")||expresion[i].Equals("-")||expresion[i].Equals("*")||expresion[i].Equals("/")||expresion[i].Equals("^"))
                {
                    //sacamos los dos ultimos numeros de la pila
                    tope--;
                    ope2 = numeros[tope];
                    tope--;
                    ope1 = numeros[tope];
                    switch (expresion[i])
                    {
                        case "*":
                            ope3 = ope1 * ope2;
                            break;
                        case "/":
                            ope3 = ope1 / ope2;
                            break;
                        case "+":
                            ope3 = ope1 + ope2;
                            break;
                        case "-":
                            ope3 = ope1 - ope2;
                            break;
                        case "^":
                            ope3 = Math.Pow(ope1, ope2);
                            break;
                        default:
                            ope3 = 0;
                            break;
                    }
                    //ope3 se añade nuevamente a la pila como entero
                    numeros[tope] = (int)ope3;
                    tope++;
                }
                //si es un numero se almacena en la pila numeros
                else
                {
                    numeros[tope] = Convert.ToInt32(expresion[i]);
                    tope++;
                }
            }
            return numeros[0];
        }
        private int evaluar(string infija)
        {
            string posfija = convertir(infija);
            Console.WriteLine("La expresion Posfija es: " + posfija);
            return evaluarPosfija(posfija);
            //return 10;
        }

        private void solucionar_Click(object sender, EventArgs e)
        {
            string cadena = cajaTexto.Text;
            cajaTexto.Text=(evaluar(cadena)).ToString();
        }
    }
}
