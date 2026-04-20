using System;
using System.Collections.Generic;
using System.Linq;

class OrdemServico
{
    // Adicionado 'public' para permitir acesso em outros métodos
    public int ID { get; set; }
    public string Cliente { get; set; }
    public string Equipamento { get; set; }
    public string Descricao { get; set; }
    public double ValorOrcado { get; set; }
    public string Estado { get; set; } // Agora é uma string simples
}

public class Program
{
    // Nossa "memória" centralizada
    static List<OrdemServico> bancoDeDados = new List<OrdemServico>();
    static int proximoID = 1; // Para auto-incrementar o ID

    // Adicionado 'static' para ser chamado pelo Main
    static void CadastrarNovaOrdem()
    {
        Console.WriteLine("================= NOVO CADASTRAR ==================");
        OrdemServico NovoOrdemServico = new OrdemServico();
        NovoOrdemServico.ID = proximoID++;

        Console.Write("Cliente: ");
        NovoOrdemServico.Cliente = Console.ReadLine();

        Console.Write("Equipamento: ");
        NovoOrdemServico.Equipamento = Console.ReadLine();

        Console.Write("Descrição: ");
        NovoOrdemServico.Descricao = Console.ReadLine();

        Console.Write("Valor Orcado: ");
        NovoOrdemServico.ValorOrcado = double.Parse(Console.ReadLine());

        NovoOrdemServico.Estado = "Pendente";

        bancoDeDados.Add(NovoOrdemServico);
        Console.WriteLine("Ordem de Serviço cadastrada com sucesso");

    }

    static void MostrarTodasInformacoes()
    {
        Console.WriteLine("\n--- LISTAGEM GERAL ---");

        if (bancoDeDados.Count == 0)
        {
            Console.WriteLine("Nenhum dado cadastrado.");
            return;
        }

        foreach (var servico in bancoDeDados)
        {
            Console.WriteLine($"ID: {servico.ID}\nCliente: {servico.Cliente}\nStatus: {servico.Estado}\nValor: {servico.ValorOrcado}");
        }
    }

    static void AlterarStatus()
    {
        Console.WriteLine("\n--- ALTERAR STATUS DA ORDEM ---");
        Console.Write("Digite o ID da Ordem de Serviço: ");
        if (!int.TryParse(Console.ReadLine(), out int idBuscado))
        {
            Console.WriteLine("ID inválido.");
            return;
        }

        var ordem = bancoDeDados.FirstOrDefault(ordem => ordem.ID == idBuscado);
        if (ordem == null)
        {
            Console.WriteLine("Ordem de serviço não encontrado");
            return;
        }
        Console.WriteLine($"Status Atual: {ordem.Estado}");
        Console.WriteLine("Escolha um novo estado: ");
        Console.WriteLine("[1] Pendente | [2] Em Andamento | [3] Concluído | [4] Cancelado");
        Console.Write("Opção: ");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1: ordem.Estado = "Pendente"; break;
            case 2: ordem.Estado = "Em Andamento"; break;
            case 3: ordem.Estado = "Concluído"; break;
            case 4: ordem.Estado = "Cancelado"; break;
            default: Console.WriteLine("Opção inválida. Nada foi alterado."); return;
        }
        Console.WriteLine($"Status da Ordem do serviço #{idBuscado} atualizado para {ordem.Estado} com sucesso");
    }

    static void RelatorioFinanceiro()
    {
        double total = bancoDeDados.Sum(ordem=>ordem.ValorOrcado);
        Console.WriteLine($"Total Financeiro: {total}");
        Console.WriteLine("total em ordem de serviço por status: ");
        var agrupamento = bancoDeDados.GroupBy(ordem=>ordem.Estado);
        foreach(var grupo in agrupamento)
        {
            double totalPorStatus = grupo.Sum(ordem=>ordem.ValorOrcado);
            Console.WriteLine($"{grupo.Key}: {totalPorStatus}");
        }
    }

    public static void Main(string[] args)
    {
        bool sair = false;
        while (!sair)
        {
            Console.WriteLine("================ Sistema Oficina ================");
            Console.WriteLine("[1] Cadastrar nova ordem");
            Console.WriteLine("[2] Mostrar Tudo");
            Console.WriteLine("[3] Alterar Status");
            Console.WriteLine("[4] Relatório Financeiro");
            Console.WriteLine("[5] Sair");
            Console.Write("Digite sua Opção: ");

            // Dica: Use TryParse para evitar que o programa feche se digitar letra
            if (!int.TryParse(Console.ReadLine(), out int opcao)) continue;

            switch (opcao)
            {
                case 1: CadastrarNovaOrdem(); break;
                case 2: MostrarTodasInformacoes(); break;
                case 3: AlterarStatus(); break;
                case 4: RelatorioFinanceiro(); break;
                case 5: sair = true; break;
            }
        }
    }
}