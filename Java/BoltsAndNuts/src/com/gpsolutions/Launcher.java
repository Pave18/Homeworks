package com.gpsolutions;

import java.io.*;

public class Launcher {
    public static void main(String[] args) {
        Damage d1 = new Damage(1000, 10, 100);
        Damage d2 = new Damage(1200, 20, 90);

        System.out.println(d1.Total());
        System.out.println(d2.Total());
        System.out.println(d1.Total() + d2.Total());

        try(FileReader reader = new FileReader("C:\\1.txt"))
        {
            // читаем посимвольно
            int c;
            while((c=reader.read())!=-1){

                System.out.print((char)c);
            }
        }
        catch(IOException ex){

            System.out.println(ex.getMessage());
        }
    }
}