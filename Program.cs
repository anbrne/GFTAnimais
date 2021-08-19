using System;
using System.Collections.Generic;

namespace GFTAnimais2
{
    abstract class Animais
    {

        public string nome { get; set; }
        public int peso { get; set; }
        public int qtdeRacaoDia { get; set; }

        public abstract string som();
        public abstract string quiantidadeDeRacao();
    }
    class Cachorro : Animais
    {
        public Cachorro()
        {
          
        }
        public override string som ()
        {
            return "auau";
        }
        public override string quiantidadeDeRacao()
        {

            if (this.peso <= 3)
            {
                this.qtdeRacaoDia = this.peso * 35;
                return "O cachorro pode consumir " + this.qtdeRacaoDia + " gramas por dia";
            }
            else if (this.peso > 3 && peso <= 10)
            {
                this.qtdeRacaoDia = this.peso * 45;
                return "O cachorro pode consumir " + this.qtdeRacaoDia + " gramas por dia";
            }
            else if (this.peso > 10)
            {
                this.qtdeRacaoDia = this.peso * 50;
                return "O cachorro pode consumir " + this.qtdeRacaoDia + " gramas por dia";
            }

            return null;
        }
    }
    class Gato : Animais
    {
        public Gato()
        {

        }
        public override string som()
        {
            return "miau";
        }
        public override string quiantidadeDeRacao()
        {
            if (this.peso <= 4)
            {
                this.qtdeRacaoDia = this.peso * 12;
                return "O gato pode consumir " + this.qtdeRacaoDia + " gramas por dia";
            }
            else if (this.peso > 4)
            {
                this.qtdeRacaoDia = this.peso * 15;
                return "O gato pode consumir " + this.qtdeRacaoDia + " gramas por dia";
            }
            return null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var listCachorros = new  List<Cachorro>();
            var listGatos = new List<Gato>();


            listGatos.Add(new Gato
            {
                nome = "Coca",
                peso = 20
            });


            listGatos.Add(new Gato
            {
                nome = "Foxy",
                peso = 3
            });

            listCachorros.Add(new Cachorro
            {
                nome = "Fox",
                peso = 10
            });

            listGatos.Add(new Gato
            {
                nome = "Edward",
                peso = 5
            });


            int totalRacao = 0;

            foreach (var lC in listCachorros)
            {
                lC.quiantidadeDeRacao();
                totalRacao += lC.qtdeRacaoDia;
            }
            foreach (var lG in listGatos)
            {
                lG.quiantidadeDeRacao();
                totalRacao += lG.qtdeRacaoDia;
            }
            Console.WriteLine("O total de ração consumida por dia é: " + totalRacao.ToString());
        }
    }
}
