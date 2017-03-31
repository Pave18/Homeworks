package by.pavlenko;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) throws FileNotFoundException {
        Scanner sc = new Scanner(new File("input.txt"));
        PrintWriter pw = new PrintWriter(new File("output.txt"));


        Scanner scanner1 = new Scanner(sc.nextLine());
        Scanner scanner2 = new Scanner(sc.nextLine());

        String p1 = scanner1.nextLine();
        String p2 = scanner2.nextLine();

        int N = 1;

        for (int i = 0; i < p1.length();++i ){
            N = N * Cross(Mould(p1.charAt(i)), Mould(p2.charAt(i)));
        }

        System.out.println(N);


         pw.print(N);
        pw.close();
    }

    static String Mould(char c) {
        String s = "0123456789";

        if (s.indexOf(c) != -1)
            return String.valueOf(c);
        if (c == 'a')
            return "0123";
        if (c == 'b')
            return "1234";
        if (c == 'c')
            return "2345";
        if (c == 'd')
            return "3456";
        if (c == 'e')
            return "4567";
        if (c == 'f')
            return "5678";
        if (c == 'g')
            return "6789";
        if (c == '?')
            return "0123456789";
        return "";
    }

    static byte Cross(String str1, String str2) {
        byte  n = 0;

        for (int i = 0; i < str1.length(); ++i){
            if(str2.indexOf(str1.charAt(i)) != -1){
                ++n;
            }
        }

        return n;
    }

}
