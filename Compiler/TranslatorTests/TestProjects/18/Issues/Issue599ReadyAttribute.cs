﻿using Bridge.Html5;

namespace TestIssue599
{
    public class Issue599
    {
        private string _something = "HI!";

        [Ready]
        public static void Main1()
        {
            System.Console.WriteLine(new Issue599()._something);
        }
    }
}
