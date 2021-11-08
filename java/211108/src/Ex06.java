public class Ex06 {
    public static void main(String[] args) {
        int arr[][]= {
                {11},
                {11,22},
                {11,22,33}
        };
        System.out.println(arr.length);
        System.out.println(arr[0].length);
        System.out.println(arr[1].length);
        System.out.println(arr[2].length);

        for(int i = 0; i<arr.length; i++) {
            for(int j =0; j < arr[i].length; j++){
                System.out.print(arr[i][j]+" ");
            }
            System.out.println();
        }
    }
}
