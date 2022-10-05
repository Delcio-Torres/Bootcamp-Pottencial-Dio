
// TRABALHANDO COM LISTA ---------------------------------------------

List<string> listaString = new List<string>();

listaString.Add("Delcio");
listaString.Add("Olivia");
listaString.Add("Gabriel");
listaString.Add("Raphael");

for( int contador = 0; contador < listaString.Count; contador++){

    Console.WriteLine($"Minha família linda {contador+1} : {listaString[contador]}");

}

foreach(string item in listaString){
    Console.WriteLine($"Minha família linda: {item}");
}


// TRABALHANDO COM ARRAY --------------------------------------------------

// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;

// Console.WriteLine("Lista com For");

// for(int contador = 0; contador < arrayInteiros.Length; contador++){
//     Console.WriteLine($"Posição nº {contador} = {arrayInteiros[contador]}");
// }

// Console.WriteLine();

// Console.WriteLine("Lista com Foreach");
// foreach(int valor in arrayInteiros){
//     Console.WriteLine(valor);
// }
// Array.
// Console.WriteLine();

// Console.WriteLine("Tamanho do meu array: " + arrayInteiros.Length);

// Array.Resize(ref arrayInteiros, 10);

// Console.WriteLine();

// Console.WriteLine("Tamanho do meu novo array: " + arrayInteiros.Length);