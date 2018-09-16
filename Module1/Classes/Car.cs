public class Car
{
    public string Color { get; set; }
    public int Year { get; set; }
    public int Milage { get; set; }

    private static int instances = 0;

    public static int CountCars(){
        return instances;
    }

    public Car(){
        instances ++;
    }

    public Car(string color,int year){
        instances++;
        this.Color = color;
        this.Year = year;
    }     

    // secondary constructor
    public Car(int year,int milage){
        instances++;
        this.Year = year;
        this.Milage = milage;
    }
}