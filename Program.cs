
using _20._09._2022;







Car[] cars = new Car[]
{
    new Car("Japan_Life", "Mercedes-Benz Atego 815", 100, TypeCar.cargo),
    new Car("Japan_Life", "VOLVO FMX-500-10X4", 90, TypeCar.cargo),
    new Car("Lamborghini", "Diablo GTR", 340, TypeCar.passenger),
    new Car("McLaren", "720S", 341, TypeCar.passenger),
    new Car("Iveco Defense Vehicles", "LMV", 130, TypeCar.military),
    new Car("Bibika", "Vruum", 9999, TypeCar.undefined)
};

Console.WriteLine("Вывести все машины на экран ");
foreach (Car car in cars)
{
    car.ToString();
}

Console.WriteLine("Вывести сумму скоростей машин");
double sum=0;
foreach (Car car in cars)
{
    sum+=car.Speed;
}
Console.WriteLine(sum);

Console.WriteLine("Вывести ТОЛЬКО грузовые машины из массива");

foreach (Car car in cars)
{
    if(car.Type == TypeCar.cargo)
    {
        car.ToString();
    }
}










