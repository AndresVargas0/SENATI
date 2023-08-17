import java.util.Scanner;

public class Calculadora {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int N1;
        int N2;
        
        System.out.println("Primer Numero: ");
        N1 = sc.nextInt();
        
        System.out.println("Segundo Numero: ");
        N2 = sc.nextInt();
        
        int suma = N1 + N2;
        int resta = N1 - N2;
        int division = N1 / N2;
        int multiplicacion = N1 * N2;
        
       System.out.println("La suma es: "+suma+
               "\nLa resta es: "+resta+
               "\nLa Division es: "+division+
               "\nLa Multiplicacion es: "+multiplicacion);
    }
}
