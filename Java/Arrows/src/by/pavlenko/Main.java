package by.pavlenko;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) throws FileNotFoundException {


        PrintWriter pw = new PrintWriter(new File("output.txt"));


        try {
            Scanner sc = new Scanner(new File("input.txt"));

            while (sc.hasNextLine()) {
                String str = String.valueOf(sc.nextLine());
                Arrows fod = new Arrows(str);
                System.out.println(fod.count());
                pw.print(fod.count());
                pw.close();
            }

        } catch (FileNotFoundException e) {
            System.out.println(e.toString());
        }finally {
            pw.print(0);
            pw.close();
        }


    }
}


class Arrows {

    private String str;
    private String arrow1 = "<--<<";
    private String arrow2 = ">>-->";
    private int count;

    public Arrows(String str) {
        this.str = str;
    }

    public int count() {
        count = 0;
        for (int i = 0; i < str.length(); ++i) {
            if (str.charAt(i) == '<' && i < str.length() - 4) {
                if (checkLeftArrow(i)) {
                    ++count;
                }
            }
            if (str.charAt(i) == '>' && i < str.length() - 4) {
                if (checkRightArrow(i)) {
                    ++count;
                }
            }
        }
        return count;
    }

    private boolean checkLeftArrow(int i) {
        for (int j = 0; j < arrow1.length(); ++j) {
            if (str.charAt(i + j) == arrow1.charAt(j)) {
                continue;
            }
            return false;
        }
        return true;
    }

    private boolean checkRightArrow(int i) {
        for (int j = 0; j < arrow2.length(); ++j) {
            if (str.charAt(i + j) == arrow2.charAt(j)) {
                continue;
            }
            return false;
        }
        return true;
    }
}
