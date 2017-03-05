package by.pavlenko;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) throws FileNotFoundException {

        Scanner sc = new Scanner(new File("input.txt"));
        PrintWriter pw = new PrintWriter(new File("output.txt"));

        int size = Integer.valueOf(sc.nextLine());
        Scanner scanner = new Scanner(sc.nextLine());

        List<Integer> list = new ArrayList<>();
        while (scanner.hasNextInt()) {
            list.add(scanner.nextInt());
        }

        matchProblem mp = new matchProblem(size, list);
        System.out.println(mp.toString());

        pw.print(mp.toString());
        pw.close();

    }
}

class matchProblem {
    private int sizeArray;
    private List<Integer> array;

    public matchProblem(int sizeArray, List<Integer> array) {
        this.sizeArray = sizeArray;
        this.array = array;

        checkArrayNumbers();
        checkSizeOfListSize();
    }

    int getSumPositiveNumbers() {
        int sum = 0;
        for (Integer temp : this.array) {
            if (temp > 0) {
                sum += temp;
            }
        }
        if (checkTotal(sum)) {
            return sum;
        }
        return 0;
    }

    int getProductNumbersBetweenMinAndMax() {
        int sum = 1;
        int maxNam = Collections.max(array);
        int minNam = Collections.min(array);
        int maxMaps = 0;
        int minMaps = 0;

        for (int i = 0; i < array.size(); ++i) {
            if (array.get(i) == maxNam) {
                maxMaps = i;
            }
            if (array.get(i) == minNam) {
                minMaps = i;
            }
        }

        if (minMaps < maxMaps) {
            for (int i = minMaps + 1; i < maxMaps; ++i) {
                sum *= array.get(i);
            }
        } else {
            for (int i = maxMaps + 1; i < minMaps; ++i) {
                sum *= array.get(i);
            }
        }

        if (checkTotal(sum)) {
            return sum;
        }
        return 0;
    }

    @Override
    public String toString() {
        return getSumPositiveNumbers() + " " + getProductNumbersBetweenMinAndMax();
    }

    private boolean checkSizeOfListSize() {
        if (sizeArray == array.size()) {
            return true;
        }
        System.err.println("Error, checkSizeOfListSize");
        return false;
    }

    private boolean checkArrayNumbers() {
        double max = Math.pow(10, 2);

        if (sizeArray < max) {
            for (Integer temp : array) {
                if (temp < max) {
                    continue;
                } else
                    System.err.println("Error, checkArrayNumbers");
                return false;
            }
            return true;
        }
        System.err.println("Error, checkArraySize");
        return false;
    }

    private boolean checkTotal(int nam) {
        double max = 3 * Math.pow(10, 4);
        if (nam < max) {
            return true;
        }
        System.err.println("Error, checkTotal" + nam);
        return false;
    }
}