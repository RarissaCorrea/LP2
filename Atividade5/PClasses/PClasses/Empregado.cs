using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    abstract class Empregado
    {
        private int matricula; //atributo
        private string nomeEmpregado;
        private DateTime dataEtradaEmpresa;
        private char homeOffice;

        public int Matricula //propriedade
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string NomeEmpregado
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }

        public DateTime DataEntradaEmpresa
        {
            get { return dataEtradaEmpresa; }
            set { dataEtradaEmpresa = value; }
        }

        public char HomeOffice
        {
            get { return homeOffice; }
            set { homeOffice = value; }
        }

        //metodos são ações/comportamentos
        public String VerificaHome()//método
        {
            if (homeOffice == 'S')
                return "Empregado trabalha em home office";
            else
                return "Emporegado não trabalha em home office";
        }

        //virtual --> poder ser subreescrito
        public virtual int TempoTrabalho()
        {
            //representa um intervalo de tempo
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);

            return (span.Days);
        }

        //deve ser implementado nas classes filhas (subclasses)

        public abstract double SalarioBruto();//não preciso implementar

       
    }
}
