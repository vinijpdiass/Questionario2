using System;
class Salario {
  static void Main() {
    string nome;
    double hora_normal, hora_extra, deducao_inss, salario_bruto, salario_liquido, numero_de_inscricao;

    
    Console.WriteLine("Usuário digite o seu nome");
    nome = (Console.ReadLine());
    Console.WriteLine($"olá {nome}, digite o seu numero de inscricção");
    numero_de_inscricao = double.Parse(Console.ReadLine());
    
    hora_normal = 1200;
    hora_extra = hora_normal * 0.3;
    salario_bruto =(hora_normal + hora_extra) * 1.3;
    deducao_inss= salario_bruto * 0.11;
    salario_liquido = salario_bruto - deducao_inss;

    Console.WriteLine($"Número de inscrição : {numero_de_inscricao}");
    Console.WriteLine($"Nome : {nome}");
    Console.WriteLine($"Sálario horas normais : {hora_normal}");
    Console.WriteLine($"Salário hora extra : {hora_extra}");
    Console.WriteLine($"Dedução INSS : {deducao_inss}");
    Console.WriteLine($"Salário líquido : {salario_liquido}");
    
  }
}
