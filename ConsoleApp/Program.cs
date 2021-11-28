using System;
using Core.TestGenerator.Implementations;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new NUnitTestGenerator(10, 10, 10);
            generator.GenerateTestsAsync(@"D:\Projects\StudioProjects\C# projects\mpp-lab4\ConsoleApp\input",
                @"D:\Projects\StudioProjects\C# projects\mpp-lab4\ConsoleApp\output").Wait();
        }
    }
}