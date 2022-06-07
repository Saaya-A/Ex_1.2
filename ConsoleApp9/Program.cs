class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите сумму покупки ");
        double pok = double.Parse(Console.ReadLine());
        double skid = 0.1;
        if (pok > 1000)
        {
            skid = pok * skid;
            pok = pok - skid;
        }
        Console.WriteLine("Сумма стоимости с учетом скидки " + pok);
    }
}