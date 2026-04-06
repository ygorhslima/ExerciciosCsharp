using System;

namespace SistemaHospitalar;

public class Consulta(Paciente Paciente, Medico Medico, DateTime Data, string Receituario, double Valor)
{
    public Paciente Paciente { get; private set; } = Paciente;
    public Medico Medico { get; private set; } = Medico;
    public DateTime Data { get; private set; } = Data;
    public string Receituario { get; private set; } = Receituario;
    public double Valor { get; private set; } = Valor;
}
