public class ArrayUtil {
    public static int[] concat(int[] a, int[] b) {
        int temp[] = new int[a.length+b.length];
        int index = 0;
        for(int atemp : a) {
            temp[index] = atemp;
            index += 1;
        }
        for(int btemp : b)
            temp[index++] = btemp;
        return temp;
    }
    public static void print(int[] a) {
        System.out.print("[ ");
        for(int temp : a)
            System.out.print(temp+" ");
        System.out.println("]");
    }
}

class StaticEx {

    public static void main(String[] args) {
        // TODO Auto-generated method stub
        int[] array1 = {1, 5, 7, 9};
        int[] array2 = {3, 6, -1, 100, 77};
        int[] array3 = ArrayUtil.concat(array1, array2);
        ArrayUtil.print(array3);
    }

}