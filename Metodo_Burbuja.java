//Import Scanner
import java.util.Scanner;

public class Metodo_Burbuja {
    public static void main(String arg[]){
        //Inicializar Scanner
        Scanner sc = new Scanner(System.in);
            //Crear las Variables que Alojen los Numeros a Ordenar
            int n1, n2, n3, n4, n5;
            //Recoger la Informacion desde la Consola
            System.out.println("Primer Numero: "); n1 = sc.nextInt();
            System.out.println("Segundo Numero: "); n2 = sc.nextInt();
            System.out.println("Terver Numero: "); n3 = sc.nextInt();
            System.out.println("Cuarto Numero: "); n4 = sc.nextInt();
            System.out.println("Quinto Numero: "); n5 = sc.nextInt();
            //Guardar los Numeros en una lista
            int nums[]= {n1,n2,n3,n4,n5};
            //Imprime los Numeros a Ordenar
            System.out.print("Los Numeros a Ordenar: ");
            for(int i=0;i<nums.length;i++){
                System.out.print(nums[i]+" ");
            }
            //Ordenar los Numeros
            for(int i=0; i < nums.length-1; i++){
                   for(int j=0; j < (nums.length-1-i); j++){  
                        if(nums[j] > nums[j+1]){  
                                int aux=nums[j];                 
                                nums[j]=nums[j+1];           
                                nums[j+1]=aux;
                         }    
                   }
              }
            }
}