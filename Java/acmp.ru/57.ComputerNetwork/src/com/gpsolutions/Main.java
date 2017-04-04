package com.gpsolutions;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.Scanner;

public class Main {

    static int c, n, xt, yt;
    static int[] x = new int[1000];
    static int[] y = new int[1000];
    static double p;

    public static void main(String[] args) throws FileNotFoundException {
        Scanner sc = new Scanner(new File("input.txt"));
        PrintWriter pw = new PrintWriter(new File("output.txt"));

        Scanner scanner = new Scanner(sc.nextLine());
        n = scanner.nextInt();
        c = scanner.nextInt();
        p = scanner.nextDouble();

        for(int i=0; i<n; i++){
            Scanner scanner1 = new Scanner(sc.nextLine());
            x[i] = scanner1.nextInt();
            y[i] = scanner1.nextInt();
        }

        Scanner scanner2 = new Scanner(sc.nextLine());

        xt = scanner2.nextInt();
        yt = scanner2.nextInt();


        boolean r = f();

        System.out.println((r ? "YES" : "NO"));
        pw.print((r ? "YES" : "NO"));
        pw.close();
    }

    static boolean f() {
        double mins = p + 1;
        for (int i = 0; i < n; i++) {
            double s = 0;
            for (int j = 0; j < n; j++) {
                int dx = x[i] - x[j], dy = y[i] - y[j];
                s += Math.sqrt(dx * dx + dy * dy);
                if (s > mins) break;
            }
            int dx = x[i] - xt, dy = y[i] - yt;
            s += Math.sqrt(dx * dx + dy * dy);
            mins = s < mins ? s : mins;
        }
        return c * mins <= p;
    }
}
