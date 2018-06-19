using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Fada
    {
        private string nome;
        private string familia;
        private string cor;
        private string corDaAsa;
        private double tamanhoDaAsa;
        private bool asaQuebrada;
        private bool mulher;
        private string fazBarulho;
        private string elemento;


        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Nome deve ser preenchido");
                }

                if (value.Count() < 2)
                {
                    throw new Exception("Nome deve conter pelo menos 2 letras");
                }

                if (value.Count() > 120)
                {
                    throw new Exception("Nome deve conter no maximo 120 letras");
                }

                nome = value;
            }
        }




        public string Familia
        {
            get
            {
                return familia;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Familia deve ser preenchida");
                }

                if (value.Count() < 2)
                {
                    throw new Exception("Familia deve conter pelo menos 2 letras");
                }

                if (value.Count() > 120)
                {
                    throw new Exception("Familia deve conter no maximo 120 letras");
                }

                familia = value;
            }
        }


        public string Cor
        {
            get
            {
                return cor;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Cor deve ser selecionada");
                }

                

                cor = value;
            }
        }




        public string CorDaAsa
        {
            get
            {
                return corDaAsa;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Selecione a cor da asa");
                }



                corDaAsa = value;
            }
        }


        public double TamanhoDaAsa
        {
            get
            {
                return tamanhoDaAsa;
            }
            set
            {
                if (value < 5)
                {
                    throw new Exception("Tamanha da asa deve ser maior que 5 centimetros, se não vc é uma farsa");
                }

                if (value > 60)
                {
                    throw new Exception("Tamanho da asa deve conter maximo 60 centimetros");
                }

                tamanhoDaAsa = value;
            }
        }




        public bool AsaQuebrada
        {
            get
            {
                return asaQuebrada;
            }
            set
            {
               

                asaQuebrada = value;
            }
        }


        public bool Mulher
        {
            get
            {
                return mulher;
            }
            set
            {
                

                mulher = value;
            }
        }

        public string FazBarulho
        {
            get
            {
                return fazBarulho;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Selecione se a fada faz barulho");
                }

                fazBarulho = value;
            }
        }

       
        public string Elemento
        {
            get
            {
                return elemento;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Selecione o elemento");
                }

              

                elemento = value;
            }
        }

        public Fada (string nome, bool mulher, bool asaQuebrada)
        {
            Nome = nome;
            Mulher = mulher;
            AsaQuebrada = asaQuebrada; 
        }


         public Fada(string nome, string familia, string cor)
        {
            Nome = nome;
            Familia = familia;
            Cor = cor;
        }

         public Fada(string nome, bool mulher, string familia)
        {
            Nome = nome;
            Familia = familia;
            Mulher = mulher;
        }
        




    }
}
