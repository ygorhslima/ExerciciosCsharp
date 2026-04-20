using System;

namespace SistemaHospitalar;

public class Endereco(string Logradouro, int Numero, string Bairro, string CEP)
{
    public string Logradouro { get; set; } = Logradouro;
    public int Numero { get; set; } = Numero; 
    public string Bairro { get; set; } = Bairro;
    public string CEP { get; set; } = CEP;
    
    public string Info()
    {
        return $"{Logradouro}, {Numero}, {Bairro}, {CEP}";
    }
}
