using System;

namespace SistemaHospitalar;

public class Especialidade(string nome)
{
    public string Nome { get; private set; } = nome;
    public string Info()
    {
        return $"{Nome}";
    }
}
