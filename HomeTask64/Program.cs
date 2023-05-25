
void Main()
{
    bool IsWork = true;
    while(IsWork)
    {
        System.Console.WriteLine("Введите номер задачи: ");
        string command = System.Console.ReadLine();
        
        switch (command)
        {
            case "64":
                Task64();
                break;
            case "66":
                Task66();
                break;
            case "68":
                Task68();
                break;
            case "exit":
                IsWork = false;
                break;
        }
    }
}


void Task64()
{
    System.Console.WriteLine("Введите число m");
    int m = int.Parse(System.Console.ReadLine());
    System.Console.WriteLine("Введите число n");
    int n = int.Parse(System.Console.ReadLine());
    IncreaseNumbers(m, n);
    System.Console.WriteLine(IncreaseNumbers(1, 7));
}

void Task66()
{
    System.Console.WriteLine("Введите число m");
    int m = int.Parse(System.Console.ReadLine());
    System.Console.WriteLine("Введите число n");
    int n = int.Parse(System.Console.ReadLine());
    SummNumbers(m, n);
    System.Console.WriteLine(SummNumbers(m, n));
}

void Task68()
{
    int n = 0;
    int m = 0;
    Aсkerman(n, m);
    System.Console.WriteLine(Aсkerman(2, 3));
}


string IncreaseNumbers(int m, int n)
{
    if(m <= n) return $"{m} " + IncreaseNumbers(m + 1, n);
    else return String.Empty;
}


int SummNumbers(int m, int n)
{
    int summ = 0;
    if(m <= n) return m + SummNumbers(m + 1, n);
    else return 0;
}


int Aсkerman(int n, int m)
{
    if(n == 0) return m + 1;
    else if(m == 0) return Aсkerman(n - 1, 1);
    else return Aсkerman(n - 1, Aсkerman(n, m - 1));
}


Main();
