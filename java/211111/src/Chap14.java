class Car {
    int gasolineGauge;
    public Car(int gg) {
        this.gasolineGauge = gg;
    }
}
class HybridCar extends Car {
    int electricGauge;
    HybridCar(int gg, int eg) {
        super(gg);
        this.electricGauge = eg;
    }
}
class HybridWaterCar extends HybridCar {
    int waterGauge;
    HybridWaterCar(int gg, int eg, int wg) {
        super(gg, eg);
        this.waterGauge = wg;
    }
    public void showCurrentGauge() {
        System.out.println("잔여 가솔린: "+ gasolineGauge);
        System.out.println("잔여 전기량: "+ electricGauge);
        System.out.println("잔여 워터량: "+ waterGauge);
    }
}
public class Chap14 {
    public static void main(String[] args) {
        HybridWaterCar hwC = new HybridWaterCar(10,20,30);
        hwC.showCurrentGauge();
    }
}
