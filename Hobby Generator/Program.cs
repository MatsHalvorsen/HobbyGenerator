class Progam
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int num = random.Next(1, 7);

        if (num == 1)
        {
            Console.WriteLine("Ny hobby: Les en ny bok");
        }
        else if (num == 2)
        {
            Console.WriteLine("Ny hobby: Tren til ultramarathon");
        }
        else if (num == 3)
        {
            Console.WriteLine("Ny hobby: Progge nettsider");
        }
        else
        {
            Console.WriteLine("Ny hobby: Styrketrening");
        }
    }
}