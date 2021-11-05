//questions2.txt

//5번

//ctrl + z 뒤로가기
//ctrl + y 앞으로 가기
//Redo
//java에서는 class명이랑 파일명이 동일해야함 alt + enter

import java.util.Scanner;

public class MonthSchedule {
    public static void main(String[] args) {
        Day day[] = new Day[100];

        System.out.println("이번달 스케쥴 관리 프로그램.");
        System.out.println("할일(입력:1, 보기:2, 끝내기:3)");
        day[0] = new Day();
        day[1] = new Day();
        System.out.println("day[0] = "+day[0]);
        System.out.println("day[1] = "+day[1]);

        Scanner.scan = new Scanner(System.in);
//        scan.nextInt()

//        System.out.println("시작");
//        Day day1 = new Day();
//        day1.setWork("영화보기");
//        day1.show();
    }
}
