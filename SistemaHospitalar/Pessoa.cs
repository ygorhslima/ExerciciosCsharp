using System;

namespace SistemaHospitalar;

abstract public class Pessoa(string Nome, DateTime DataNascimento, Endereco Endereco)
{
    public string Nome { get; private set; } = Nome;
    public Endereco Endereco { get; private set; } = Endereco;
    private DateTime _dataNascimento = DataNascimento;

    public DateTime DataNascimento
    {
        get => _dataNascimento;
        private set
        {
            if (value > DateTime.Now)
            {
                Console.WriteLine("Não é possível alguém nascer no futuro");
                return;
            }
            _dataNascimento = value;
        }
    }

    public string Info()
    {
        return $"Nome: {Nome}\nData de Nascimento: {DataNascimento}\nEndereço: {Endereco.Info()}";
    }
}