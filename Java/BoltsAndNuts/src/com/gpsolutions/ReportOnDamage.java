package com.gpsolutions;

import java.io.*;
import java.util.ArrayList;
import java.util.List;

public class ReportOnDamage {
    private SumDamage sumDamage;
    private List<Integer> valuesFromTxt;

    public ReportOnDamage() throws FileNotFoundException {
        valuesFromTxt = read("INPUT.TXT");

        sumDamage = new SumDamage(valuesFromTxt.get(0), valuesFromTxt.get(1), valuesFromTxt.get(2),
                valuesFromTxt.get(3), valuesFromTxt.get(4), valuesFromTxt.get(5));

        write("OUTPUT.TXT", String.valueOf(sumDamage.total()));
    }

    private static List<Integer> read(String fileName) throws FileNotFoundException {
        List<Integer> li = new ArrayList<Integer>();

        File file = new File(fileName);

        exists(fileName);

        try {

            BufferedReader in = new BufferedReader(new FileReader(file.getAbsoluteFile()));
            try {
                String s;
                while ((s = in.readLine()) != null) {
                    String[] tmp_arr = (s.split(" "));
                    for (int i = 0; i < tmp_arr.length; ++i) {
                        li.add(Integer.parseInt(tmp_arr[i]));
                    }
                }
            } finally {
                in.close();
            }
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
        return li;
    }

    private static void exists(String fileName) throws FileNotFoundException {
        File file = new File(fileName);
        if (!file.exists()) {
            throw new FileNotFoundException(file.getName());
        }
    }

    private static void write(String fileName, String text) {
        File file = new File(fileName);

        try {
            if (!file.exists()) {
                file.createNewFile();
            }

            PrintWriter out = new PrintWriter(file.getAbsoluteFile());

            try {
                out.print(text);
            } finally {
                out.close();
            }
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }
}
