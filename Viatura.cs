using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS_Aula1
{
    /**
     * SCOPES:
     * private = (so visível na classe),
     * protected = (visível na classe e nas suas derivadas),
     * internal ,
     * public
     */

    public class Viatura
    {
        //Campos := Variáveis declaradas ao nível da classe
        public String marca;
        private String _modelo = "Modelo Não Definido"; //o underscore é usado para as var privadas
        private int _velocidade;

        private static Random _rnd = new Random(); //Fixed by Ivo Protásio (@ivoprotasioAltyra)



        //Properties
        public String Modelo
        {
            get { return _modelo; } //o user so pode ver a variável. Para definir, o set tem que estar descomentado

            //set { }
        }

        public int Velocidade
        {
            get { return _velocidade; }
            set
            {
                if (value > 0) this._velocidade = value;
            }
        }

        public void Acelerar()
        {
            int n = _rnd.Next(0, 201);
            // Can return 0,..., 200
            this._velocidade = n;
        }

        public void Ver()
        {
            //Console.WriteLine("Marca: {0}", marca);
            Console.WriteLine("\n--------------(" + this.marca + ")--------------");
            Console.WriteLine("Modelo: {0}", _modelo);
            Console.WriteLine("Velocidade:" + this._velocidade.ToString());
        }


        //Construtor
        public Viatura() //exemplo overload
        {
            this.marca = "Marca Não Definida";
        }

        public Viatura(String par_marca, String modelo)
        {
            this.marca = par_marca;
            this._modelo = modelo;
        }
    }
}
