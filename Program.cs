using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

Console.WriteLine("Suite 1 -----------");
// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

try
{
    Console.WriteLine("Suite 2 -----------");
    // Cria a suíte
    Suite suite2 = new Suite(tipoSuite: "Premium", capacidade: 1, valorDiaria: 30);

    // Cria uma nova reserva, passando a suíte e os hóspedes
    Reserva reserva2 = new Reserva(diasReservados: 5);
    reserva2.CadastrarSuite(suite2);
    reserva2.CadastrarHospedes(hospedes);

    // Exibe a quantidade de hóspedes e o valor da diária
    Console.WriteLine($"Hóspedes: {reserva2.ObterQuantidadeHospedes()}");
    Console.WriteLine($"Valor diária: {reserva2.CalcularValorDiaria()}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Suite 3 -----------");
// Cria a suíte
Suite suite3 = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva3 = new Reserva(diasReservados: 10);
reserva3.CadastrarSuite(suite3);
reserva3.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva3.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva3.CalcularValorDiaria()}");