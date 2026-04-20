public class RetanguloErrado
{
    public virtual int Largura { get; set; }
    public virtual int Altura { get; set; }
    public int CalcularArea() => Largura * Altura;
}

public class QuadradoErrado : RetanguloErrado
{
    // VIOLAÇÃO: No quadrado, largura e altura devem ser iguais.
    // Ao forçar isso, alteramos o comportamento esperado de um Retângulo.
    public override int Largura 
    { 
        set { base.Largura = base.Altura = value; } 
    }
    public override int Altura 
    { 
        set { base.Largura = base.Altura = value; } 
    }
}


// CORREÇÃO: Criando uma hierarquia de formas geométricas

public abstract class FormaGeometrica
{
    public abstract int CalcularArea();
}

public class Retangulo : FormaGeometrica
{
    public int Largura { get; set; }
    public int Altura { get; set; }
    public override int CalcularArea() => Largura * Altura;
}

public class Quadrado : FormaGeometrica
{
    public int Lado { get; set; }
    public override int CalcularArea() => Lado * Lado;
}