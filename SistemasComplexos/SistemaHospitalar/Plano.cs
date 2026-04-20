using System;

namespace SistemaHospitalar;

public class Plano(string Nome, double Mensalidade)
{
    public string Nome { get; private set; } = Nome;
    public double Mensalidade { get; private set; } = Mensalidade;

    public string Info()
    {
        return $"{Nome}, {Mensalidade}";
    }
}
