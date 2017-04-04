package by.pavlenko;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) throws FileNotFoundException {
        Scanner sc = new Scanner(new File("input.txt"));
        PrintWriter pw = new PrintWriter(new File("output.txt"));

        String str = sc.nextLine();

        knightsMove mp = new knightsMove(str);
        System.out.println(mp.run());

        pw.print(mp.run());
        pw.close();

    }
}

class knightsMove {
    String move;
    String cols = "ABCDEFGH";
    String rows = "12345678";

    knightsMove(String move) {
        this.move = move;
    }

    public String run() {
        if (checkString()) {
            String[] a = move.split("-");
            return horseWay(a[0], a[1]);
        }
        return "ERROR";
    }

    private String horseWay(String aFrom, String aTo) {

        int xa = cols.indexOf(aFrom.charAt(0)), ya = rows.indexOf(aFrom.charAt(1));
        int xb = cols.indexOf(aTo.charAt(0)), yb = rows.indexOf(aTo.charAt(1));

        if ((Math.abs(xa - xb) != 2 || Math.abs(ya - yb) != 1) &&
                (Math.abs(xa - xb) != 1 || Math.abs(ya - yb) != 2)
                ) {
            return "NO";
        }
        return "YES";
    }

    private boolean checkString() {
        if (move.length() == 5 &&
                (cols.indexOf(move.charAt(0)) != -1 ||
                        rows.indexOf(move.charAt(1)) != -1 ||
                        move.charAt(2) == '-' ||
                        cols.indexOf(move.charAt(3)) != -1 ||
                        rows.indexOf(move.charAt(4)) != -1)) {
            return true;
        }
        return false;
    }
}
