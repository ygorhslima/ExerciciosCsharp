using System;

namespace SistemaHospitalar;

public class Medico(
    string nome,
    DateTime dataNascimento,
    Endereco endereco,
    int crm,
    Especialidade especialidade,
    double valorHora
) : Pessoa(nome, dataNascimento, endereco)
{
    public int CRM { get; private set; } = crm;
    public Especialidade Especialidade { get; private set; } = especialidade;
    public double ValorHora { get; private set; } = valorHora;

    public string Info()
    {
        return $"Nome: {Nome}\nData de Nascimento: {DataNascimento}\nEndereco:{Endereco.Info()}\nCRM: {CRM}\nEspecialidade: {Especialidade.Info()}\nValor de hora: {ValorHora:C}";
    }
}