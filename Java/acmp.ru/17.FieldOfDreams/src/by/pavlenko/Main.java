package by.pavlenko;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) throws FileNotFoundException {
        Scanner sc = new Scanner(new File("input.txt"));
        PrintWriter pw = new PrintWriter(new File("output.txt"));

        int size = Integer.valueOf(sc.nextLine());
        Scanner scanner = new Scanner(sc.nextLine());

        int[] list = new int[size];
        for (int i = 0; i < size - 1; ++i) {
            list[i] = scanner.nextInt();
        }

        --size;

        for (int i = 1; i < size - 1; ++i) {
            if (size % i == 0) {
                int j = 0;

                while ((list[j % i] == list[j]) && (j < size)) {
                    j = j + 1;
                    if (j == size) {
                        size = i;
                        break;
                    }
                }
            }
        }


        System.out.println(size);

        pw.print(size);
        pw.close();
    }
}
