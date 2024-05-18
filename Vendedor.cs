using System;
namespace aula07{
    public class Vendedor : Funcionario{
       public double? Comissao {get; set;}
       public long? NumerosVendas {get; set;}

       public Vendedor (string nome, string cpf, double comissao, long numerosVendas) : base(nome, cpf){
            this.Comissao = comissao;
            this.NumerosVendas = numerosVendas;
       }
       public override double CalcularSalario(){
            // Console.WriteLine("classe vendendor");
            return 0;
       }
    }
}