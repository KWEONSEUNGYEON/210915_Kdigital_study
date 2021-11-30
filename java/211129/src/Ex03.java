import java.util.ArrayList;
import java.util.List;

class Row{
    private String name;
    private int kor;
    private int eng;
    private int math;
    private int total;

    public Row(String name, int kor, int eng, int math) {
        this.name = name;
        this.kor = kor;
        this.eng = eng;
        this.math = math;
        this.total = kor + eng + math;
    }

    @Override
    public String toString() {
        return "Row{" +
                "name='" + name + '\'' +
                ", kor=" + kor +
                ", eng=" + eng +
                ", math=" + math +
                ", total=" + total +
                '}';
    }
}

public class Ex03 {
    public static void main(String[] args) {

        List<Row> al = new ArrayList<>();
        al.add(new Row("aa", 100, 80, 70));
        al.add(new Row("bbb", 90, 80, 60));
        al.add(new Row("cccc", 80, 70, 50));

        System.out.println(al);


    }
}
