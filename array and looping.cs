string[] pokemon = { "pikachu", "charmander", "squirtle", "bulbasaur" };

// Print all elements of the array using a for loop
Console.WriteLine("Pokemon names using a for loop:");
for (int i = 0; i < pokemon.Length; i++) {
    Console.WriteLine(pokemon[i]);
}

// Print all elements of the array using a foreach loop
Console.WriteLine("\nPokemon names using a foreach loop:");
foreach (string poke in pokemon) {
    Console.WriteLine(poke);
}

// using while loop
Console.WriteLine("\nPokemon names using a while loop:");
int j = 0;
while (j < pokemon.Length) {
    Console.WriteLine(pokemon[j]);
    j++;
}

// using do-while loop
int k = 0;
do {
    Console.WriteLine(pokemon[k]);
    k++;
} while (k < pokemon.Length);