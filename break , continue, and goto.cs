
string[] pokemon = { "pikachu", "charmander", "squirtle", "bulbasaur" };

// Example of break
Console.WriteLine("Using break:");
foreach (string poke in pokemon) {
    if (poke == "squirtle") {
        Console.WriteLine("Breaking at: " + poke);
        break;
    }
    Console.WriteLine(poke);
}

// Example of continue
Console.WriteLine("\n Using continue:");
foreach (string poke in pokemon) {
    if (poke == "charmander") {
        Console.WriteLine("Skipping charmander" + poke);
        continue;
    }
    Console.WriteLine(poke);
}

// Example of goto
Console.WriteLine("\n Using goto:");
int i = 0;
startLoop:
if (i >= pokemon.Length) goto endLoop;  // Jump to endloop after meeting the condition

Console.WriteLine(pokemon[i]);
i++;
goto startLoop;

endLoop:
Console.WriteLine("End of pokemon");