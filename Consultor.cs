using System;
namespace aula07{
    public class Consultor : Funcionario{
       public double? ValorHora {get; set;}
       public long? HorasTrabalhadas {get; set;}

       public Consultor (string nome, string cpf, double valorHora, long horasTrabalhadas) : base(nome, cpf){
            this.ValorHora = valorHora;
            this.HorasTrabalhadas = horasTrabalhadas;
       }
       public override double CalcularSalario(){
          //   Console.WriteLine("classe Consultor");
            return 0;
       }
    }
}