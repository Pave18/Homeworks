package com.gpsolutions;

public class Damage {
    int bolts;
    int percent;
    int price;

    public Damage(int bolts, int percent, int price) {
        this.bolts = bolts;
        this.percent = percent;
        this.price = price;
    }

    public int Check() {
        if (this.bolts % 100 == 0 && this.bolts >= 100 && this.bolts <= 30000) {
            System.out.println("Bolts Ok");

            if (this.percent >= 0 && this.percent <= 100) {
                System.out.println("Percent Ok");

                if (this.price >= 1 && this.price <= 100) {
                    System.out.println("Price Ok");
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

