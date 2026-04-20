public class CalculadoraDeDescontoErrado
{
    public decimal Calcular(decimal valor, string tipoCliente)
    {
        if (tipoCliente == "VIP")
            return valor * 0.8m;
        
        if (tipoCliente == "Premium")
            return valor * 0.9m;

        return valor; // Sem desconto
    }
}

// CORREÇÃO: Usando herança para cada tipo de cliente
public abstract class Desconto
{
    public abstract decimal Aplicar(decimal valor);
}

public class DescontoVIP : Desconto
{
    public override decimal Aplicar(decimal valor) => valor * 0.8m;
}

public class DescontoPremium : Desconto
{
    public override decimal Aplicar(decimal valor) => valor * 0.9m;
}