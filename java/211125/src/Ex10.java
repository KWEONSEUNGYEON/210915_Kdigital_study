import java.util.Arrays;

class Person implements Comparable {
    private String name;
    private int age;

    public Person(String name, int age) {
        this.name = name;
        this.age = age;
    }

     @Override
     public int compareTo(Object obj) {
    return this.age - ((Person) obj).age;
    }
    @Override
    public String toString() {
        return "Person{" +
                "name='" + name + '\'' +
                ", age=" + age +
                '}';
    }
}

public class Ex10 {
    public static void main(String[] args) {
        Person people[] = new Person[3];
        people[0] = new Person("aa",20);
        people[1] = new Person("bb",10);
        people[2] = new Person("cc",5);
        Arrays.sort(people);
        for(Person p : people) {
            System.out.println(p);
        }

    }
}
