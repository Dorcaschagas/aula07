using System;
namespace aula07{
    public class Program{
        public static void Main(string [] args){
            ControlePonto ponto = new ControlePonto();

            Vendedor vendedor = new Vendedor("Joao", "123.456.789-00", 1250, 5);
            vendedor.CalcularSalario();
            
            Consultor consultor = new Consultor("Maria", "123.456.789-00", 1250, 5);
            consultor.CalcularSalario();
            
            Gerente gerente = new Gerente("Luiz", "123.456.789-00", 1250);
            gerente.CalcularSalario();

            ponto.RegistrarEntrada(gerente);
            ponto.RegistrarEntrada(vendedor);
            ponto.RegistrarEntrada(consultor);

            ponto.RegistrarSaida(gerente);
            ponto.RegistrarSaida(vendedor);
            ponto.RegistrarSaida(consultor);

            
        }
    }
}