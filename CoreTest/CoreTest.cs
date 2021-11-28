using Core.TestGenerator.Implementations;
using NUnit.Framework;
using System;
using System.IO;

namespace CoreTest
{
    [TestFixture]
    public class Tests
    {
        public NUnitTestGenerator generator;

        public const string srcDir = @"D:\Projects\StudioProjects\C# projects\mpp-lab4\ConsoleApp\input";
        public const string resDir = @"D:\Projects\StudioProjects\C# projects\mpp-lab4\ConsoleApp\output";

        [SetUp]
        public void Setup()
        {
            Directory.Delete(resDir, true);
            Directory.CreateDirectory(resDir);
            generator = new(10, 10, 10);
        }

        [Test]
        public void NUnitTestGenerator_Generator_IncorrectDir_ArgumentExThrows()
        {
            Assert.Throws<AggregateException>(() => generator.GenerateTestsAsync("srcdir", "outdir").Wait());
        }

        [Test]
        public void NUnitTestGenerator_Generator_GeneratorWorks()
        {
            int srcFilesAm = new DirectoryInfo(srcDir).GetFiles().Length;
            generator.GenerateTestsAsync(srcDir, resDir).Wait();
            int resFileAm = new DirectoryInfo(resDir).GetFiles().Length;
            Assert.IsTrue(srcFilesAm == resFileAm);
        }
    }
}