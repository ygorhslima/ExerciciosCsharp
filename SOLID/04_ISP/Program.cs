// VIOLAÇÃO DO ISP
public interface IFuncionarioErrado {
    void Trabalhar();
    void ReceberComissao(); // Nem todo funcionário ganha comissão
}

public class VendedorErrado : IFuncionarioErrado {
    public void Trabalhar() => Console.WriteLine("Vendendo...");
    public void ReceberComissao() => Console.WriteLine("Comissão paga!");
}

public class ProgramadorErrado : IFuncionarioErrado {
    public void Trabalhar() => Console.WriteLine("Codando...");
    
    // O programador é forçado a implementar algo que não usa
    public void ReceberComissao() {
        throw new NotImplementedException("Programadores não ganham comissão!");
    }
}

// CORREÇÃO COM O ISP
// Interfaces específicas (Segregadas)
public interface ITrabalhavel {
    void Trabalhar();
}

public interface IComissionavel {
    void ReceberComissao();
}

// O Vendedor precisa de ambas
public class Vendedor : ITrabalhavel, IComissionavel {
    public void Trabalhar() => Console.WriteLine("Vendendo...");
    public void ReceberComissao() => Console.WriteLine("Comissão creditada.");
}

// O Programador agora só implementa o que lhe cabe
public class Programador : ITrabalhavel {
    public void Trabalhar() => Console.WriteLine("Codando...");
}