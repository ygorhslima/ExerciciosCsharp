using SistemaHospitalar;

public class Program
{
    public static void Main(string[] args)
    {

        Paciente paciente = new(
            "José",
            DateTime.Parse("2000-12-12"),
            new Endereco("Rua C", 123, "Bairro D", "31312-23"),
            "5588-9278",
            new Plano("Cardiologia",300)
        );

        Medico medico = new(
            "João",
            DateTime.Parse("1991-09-10"),
            new Endereco("Rua B", 153, "Bairro C", "12314-123"),
            123123,
            new Especialidade("Cardiologista"),
            100
        );

        Console.WriteLine(medico.Info());
        Console.WriteLine("--------------------------------");
        Console.WriteLine(paciente.Info());
    }
}
