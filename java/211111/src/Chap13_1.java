public class Chap13_1 {
    public static void addOneDArr(int[] arr, int add) {
        for(int i = 0; i <arr.length; i++)
            arr[i] += add;
    }
    public static void addTwoDArr(int[][] arr, int add) {
        for (int temp_arr[] : arr) {
            addOneDArr(temp_arr, add);
        }

    }
    public static void main(String[] args) {
//        int arr[] = {10, 5, 3, 2, 7};
//        int add = 4;
//        addOneDArr(arr, add);
//        for(int temp : arr) System.out.println("temp = "+temp);
        int darr[][] = {{10,5,2},{1,2,3,4},{6,7,8,9,10}};
        int add = 4;

        for (int temp_arr[] : darr) {
            for (int temp : temp_arr)
                System.out.println("temp = "+temp);
            System.out.println();
        }
        addTwoDArr(darr, add);
        System.out.println("변경후");
        for (int temp_arr[] : darr) {
            for (int temp : temp_arr)
                System.out.println("temp = "+temp);
            System.out.println();
        }
    }
}
