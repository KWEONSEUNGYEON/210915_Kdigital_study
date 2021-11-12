/*
생략가능
1. import java.lang.*;
2.super()
3.toString()
4.this. super
5.extends Object -> 자바에서 최상위 클래스
6. @Override
 */

import java.lang.*;

class MobilePhone extends Object{
    int number;
    public MobilePhone(){}
    MobilePhone(int number) {
        this.number = number;
    }
    public String toString() {
        return "MobilePhone{" +
                "number=" + number +
                '}';
    }
    public void answer() {
        System.out.println("Hi from "+ number);
    }
}
public class SmartPhone extends MobilePhone {

    private String androidVer;
    SmartPhone(int num, String androidVer) {
        super(num);
        this.androidVer = androidVer;
    }
    public void playApp() {
        System.out.println("안드로이드 몇버젼 = "+androidVer);
    }
    public static void main(String[] args) {
        MobilePhone mp = new MobilePhone(123);
        System.out.println(mp);
        mp.answer();

        SmartPhone sp = new SmartPhone(400, "9버전");
        System.out.println(sp);
        sp.answer();
        sp.playApp();

        MobilePhone mps = new SmartPhone(500, "10버전");
        mps.answer();

        Object a = new MobilePhone();
        Object b = new SmartPhone(600, "11");

        ((MobilePhone)a).answer();
        ((SmartPhone)b).playApp();
    }
}
