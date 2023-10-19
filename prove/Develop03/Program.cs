using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        Reference reference = new Reference();
        Words word = new Words();

        Console.WriteLine(reference.Reference1(1, 2));
        scripture.scriptures.Add(reference.Reference1(1, 2));
    }
}
