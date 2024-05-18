using System;
namespace aula07{
    public abstract class Funcionario{
       public string? Nome {get; set;}
       public string? Cpf {get; set;}
       protected const double SalarioMinimo = 1300;

       public Funcionario (string nome, string cpf){
            this.Nome = nome;
            this.Cpf = cpf;
       }
       public abstract double CalcularSalario();
       
    }
}