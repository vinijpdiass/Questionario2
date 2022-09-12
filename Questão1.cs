using System;
class Entrada_de_numeros {
  static void Main() {
    int numero1, numero2, numero3;
    int media, somatorio, produtorio;
    
    Console.WriteLine("Usuário digite o primeiro numero?");
    numero1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Usuário digite o segundo numero?");
    numero2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Usuário digite o terceiro numero?");
    numero3 = int.Parse(Console.ReadLine());
    
    media = (numero1 + numero2 + numero3)/3;
    somatorio = numero1 + numero2 + numero3;
    produtorio = numero1 * numero2 * numero3;
    
    Console.WriteLine($"A média aritmética dos numeros digitados é {media}");
    Console.WriteLine($"O somatório dos números digitados é {somatorio}");
    Console.WriteLine($"O produtório dos números digitados é {produtorio}");
    
  }
}
