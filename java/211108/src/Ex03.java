public class Ex03 {
    public static void main(String[] args) {
        System.out.println("java.length = "+"java".length());
        String[] sr = new String[7];
        sr[0] = new String("java");
        sr[1] = new String("System");
        sr[2] = new String("Compiler");
        sr[3] = new String("Part");
        sr[4] = new String("Tree");
        sr[5] = new String("Dinner");
        sr[6] = new String("Brunch Cafe");

        int cnum = 0;
        for(String temp : sr) {
            cnum += temp.length();
        }
        System.out.println("cmum = "+cnum);
        String ar[] = new String[1];
        System.out.println(ar[0].length());
    }
}
