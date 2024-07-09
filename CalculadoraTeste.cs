using Xunit;

namespace tarefa_teste_Xunit
{
    public class CalculadoraTeste
    {
        [Fact]
        public void TesteSomar()
        {
            //Arrange ou Given (Contextualização para o teste)
            /*Aqui ficaria a instanciação da calculadora
            se não tivessemos dito que ela é static*/

            //Act ou When (Verificação da ação para o teste)
            double resultado = Calculadora.Somar(2,3);

            //Assert ou Then (Verificação se ocorreu o esperado)
            Assert.Equal(5, resultado);
        }

        [Fact]  
        public void TesteSubtrair()
        {
            double resultado = Calculadora.Subtrair(15, 5);
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void TesteMultiplicar()
        {
            double resultado = Calculadora.Multiplicar(10, 2);
            Assert.Equal(20, resultado);
        }

        [Fact]
        public void TesteDividir()
        {
            double resultado = Calculadora.Dividir(10, 2);
            Assert.Equal(5, resultado);
        }

        //Verifica se a divisão é infinita
        [Fact]
        public void TesteDividirInfinito()
        {
            double resultado = Calculadora.Dividir(10, 0);
            Assert.Equal(double.PositiveInfinity, resultado);
        }
    }
}