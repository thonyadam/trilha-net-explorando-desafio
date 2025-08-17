using static DesafioProjetoHospedagem.Models.Exceptions.ExceptionModel;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            var verificacaoCapacidade = hospedes.Count <= Suite.Capacidade;

            if (verificacaoCapacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new QuantidadeDeHospedesExcedidaException();
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Cálculo: DiasReservados X Suite.ValorDiaria
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            var verificacaoDesconto = DiasReservados >= 10;
            if (verificacaoDesconto)
            {
                valor = valor * 0.9m;
            }

            return valor;
        }
    }
}