using System;
using System.IO;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace Arithmetic_Expression
{
    class SampleTest
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public bool Expected { get; set; }
        public bool Actual { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting run the tests");
            List<SampleTest> tests = new List<SampleTest>();
            tests.Add(new SampleTest() { A = 2, B = 3, C = 5, Expected=true });
            tests.Add(new SampleTest() { A = 8, B = 2, C = 4, Expected = true });
            tests.Add(new SampleTest() { A = 8, B = 3, C = 2, Expected = false });
            tests.Add(new SampleTest() { A = 6, B = 3, C = 3, Expected = true });
            tests.Add(new SampleTest() { A = 8, B = 4, C = 2, Expected = true });
            tests.Add(new SampleTest() { A = 2, B = 3, C = 6, Expected = true });
            tests.Add(new SampleTest() { A = 5, B = 2, C = 0, Expected = false });
            tests.Add(new SampleTest() { A = 10, B = 2, C = 2, Expected = false });
            foreach (var test in tests)
            {
                test.Actual = arithmeticExpression(test.A, test.B, test.C);
                if (test.Actual != test.Expected)
                    Console.WriteLine(string.Format("Failed with the data A={0},B={1},C={2},Expected={3}.But the Actual is {4}", test.A, test.B, test.C, test.Expected, test.Actual));
                else
                    Console.WriteLine(string.Format("Succeeded with the data A={0},B={1},C={2},Expected={3}", test.A, test.B, test.C, test.Expected));
            }
            Console.WriteLine("Finished run the tests");
            Console.ReadLine();
        }
        static bool arithmeticExpression(int A, int B, int C)
        {
            return A + B == C || A * B == C || 1.0 * A / B == C || A - B == C;
        }

    }
}
