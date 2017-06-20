import java.util.Scanner;

class ImparOuPar {
    public static void main(String[] args) {
          int num;
        try (final Scanner scanner = new Scanner(System.in)) {
            System.out.println("Informe um número");
            num = scanner.nextInt();
            if(num % 2 == 0){
                System.out.println("Par");
            }
            else
            {
                System.out.println("Impar");
            }
        } catch (Exception e) {
            //...
        }
    }
}