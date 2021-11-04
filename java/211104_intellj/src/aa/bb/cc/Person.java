package aa.bb.cc;

public class Person {
    //기본생성사는 생략...
    private String name;
    public Person() {}
    public Person(String n){
        name = n;
    }

    //alt + insert 소스 자동완성 단축키
    //소스 자동 완성 문법 많이 쓰는 3가지
    //1. setter
    //2. getter
    //3. constructor
    //4. toString

    //자동완성
    @Override
    public String toString() {
        return "Person{ name : "+name+"}";
    }

//직접 작성
//  public String toString() {
//      return "Person";
//  }
}
