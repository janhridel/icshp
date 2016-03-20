string s;
while (true)
{
    Console.WriteLine("Zadej text");
    s = Console.ReadLine();
    switch (s)
    {
        case "while":
        case "switch":
            Console.WriteLine("Zadal jsi klíčové slovo");
            break;
        case "konec":
            return;
        case "if":
            goto case "while";
        case "":
            Console.WriteLine("Prázdný řádek");
            goto default;
        default:
            Console.WriteLine("Zadal jsi neznámý text.");
            break;
    }
}