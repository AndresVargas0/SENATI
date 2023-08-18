import java.util.Scanner;

public class Arbol_de_Decisiones {
    public static void main(String[] args){
        
        Scanner scanner = new Scanner(System.in);
        //Primera Pregunta
        System.out.println("¿Tienes Hambre? (si/no)");
        String respuesta1 = scanner.nextLine();
        //Opcion "si" Primera Pregunta
        if (respuesta1.equalsIgnoreCase("si")){
            //Segunda Pregunta
            System.out.println("¿Quieres una Pizza? (si/no)");
            String respuesta2 = scanner.nextLine();
            //Opcion "si" Segunda Pregunta
            if (respuesta2.equalsIgnoreCase("si")){
                //Ordenar Pizza
                System.out.println("Ordena una Pizza");
            //Opcion "no" Segunda Pregunta
            } else {
                //Tercera Pregunta
                System.out.println("¿Quieres una Amburguesa? (si/no)");
                String respuesta3 = scanner.nextLine();
                //Opcion "si" Tercera Pregunta
                if (respuesta3.equalsIgnoreCase("si")){
                    //Ordenar Amburguesa
                    System.out.println("Pide una Amburguesa");
                //Opcion "no" Tercera Pregunta
                } else {
                    //Decision Final
                    System.out.println("No hay mas Opciones");
                    //Cerrar Scanner
                    scanner.close();
                }
            }
        //Opcion "no" Primera Pregunta
        } else {
            System.out.println("Aun no Tienes Hambre");
        }
        //Cerrar Scanner
        scanner.close();
    }
}