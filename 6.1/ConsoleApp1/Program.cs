//Message mes = Hello;
//mes.Invoke(); // Hello
//Operation op = Add;
//int n = op.Invoke(3, 4);
//Console.WriteLine(n);   // 7

//void Hello() => Console.WriteLine("Hello");
//int Add(int x, int y) => x + y;

//delegate int Operation(int x, int y);
//delegate void Message();



//Operation<decimal, int> squareoperation = Square;
//decimal result1 = squareoperation(5);
//Console.WriteLine(result1);

//Operation<int, int> doubleOperation = Double;
//int result2 = doubleOperation(22);
//Console.WriteLine(result2);



//decimal Square(int n) => n * n;

//int Double(int n) => n + n;


//delegate T Operation<T, K>(K val);


//DoOperation(5, 4, Add);
//DoOperation(5, 4, Substract);
//DoOperation(5, 4, Multiply);


//void DoOperation(int a, int b, Operation op)
//{
//    Console.WriteLine(op(a, b));
//}

//int Add(int x, int y) => x + y;
//int Substract(int x, int y) => x - y;
//int Multiply(int x, int y) => x * y;
//delegate int Operation(int x, int y);


Operation operation = SelectOperation(OperationType.Add);
Console.WriteLine(operation(10, 4));    // 14

operation = SelectOperation(OperationType.Subtract);
Console.WriteLine(operation(10, 4));    // 6

operation = SelectOperation(OperationType.Multiply);
Console.WriteLine(operation(10, 4));    // 40

Operation SelectOperation(OperationType opType)
{
    switch (opType)
    {
        case OperationType.Add: return Add;
        case OperationType.Subtract: return Subtract;
        default: return Multiply;
    }
}

int Add(int x, int y) => x + y;
int Subtract(int x, int y) => x - y;
int Multiply(int x, int y) => x * y;

enum OperationType
{
    Add, Subtract, Multiply
}
delegate int Operation(int x, int y);