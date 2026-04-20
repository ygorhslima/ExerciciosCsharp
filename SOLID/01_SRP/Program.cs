public class PedidoClasseErrada
{
    public void AdicionarItem() { /* Lógica de itens */ }
    
    // VIOLAÇÃO: O pedido não deveria saber como se salvar no banco
    public void SalvarNoBanco() 
    {
        Console.WriteLine("Salvando pedido no SQL Server...");
    }

    // VIOLAÇÃO: O pedido não deveria gerenciar logs
    public void GerarLog(string mensagem)
    {
        System.IO.File.WriteAllText("log.txt", mensagem);
    }
}

// CORREÇÃO: Separando as responsabilidades em classes distintas

public class Pedido
{
    public int Id { get; set; }
    public decimal ValorTotal { get; set; }
    public void AdicionarItem() { /* Lógica de itens */ }
}

public class PedidoRepository
{
    public void Salvar(Pedido pedido)
    {
        // Lógica para salvar no banco de dados
        Console.WriteLine($"Pedido {pedido.Id} salvo com sucesso.");
    }
}

public class LoggerService
{
    public void Log(string mensagem)
    {
        Console.WriteLine($"LOG: {mensagem}");
    }
}
