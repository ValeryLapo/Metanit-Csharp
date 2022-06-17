IAction action1 = new RunAction();
action1.Move(); // I am moving

IRunAction action2 = new RunAction();
action2.Move(); // I am running

IRunAction action3 = new RunAction();
action3.Move();

interface IAction
{
    void Move() => Console.WriteLine("I am moving");
}
interface IRunAction : IAction
{
    // скрываем реализацию из IAction
    new void Move() => Console.WriteLine("I am running");
}
class RunAction : IRunAction
{
    public void Move() => Console.WriteLine("I am tired");
}