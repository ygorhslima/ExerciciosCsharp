using System;

namespace SistemaHospitalar;

public class Procedimento(
    Paciente paciente,
    Medico medico,
    DateTime date,
    Sala sala,
    string observacoes,
    double valor,
    int tempoDuracao
)
{
    public Paciente Paciente { get; private set; } = paciente;
    public Medico Medico { get; private set; } = medico;
    public DateTime Date { get; private set; } = date;
    public Sala Sala { get; private set; } = sala;
    public string Observacoes { get; private set; } = observacoes;
    public double Valor { get; private set; } = valor;
    public int TempoDuracao { get; private set; } = tempoDuracao;

}
