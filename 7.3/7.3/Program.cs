

//BaseAction ba = new BaseAction();

//((IAction)ba).Move();
//// безопасное приведение 
//if (ba is IAction action) action.Move();
//// или так
//IAction baseAction2 = new BaseAction();
//baseAction2.Move();


//interface IAction
//{
//    void Move();
//}
//class BaseAction : IAction
//{
//    void IAction.Move() => Console.WriteLine("Move in Base Class");
//}


//HeroAction action1 = new HeroAction();
//action1.Move();            // Move in BaseAction
//((IAction)action1).Move(); // Move in HeroAction

//IAction action2 = new HeroAction();
//action2.Move();             // Move in HeroAction


//interface IAction
//{
//    void Move();
//}
//class BaseAction : IAction
//{
//    public void Move() => Console.WriteLine("Move in BaseAction");
//}
//class HeroAction : BaseAction, IAction
//{
//    void IAction.Move() => Console.WriteLine("Move in HeroAction");
//}



IMovable tom = new Person("Tom");
// подписываемся на событие
tom.MoveEvent += () => Console.WriteLine($"{tom.Name} is moving");
tom.Move();

interface IMovable
{
    protected internal void Move();
    protected internal string Name { get; }
    delegate void MoveHandler();
    protected internal event MoveHandler MoveEvent;
}
class Person : IMovable
{
    string name;
    // явная реализация события - дополнительно создается переменная
    IMovable.MoveHandler? moveEvent;
    event IMovable.MoveHandler IMovable.MoveEvent
    {
        add => moveEvent += value;
        remove => moveEvent -= value;
    }
    // явная реализация свойства - в виде автосвойства
    string IMovable.Name { get => name; }
    public Person(string name) => this.name = name;
    // явная реализация метода
    void IMovable.Move()
    {
        Console.WriteLine($"{name} is walking");
        moveEvent?.Invoke();
    }
}