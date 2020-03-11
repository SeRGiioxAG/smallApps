package practica;
import java.util.Scanner;

public class Main {
//Global variables declaration:    
public static String scannedText;
public static int scannedInteger;
//Creation of our integer array with 100 possible values (more than enough).
public static int[] intsUllmanConjecture = new int[100];

    public static void main(String[] args) {
    //Ask the user for an integer to start realizing the Ullman Conjecture, then we will store it in the var.
	System.out.println("Please, enter an integer (>1) to realize the Ullman Conjecture:");
	Scanner keyboard = new Scanner(System.in);
	scannedText = keyboard.nextLine();
	//Assure it contains a valid number with the next if.
	if (scannedText.contains("1") || scannedText.contains("2") || scannedText.contains("3") || scannedText.contains("4") || scannedText.contains("5") || scannedText.contains("6") || scannedText.contains("7") || scannedText.contains("8") || scannedText.contains("9")) realizeConjecture();
    else {System.out.println("Remember to introduce a number larger than 1 the next time. ");}
    } 
    
    public static void realizeConjecture(){
        //We store the value the user introduced earlier in a new int variable.
        scannedInteger = Integer.parseInt(scannedText);
        intsUllmanConjecture[0] = scannedInteger;
        //A for iteration to fill the array and show the values.
        for (int i = 0; i < intsUllmanConjecture.length; i++) ullmanOperations(i,i+1);
    }
    
    public static void ullmanOperations(int i,int p){
        //Check if the number is even, make the operations and store it in the array.
        if (intsUllmanConjecture[i] % 2 == 0){
            int evenNumber = intsUllmanConjecture[i] / 2;
            intsUllmanConjecture[p] = evenNumber;
            System.out.println(intsUllmanConjecture[i]);
        }
        //Check if the number is odd, make the operations and store it in the array.
        if (intsUllmanConjecture[i] % 2 != 0){
            int oddNumber = intsUllmanConjecture[i] * 3 + 1;
            intsUllmanConjecture[p] = oddNumber;
            System.out.println(intsUllmanConjecture[i]);
        }
        if (intsUllmanConjecture[i] == 1){
            System.out.println("You reached the end on the conjecture.");
            System.exit(0);
        }
    }
}