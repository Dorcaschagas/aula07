using System;
namespace aula07{
    public class Gerente : Funcionario{
       public double Bonificacao {get; set;}

       public Gerente (string nome, string cpf, double bonificacao) : base(nome, cpf){
            this.Bonificacao = bonificacao;
       }
       public override double CalcularSalario(){
          Bonificacao = ( 6 * SalarioMinimo);          
          Console.WriteLine($"O Gerente recebe: {Bonificacao}");
          return Bonificacao;
       }
    }
}