using System;

// Clase existente (incompatible)
class EnchufeEuropeo {
    public void ConectarEuropeo() {
        Console.WriteLine("Conectado a enchufe europeo");
    }
}

// Interfaz esperada
interface IEnchufe {
    void Conectar();
}

// Adaptador
class Adaptador : IEnchufe {
    private EnchufeEuropeo enchufe;

    public Adaptador(EnchufeEuropeo enchufe) {
        this.enchufe = enchufe;
    }

    public void Conectar() {
        enchufe.ConectarEuropeo();
    }
}

// Programa principal
class Program {
    static void Main() {
        EnchufeEuropeo europeo = new EnchufeEuropeo();
        IEnchufe adaptador = new Adaptador(europeo);
        adaptador.Conectar();
    }
}