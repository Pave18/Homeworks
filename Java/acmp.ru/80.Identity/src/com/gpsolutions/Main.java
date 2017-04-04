package com.gpsolutions;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.Scanner;

public class Main {
    static String s;
    static char znak;
    static int a = 0, b = 0, c = 0;
    static int i, k, x = 0;

    public static void main(String[] args) throws FileNotFoundException {
        PrintWriter pw = new PrintWriter(new File("output.txt"));

        try {
            Scanner sc = new Scanner(new File("input.txt"));
            while (sc.hasNextLine()) {
                s = sc.nextLine();
                String ans = answer();

                System.out.println(ans);

                pw.print(ans);
                pw.close();
            }
        }catch (FileNotFoundException e) {
            System.out.println(e.toString());
        }finally {
            System.out.println("ERROR");
            pw.print("ERROR");
            pw.close();
        }
    }

    public static String answer() {


        k = s.length();
        for (i = 0; i < k; i++) {
            if (s.charAt(i) < 48 || s.charAt(i) > 58) {
                if (s.charAt(i) != '+' & s.charAt(i) != '-' & s.charAt(i) != '/' & s.charAt(i) != '*' & s.charAt(i) != '=') {
                    return "ERROR";
                }
            }
        }
        if(s.charAt(k-1) == '='){
            return "ERROR";
        }
        i = 0;
//* ***** a ***** *//*
        x = 1;
        if (s.charAt(0) == '-') {
            x = -1;
            i++;
        }
        if (s.charAt(0) == '+') {
            x = 1;
            i++;
        }

        while (s.charAt(i) != '+' & s.charAt(i) != '-' & s.charAt(i) != '/' & s.charAt(i) != '*' & s.charAt(i) != '=' & s.charAt(i) != 0) {
            a = a * 10;
            a = a + s.charAt(i) - 48;
            i++;
        }
        a = a * x;

        if (s.charAt(i) == 0 || s.charAt(i) == '=') {
            return "ERROR";
        }


        znak = s.charAt(i);
/* ***** b ***** */
        i++;
        if (s.charAt(i) == '/' | s.charAt(i) == '*' | s.charAt(i) == 0 | s.charAt(i) == '=') {
            return "ERROR";
        }
        x = 1;
        if (s.charAt(i) == '-') {
            x = -1;
            i++;
        }
        if (s.charAt(i) == '+') {
            x = 1;
            i++;
        }
        while (s.charAt(i) != '=' & s.charAt(i) != 0) {
            if (s.charAt(i) == '+' | s.charAt(i) == '-' | s.charAt(i) == '/' | s.charAt(i) == '*' | s.charAt(i) == 0) {
                return "ERROR";
            }
            b = b * 10;
            b = b + (s.charAt(i) - 48);
            i++;
        }
        b = b * x;
        if (s.charAt(i) == 0 || s.charAt(i) != '=') {
            return ("ERROR");
        }

//* ***** c ***** *//*
        i++;
        x = 1;
        if (s.charAt(i) == '-') {
            x = -1;
            i++;
        }
        if (s.charAt(i) == '+') {
            x = 1;
            i++;
        }
        if (s.charAt(i) == 0) {
            return "ERROR";
        }
        while (s.charAt(i) != 0 & s.charAt(i) >= 48 & s.charAt(i) <= 58) {
            c = c * 10;
            c = c + (s.charAt(i) - 48);
            if (i < s.length() - 1)
                i++;
            else
                break;
        }
        c = c * x;
//* p*r*o*v*e*r*k*a *//*
        if (znak == '+') {
            if (a + b == c) {
                return ("YES");
            } else {
                return ("NO");
            }
        }
        if (znak == '-') {
            if (a - b == c) {
                return ("YES");
            } else {
                return ("NO");
            }
        }
        if (znak == '*') {
            if (a * b == c) {
                return ("YES");
            } else {
                return ("NO");
            }
        }
        if (znak == '/') {
            if (b == 0) {
                return ("NO");
            }
            if (a / b == c & a % b == 0) {
                return ("YES");
            } else {
                return ("NO");
            }
        }
        return "ERROR";
    }
}
