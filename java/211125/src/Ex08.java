import java.util.Arrays;

public class Ex08 {

    public static void main(String[] args) {
        double[] arOrg = {1.1, 2.2, 3.3, 4.4, 5.5};

//        double[] arcpy1 = arOrg;
        double[] arcpy1 = Arrays.copyOf(arOrg, arOrg.length);
        arcpy1[0] = 3.3;

        for(double elem : arOrg) {
            System.out.println(elem + "\t");
        }
        System.out.println();

        for(double elem : arcpy1) {
            System.out.println(elem + "\t");
        }
        System.out.println();
    }
}
