
class SwitchCaseExample
{
    static void SwitchExample(string[] args)
    {

        Console.WriteLine("Enter the score between 1 and 9");
        int score = Convert.ToInt16(Console.ReadLine());
        int bonus = BonusScore(score);
        Console.WriteLine(bonus);

    }

    public static int BonusScore(int score)
    {
        switch (score)
        {
            case int n when (n >= 1 && n <= 3):
                return score * 10;
            case int n when (n >= 4 && n <= 6):
                return score * 100;
            case int n when (n >= 7 && n <= 9):
                return score * 1000;
            default:
                return 0;
        }
    }
}