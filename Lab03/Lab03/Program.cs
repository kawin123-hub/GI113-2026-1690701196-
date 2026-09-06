namespace Lab03
{
class Program
 {
    static void Main(string[] args)
    {
        const int MaxLevel = 10;

        var bossName = "Kirin";
        var rank = 'S'; 
        int level = 7;
        int maxHp = 240;
        int currentHp = 115; 
        float attackPower = 42.5f;
        double critMultiplier = 1.75;
        bool iaBoss = true;

        // Boss Stats
        Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
        Console.WriteLine($"NAME: {bossName}" +
         $"\nRANK: {rank}" +
         $"\nLEVEL: {level}" +
         $"\nMAX HP: {maxHp}" +
         $"\nCURRENT HP: {currentHp}" +
         $"\nATTACK POWER: {attackPower}" +
         $"\nCRIT MULTIPLIER: {critMultiplier}" +
         $"\nIS BOSS: {iaBoss}");
         // Implicit conversion HP (int) -->> double
         Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
         double currentHpDouble = currentHp;
         Console.WriteLine($"HP(double): {currentHpDouble}");

         // Calculate the Percentage as double
         Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
         double hpPercent = currentHpDouble / maxHp * 100;
         Console.WriteLine($"HP Percent: {hpPercent:F2}%");

         // Explicit casting attack power (float) -->> int
         Console.WriteLine("\n----- Explicit Casting: Attack Power as int -----");
         int attackPowerInt = (int)attackPower;
         Console.WriteLine($"Attack Power(int): {attackPowerInt}");
         // Cast vs. Convert: Crit Multiplier 
         Console.WriteLine("\n----- Cast vs. Convert: Crit Multiplier -----");
         int critMultiplierIntCast = (int)critMultiplier;
         int critMultiplierIntConvert = Convert.ToInt32(critMultiplier);
         Console.WriteLine($"Crit Multiplier(int) using cast: {critMultiplierIntCast}");
         Console.WriteLine($"Crit Multiplier(int) using Convert: {critMultiplierIntConvert}");

    }
 }
}