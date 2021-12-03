interface MyInter{
    void doA();
}
class A implements MyInter{
    @Override
    public void doA() {}
}

public class Ex02 {
    public static void main(String[] args) {
        A a = new A();
        MyInter m1 = new MyInter() {
            @Override
            public void doA(){
                System.out.println("m1");
            }
        };
        m1.doA();
        MyInter m2 = new MyInter() {
            @Override
            public void doA(){
                System.out.println("m2");
            }
        };
        m2.doA();
    }
}
