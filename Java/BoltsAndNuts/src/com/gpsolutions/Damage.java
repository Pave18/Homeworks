package com.gpsolutions;

import java.io.*;

public class Damage {
    int bolts;
    float percent;
    int price;

    public Damage(int bolts, float percent, int price) {
        this.bolts = bolts;
        this.percent = percent;
        this.price = price;
    }

    public int Total() {

        if (Check() == 0) {
            return (int) (this.bolts * (this.percent / 100) * this.price);
        } else {
            return 0;
        }
    }

    public void WrittenInTxt() {
        try (FileWriter writer = new FileWriter("C:\\OUTPUT.txt", false)) {
            writer.write(Total());
        } catch (IOException ex) {

            System.out.println(ex.getMessage());
        }
    }

    private int Check() {
        if (this.bolts % 100 == 0 && this.bolts >= 100 && this.bolts <= 30000) {
            if (this.percent >= 0 && this.percent <= 100) {
                if (this.price >= 1 && this.price <= 100) {
                    return 0;
                } else {
                    System.err.println("Error, incorrectly specified price.");
                    return 1;
                }
            } else {
                System.err.println("Error, the percentage of wrong.");
                return 1;
            }
        } else {
            System.err.println("Error, incorrectly listed the bolts.");
            return 1;
        }
    }
}

