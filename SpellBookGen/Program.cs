using SpellBookGen;

Console.WriteLine("Generátor náhodných spellů");

List<Spell> seznamSpellu = new List<Spell>();
HelperClass pomocneMetody = new HelperClass();

string[] index1 = pomocneMetody.PoleZTextu("../../../txt/spellform.txt");
string[] index2 = pomocneMetody.PoleZTextu("../../../txt/spelltypes.txt");

while (true)
{
    Console.WriteLine("1. Vygenerovat nový spell a přidat do Spellbooku");
    Console.WriteLine("2. Zobrazit Spellbook");
    Console.WriteLine("3. Smazat poslední záznam ve Spellbooku");
    Console.WriteLine("4. Smazat celý SpellBook");
    Console.WriteLine("4.*. ukončit aplikaci");
    string input = Console.ReadLine();

    if (input == "1")
    {
        Spell spell = new Spell();
        spell.Name = pomocneMetody.VygenerujSpeelname(index1, index2);
        spell.ManaCost = pomocneMetody.VygenerujCislo(100);
        seznamSpellu.Add(spell);
        Console.Clear();
    }
    else if (input == "2")
    {
        foreach (Spell spell in seznamSpellu)
        {
            Console.WriteLine($"Spell: {spell.Name} " + $" Mana cost: {spell.ManaCost} ");
        }
    }
    else if (input == "3")
    {
        int indexPosledniho = seznamSpellu.Count - 1;

        Spell posledni = seznamSpellu[indexPosledniho];
        seznamSpellu.Remove(posledni);
        Console.Clear();
    }
    else if (input == "4")
    {
        seznamSpellu.Clear();
        Console.Clear();
    }
    else if (input == "*")
    {
        break;
    }
}