import java.util.Scanner;

class MySnackStore {
    public static void main(String[] args) {
        System.out.println("Welcome to My Snack Store!"); 
        printMenuCategories();
         
        try (Scanner in = new Scanner(System.in)) {
            int option = 0;
            do {
                System.out.print("Your option >>> ");
                option = in.nextInt();

                switch (option) {
                    case 1:
                        printSnacksMenu();
                        break;
                    case 2:
                        printBeveragesMenu();
                        break;
                    case 3:
                        printDessertsMenu();
                        break;
                }
            } while (option != 0);
        }
    }

    public static void printMenuCategories() {
        System.out.println("Today's Menu:"); 
        System.out.println("---------------------------");
        System.out.println("[1] Snacks"); 
        System.out.println("[2] Beverages"); 
        System.out.println("[3] Desserts"); 
        System.out.println("---------------------------");
    }

    public static void printSnacksMenu() {
        System.out.println("Snacks Menu:"); 
        System.out.println("---------------------------");
        System.out.println("[1] Santitas Chips"); 
        System.out.println("[2] Tostitos"); 
        System.out.println("[3] Calidad"); 
        System.out.println("---------------------------");
    }

    public static void printBeveragesMenu() {
        System.out.println("Beverages Menu:"); 
        System.out.println("---------------------------");
        System.out.println("[1] Coca Cola"); 
        System.out.println("[2] Iced Tea"); 
        System.out.println("[3] Topo Chico"); 
        System.out.println("---------------------------");
    }

    public static void printDessertsMenu() {
        System.out.println("Desserts Menu:"); 
        System.out.println("---------------------------");
        System.out.println("[1] Strawberry Cheesecake"); 
        System.out.println("[2] Chocolate Fudge"); 
        System.out.println("[3] Ice Cream"); 
        System.out.println("---------------------------");
    }
}