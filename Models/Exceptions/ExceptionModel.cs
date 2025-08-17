using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models.Exceptions
{
    public class ExceptionModel
    {
        public class QuantidadeDeHospedesExcedidaException : ArgumentException
        {
            public QuantidadeDeHospedesExcedidaException() : base("Quantidade de Hospedes maior do que a Suite comporta")
            {
            }
        }

    }
}
