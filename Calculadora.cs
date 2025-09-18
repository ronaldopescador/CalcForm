namespace Calculadora
{
    public class Calculadora
    {
        private double _primeiroNumero = 0;
        private string _operador = "";
        private bool _operacaoPendente = false;

        public double Resultado { get; private set; } = 0;

        public void Limpar()
        {
            _primeiroNumero = 0;
            _operador = "";
            _operacaoPendente = false;
            Resultado = 0;
        }

        public void DefinirOperacao(double numero, string operador)
        {
            _primeiroNumero = numero;
            _operador = operador;
            _operacaoPendente = true;
        }

        public double Calcular(double segundoNumero)
        {
            if (!_operacaoPendente)
            {
                return segundoNumero;
            }

            switch (_operador)
            {
                case "+":
                    Resultado = _primeiroNumero + segundoNumero;
                    break;
                case "-":
                    Resultado = _primeiroNumero - segundoNumero;
                    break;
                case "*":
                    Resultado = _primeiroNumero * segundoNumero;
                    break;
                case "/":
                    if (segundoNumero != 0)
                    {
                        Resultado = _primeiroNumero / segundoNumero;
                    }
                    break;
            }
            _operacaoPendente = false;
            return Resultado;
        }
    }
}
