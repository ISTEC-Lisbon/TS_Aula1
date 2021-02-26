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

    public interface ICarro //a interface define, no minimo, estas regras quando se cria uma class
    {
        String Modelo { get; }
        String Marca { get; }
        int Velocidade { get; set; }
        int Distancia { set; }

        void Acelerar();

    }//fim da interface


    public class Viatura
    {
        //Campos := Variáveis declaradas ao nível da classe
        public String marca;
        private String _modelo = "Modelo Não Definido"; //o underscore é usado para as var privadas
        private int _velocidade;
        private static Random _rnd = new Random(); //Fixed by Ivo Protásio (@ivoprotasioAltyra)
        public static int total;


        #region Propriedades

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

            this.Ver();
        }

        public virtual void Ver()
        {
            //Console.WriteLine("Marca: {0}", marca);
            Console.WriteLine("\n--------------(" + this.marca + ")--------------");
            Console.WriteLine("Modelo: {0}", _modelo);
            Console.WriteLine("Velocidade:" + this._velocidade.ToString());
            Console.WriteLine("Total: {0}", total);
        }

        #endregion



        #region Construtor

        public Viatura() //exemplo overload
        {
            total++;
            this.marca = "Marca Não Definida";
        }
        public Viatura(String par_marca, String modelo)
        {
            total++;
            this.marca = par_marca;
            this._modelo = modelo;
        }

        public Viatura(string marca, string modelo, int velocidade) : this(marca, modelo) //exemplo overload nr2
        {
            this.Velocidade = 0;
        }

        #endregion



        ~Viatura() //método destrutor
        {
            Console.WriteLine("O {0} foi destruído!", this._modelo);
            total--;
        }


    } //fim da class

    public class Carro : Viatura, ICarro
    {
        private int _distancia;

        #region Contrutores

        public Carro() : base()
        {
            _distancia = 0;
        }

        public Carro(String marca, String modelo) : base(marca, modelo)
        {

        }
        public Carro(String marca, String modelo, int velocidade) : base(marca, modelo, velocidade)
        {

        }

        public string Marca => throw new NotImplementedException();

        public int Distancia
        {
            get { return _distancia; }
            set
            {
                if (value > 0) _distancia = value;
            }
        }

        #endregion

        //Override
        public override void Ver() //só consigo fazer override se o método Ver() for virtual ou abstract
        {
            base.Ver();
            Console.WriteLine("Distância: {0}", _distancia);
        }
    }
}
