using System;

namespace SistemaHospitalar;

public class Paciente(
    string nome,
    DateTime dataNascimento,
    Endereco endereco,
    string CPF,
    Plano Plano
) : Pessoa(nome, dataNascimento, endereco)
{

    public string CPF { get; private set; } = CPF;
    public Plano Plano { get; private set; } = Plano;

    public string Info()
    {
        return $"Nome: {Nome}\nData de Nascimento: {DataNascimento}\nEndereço: {Endereco.Info()}\nCPF:{CPF}\nPlano:{Plano.Info()}";
    }
}
