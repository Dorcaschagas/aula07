using System;
namespace aula07{
    public class ControlePonto{
          public void RegistrarEntrada (Funcionario funcionario){
               GerarComprovante(funcionario, true);
          }
          
          public void RegistrarSaida (Funcionario funcionario){
               GerarComprovante(funcionario, false);
          }

          private void GerarComprovante (Funcionario funcionario, bool entrada){
               string tipoEntrada = entrada ? "Entrando" : "Saindo";
               Console.WriteLine("\n" + funcionario.Nome + " Esta " + tipoEntrada + "\nData: " + DateTime.Now);
               Console.WriteLine("Cargo: " + funcionario.GetType().Name );
               Console.WriteLine("===============================================");
          }
    }
}