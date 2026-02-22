public class Singleton {

    private static Singleton instancia;

    // Constructor privado
    private Singleton() {}

    // Método para obtener la única instancia
    public static Singleton getInstancia() {
        if (instancia == null) {
            instancia = new Singleton();
        }
        return instancia;
    }

    public void mensaje() {
        System.out.println("Instancia Singleton funcionando");
    }
}