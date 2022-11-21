//1. Создать интерфейс IRobot с публичным методами string GetInfo() и List GetComponents(),
//   а также string GetRobotType() с дефолтной реализацией, возвращающей значение "I am a simple robot.".
//2. Создать интерфейс IChargeable с методами void Charge() и string GetInfo().
//3. Создать интерфейс IFlyingRobot как наследник IRobot с дефолтной реализацией GetRobotType(),
//   возвращающей строку "I am a flying robot.".
//4. Создать класс Quadcopter, наследующий IFlyingRobot и IChargeable.
//   В нём создать список компонентов
//   List _components = new List { "rotor1", "rotor2", "rotor3", "rotor4" }
//   и возвращать его из метода GetComponents().
//5. Реализовать метод Charge() должен писать в консоль "Charging..." и через 3 секунды "Charged!".
//   Ожидание в 3 секунды реализовать через Thread.Sleep(3000).
//6. Реализовать все методы интерфейсов в классах. До этого пункта достаточно "throw new NotImplementedException();


internal class Quadcopter: IFlyingRobot, IChargeable
{
    List<string> _components;

    public Quadcopter()
    {
        _components = new List<string>{ "rotor1", "rotor2", "rotor3", "rotor4" };
    }
    
    public List<string> GetComponents() => _components;

    public void Charge()
    {
        Console.WriteLine("Charging...");
        Thread.Sleep(3000);
        Console.WriteLine("Charged!");
    }

    public string GetInfo()
    {
        throw new NotImplementedException();
    }
    
}