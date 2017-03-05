package com.gpsolutions;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) throws FileNotFoundException {

        Scanner sc = new Scanner(new File("input.txt"));
        PrintWriter pw;

        int size = Integer.valueOf(sc.nextLine());
        Scanner scanner = new Scanner(sc.nextLine());

        List<Integer> list = new ArrayList<>();
        while (scanner.hasNextInt()) {
            list.add(scanner.nextInt());
        }

        VasiaStatistics vs = new VasiaStatistics(size, list);
        vs.runAnalyze();

        pw = new PrintWriter(new File("output.txt"));
        pw.print(vs.toString());

        pw.close();
    }
}

class VasiaStatistics {
    private int sizeDaysList;
    private List<Integer> daysList;
    private List<Integer> positiveDays;
    private List<Integer> negativeDays;
    private String yesOrNo;


    public VasiaStatistics(int sizeDaysList, List<Integer> daysList) {
        this.sizeDaysList = sizeDaysList;
        this.daysList = daysList;

        this.positiveDays = new ArrayList<>();
        this.negativeDays = new ArrayList<>();
    }



    public void runAnalyze() {
        if (checkDays() && checkSizeArrDays() && checkSizeOfListSize()) {
            for (Integer temp : daysList) {
                if (temp % 2 == 0) {
                    positiveDays.add(temp);
                } else {
                    negativeDays.add(temp);
                }
            }
        }
        getYesOrNo();
    }

    private String getYesOrNo() {
        if(positiveDays.size()>= negativeDays.size()){
            yesOrNo = "YES";
        }else
            yesOrNo = "NO";

        return yesOrNo;
    }

    private boolean checkSizeArrDays() {
        if (sizeDaysList >= 1 && sizeDaysList <= 100) {
            return true;
        }
        return false;
    }

    private boolean checkDays() {
        for (Integer arr : daysList) {
            if (arr >= 1 && arr <= 31) {
                continue;
            } else
                return false;
        }
        return true;
    }

    private boolean checkSizeOfListSize() {
        if (sizeDaysList == daysList.size()) {
            return true;
        }
        return false;
    }

    @Override
    public String toString() {
        String output = negativeDays + "\n"
                + positiveDays + "\n"
                + yesOrNo;

        return output = output.replaceAll(",","").replaceAll("\\[","").replaceAll("\\]","");
    }

}