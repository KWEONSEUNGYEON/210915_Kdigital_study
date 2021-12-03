import java.lang.annotation.*;
import java.lang.reflect.Field;
import java.lang.reflect.Method;

@Target({ElementType.FIELD, ElementType.METHOD, ElementType.TYPE})
@Retention(RetentionPolicy.RUNTIME)

@interface MyAnnotation{
    String a() default "aa";
    int b() default 10;
}
@MyAnnotation(a="Ex01", b=400)
public class Ex01 {
    Ex01(){
        Field fields[] = this.getClass().getDeclaredFields(); //변수 가져온느 함수
        for(Field f : fields) {
            System.out.println(f);
            Annotation ao = f.getAnnotation(MyAnnotation.class);
            System.out.println(ao);
        }
        Method methods[] = this.getClass().getDeclaredMethods(); //메서드 가져오는 함수
        for(Method f : methods) {
            System.out.println(f);
            Annotation ao = f.getAnnotation(MyAnnotation.class);
            System.out.println(ao);
        }
        MyAnnotation[] ma = this.getClass().getAnnotationsByType(MyAnnotation.class); //Ex01클래스에 붙은 어노테이션 가져오는 함수
        System.out.println(ma[0].a());
        System.out.println(ma[0].b());
    }

    @MyAnnotation
    String s1 = "f";
    @MyAnnotation(a = "aaa", b = 20)
    int s2 = 10;

    @MyAnnotation(a = "doAmethod", b = 30)
    public void doA()
    {

    }
    public static void main(String[] args) {
        new Ex01();
    }

}
