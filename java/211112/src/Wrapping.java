class Box {
    public void Wrap() {
        System.out.println("Simple Wrapping");
    }
}
class PaperBox extends Box {
    public void Wrap() {
        super.Wrap();
        System.out.println("Paper Wrapping");
    }
}
class GoldPaperBox extends PaperBox{
    public void Wrap() {
        super.Wrap();
        System.out.println("Gold Wrapping");
    }
}
public class Wrapping {
    public static void main(String[] args) {
//        Box box1 = new Box();
//        PaperBox box2 = new PaperBox();
        GoldPaperBox box3 = new GoldPaperBox();
//        box1.Wrap();
//        box2.Wrap();
        box3.Wrap();
    }
}
