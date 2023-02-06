// See https://aka.ms/new-console-template for more information

using System.IO;
using System.Linq;

try
{
    int sum = File.ReadAllLines("C:\\Users\\loffe\\OneDrive - Högskolan Kristianstad\\Sustanable Programming\\SustanableProgrammingExam1CSharp\\SustanableProgrammingExam1CSharp\\numbers.txt")
                        .Select(line => int.Parse(line))
                        .Where(x => x % 2 == 0)
                        .Sum();
    Console.WriteLine(sum);
}catch(FileNotFoundException e)
{
    Console.WriteLine("Error...");
}