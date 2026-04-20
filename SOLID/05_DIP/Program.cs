// VIOLAÇÃO DO DIP
public class EmailServiceErrado {
    public void Enviar(string mensagem) => Console.WriteLine("Enviando E-mail...");
}

public class PedidoErrado {
    private EmailServiceErrado _emailService = new EmailServiceErrado(); // Acoplamento forte

    public void Finalizar() {
        // Lógica de finalização...
        _emailService.Enviar("Pedido finalizado!");
    }
}


// CORREÇÃO DO DIP
// A Abstração
public interface INotificador {
    void Enviar(string mensagem);
}

// Implementações (Detalhes)
public class EmailService : INotificador {
    public void Enviar(string mensagem) => Console.WriteLine("E-mail enviado!");
}

public class SMSService : INotificador {
    public void Enviar(string mensagem) => Console.WriteLine("SMS enviado!");
}

// Classe de Alto Nível
public class Pedido {
    private readonly INotificador _notificador;

    // Injeção de Dependência: o Pedido não sabe QUEM envia, apenas que ALGUÉM envia.
    public Pedido(INotificador notificador) {
        _notificador = notificador;
    }

    public void Finalizar() {
        _notificador.Enviar("Pedido finalizado com sucesso!");
    }
}
