class MyException extends Exception{
    MyException(){
        super("나만의 예외.....");

    }
}

public class Ex05 {
    public static void main(String[] args) throws MyException {
        int a = 30;
        if(a>=30)
            throw new MyException();
    }
}
