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

interface IRobot
{
    public string GetInfo();
    public List<string> GetComponents();
    public string GetRobotType() => "I am a simple robot.";
}

interface IChargeable
{
    public void Charge();
    public string GetInfo();
}

interface IFlyingRobot : IRobot
{
    public new string GetRobotType() => "I am a flying robot.";
}

