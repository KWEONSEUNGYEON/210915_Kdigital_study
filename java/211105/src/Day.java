public class Day {

    private String work; //하루의 할 일을 나타내는 문자열

    // alt + insert

    @Override
    public String toString() {
        return "Day{" +
                "work='" + work + '\'' +
                '}';
    }

    public String getWork() {
        return work;
    }

    public void setWork(String work) {
        this.work = work;
    }

    public void set(String work) {
        this.work = work;
    }

    public String get() {
        return work;
    }

    public void show() {
        if(work == null) System.out.println("없습니다.");
        else System.out.println(work+"입니다.");
    }

}
