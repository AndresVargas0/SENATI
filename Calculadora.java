//Importar Scanner
import java.util.Scanner;
//Crear la clase publica Calculadora
public class Calculadora {
    //Crear el Metodo Main para recibir los Argumentos
    public static void main(String[] args) {
        //Inicializar Scanner
        Scanner sc = new Scanner(System.in);
        //Creacion de Variables para los Numeros Ingresados
        float N1, N2;
        //Mostrar e Ingresar los Datos desde la Consola
        System.out.println("Primer Numero: "); N1 = sc.nextInt();
        System.out.println("Segundo Numero: "); N2 = sc.nextInt();
        //Operaciones
        float suma = N1+N2, resta = N1-N2, division = N1/N2, multiplicacion = N1*N2;
        //Imprimir Repuestas
        System.out.println("La Suma es: "+suma+
            "\nLa Resta es: "+resta+
            "\nLa Division es: "+division+
            "\nLa Multiplicacion es: "+multiplicacion);
    }
}