package com.gpsolutions;

public class SumDamage {
    private int bolts;
    private int boltsPercent;
    private int boltsPrice;
    private int nuts;
    private int nutsPercent;
    private int nutsPrice;
    private int result;

    public SumDamage(int bolts, int boltsPercent, int boltsPrice, int nuts, int nutsPercent, int nutsPrice) {
        this.bolts = bolts;
        this.boltsPercent = boltsPercent;
        this.boltsPrice = boltsPrice;
        this.nuts = nuts;
        this.nutsPercent = nutsPercent;
        this.nutsPrice = nutsPrice;
    }

    public int total() {
        result = 0;
        if (checkValues(this.bolts, this.boltsPercent, this.boltsPrice)
                && checkValues(this.nuts, this.nutsPercent, this.nutsPrice)) {

            result += this.bolts * this.boltsPercent / 100 * this.boltsPrice;
            result += this.nuts * this.nutsPercent / 100 * this.nutsPrice;
            result += priceDifference();

            return result;
        }
        return result;
    }

    private int priceDifference() {
        int difference = (this.bolts * (100 - this.boltsPercent) / 100) - (this.nuts * (100 - this.nutsPercent) / 100);

        if (difference > 0) {
            return (difference * this.boltsPrice);
        } else if (difference < 0) {
            return ((difference * -1) * this.nutsPrice);
        } else {
            return 0;
        }
    }

    private boolean checkValues(int boltsAndNuts, int percent, int price) {
        int multiplicity = 100;
        int minBoltsAndNuts = 100;
        int maxBoltsAndNuts = 30000;
        int minPercentage = 0;
        int maxPercentage = 100;
        int minPrice = 1;
        int maxPrice = 100;



        if (boltsAndNuts % multiplicity == 0
                && boltsAndNuts >= minBoltsAndNuts
                && boltsAndNuts <= maxBoltsAndNuts) {
            if (percent >= minPercentage
                    && percent <= maxPercentage) {
                if (price >= minPrice
                        && price <= maxPrice) {
                    return true;
                } else {
                    System.err.println("Error, incorrectly specified price.");
                    return false;
                }
            } else {
                System.err.println("Error, the percentage of wrong.");
                return false;
            }
        } else {
            System.err.println("Error, incorrectly listed the bolts.");
            return false;
        }
    }
}

