﻿using System;
using System.Globalization;

namespace FolhaSalario
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario func = new Funcionario();

           
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto a ser pago ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionario: " + func);

            Console.WriteLine();
            Console.Write("Deseja aumentar o salario em qual porcentual: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);

            
        }

    }

}