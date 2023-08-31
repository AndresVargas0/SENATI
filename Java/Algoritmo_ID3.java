import java.util.Scanner;

class NodoDecision {
    String decision;
    NodoDecision si;
    NodoDecision no;

    NodoDecision(String decision) {
        this.decision = decision;
        this.si = null;
        this.no = null;
    }
}

public class Algoritmo_ID3 {
    public static void main(String[] args) {
        NodoDecision arbol = construirArbolDecision();
        Scanner scanner = new Scanner(System.in);
        System.out.print("¿Está soleado? (si/no): ");
        String respuesta = scanner.nextLine().trim();
        scanner.close();
        realizarDecision(arbol, respuesta);
    }

    public static NodoDecision construirArbolDecision() {
        NodoDecision raiz = new NodoDecision("¿Está soleado?");
        raiz.si = new NodoDecision("Salir a caminar");
        raiz.no = new NodoDecision("No salir a caminar");
        return raiz;
    }

    public static void realizarDecision(NodoDecision nodo, String respuesta) {
        System.out.println(nodo.decision);
        NodoDecision siguienteNodo = (respuesta.equalsIgnoreCase("si")) ? nodo.si : nodo.no;
        if (siguienteNodo != null) {
            System.out.println("Decisión: " + siguienteNodo.decision);
        } else {
            System.out.println("No se encontró una rama para la respuesta " + respuesta);
        }
    }
}