//1번 문제

import java.util.Scanner;

class Phone {
    private String name;
    private String tel;

    public Phone(String name, String tel) {
        this.name = name;
        this.tel = tel;
    }

    public String getName() {
        return name;
    }

    public String getTel() {
        return tel;
    }
}

public class PhoneBook {
    PhoneBook() {
        Scanner scan = new Scanner(System.in);

        System.out.print("인원수 >> ");
        int arrsize = scan.nextInt();
        Phone phones[] = new Phone[arrsize];
        System.out.println("phones.length = " + phones.length);
        System.out.println("phones.length = " + phones.length);
        System.out.println("phones.length = " + phones.length);

        scan.nextLine(); //입력버퍼에 있는 엔터키 지우기

        for (int i = 0; i < arrsize; i++) {
            System.out.print("이름과 전화번호(이름과 번호 입력) >> ");
            String temp = scan.nextLine();
            String name_tel[] = temp.split("\\s"); // "\\s" 띄어쓰기 기준으로 자르기
//            System.out.println(name_tel[0]);
//            System.out.println(name_tel[1]);
            phones[i] = new Phone(name_tel[0], name_tel[1]);
        }
        System.out.println("저장되었습니다...");
        while (true) {
            System.out.println("검색할 이름? ");
            String sel = scan.nextLine();
            if(sel.equals("exit")) {
                System.out.println("종료되었습니다..");
                break;
            }
            int success = 0;
            for (Phone temp : phones) {
                if (temp.getName().equals(sel)) {
                    System.out.println("검색성공");
                    success = 1;
                    System.out.println(temp.getName());
                    System.out.println(temp.getTel());
                    break;
                }
            }
            if (success == 0) {
                System.out.println("검색이 실패하였습니다..");
            }
        }
    }

    public static void main(String[] args) {
        new PhoneBook();
    }
}
