namespace DatatypesPractice
{
   
    public class Vehicle 
    {
        public  double DefaultFuelConsumption = 1.25;
        public int HorsePower { get; set; }

        public double Fuel { get; set; }
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }
        public virtual double FuelConsumption
           => DefaultFuelConsumption;
        public virtual void Drive(double kilometers)
        {
            var canDrive = this.Fuel - kilometers * this.FuelConsumption >= 0;
            if (canDrive)
            {
                this.Fuel -= kilometers * this.FuelConsumption;
            }
        }
    }
    public class MotorCycles : Vehicle
    {
        public MotorCycles(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }
        public override double FuelConsumption => DefaultFuelConsumption = 8;
        
    }

    public class Cars : Vehicle
    {
        public Cars(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }
        public override double FuelConsumption => DefaultFuelConsumption = 3;
    }
    public class RaceMotorCycles: MotorCycles 
    {
        public RaceMotorCycles(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }
    }
    public class CrossMotorCycles : MotorCycles
    {
        public CrossMotorCycles(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }
    }
    public class FamilyCar: Cars
    {
        public FamilyCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }
    }
    public class SportsCar : Cars
    {
        public SportsCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }
        public override double FuelConsumption => DefaultFuelConsumption = 10;
    }
}
