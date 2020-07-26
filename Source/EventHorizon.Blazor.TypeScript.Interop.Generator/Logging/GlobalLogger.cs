using System;
using System.Collections.Generic;
using System.Text;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Logging
{
    public static class GlobalLogger
    {
        public static IList<string> Messages = new List<string>();

        public static void Success(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            message = $"Success : {message}";
            Console.WriteLine(
                message
            );
            Console.ResetColor();
            Messages.Add(
                message
            );
        }

        public static void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            message = $"Error : {message}";
            Console.WriteLine(
                message
            );
            Console.ResetColor();
            Messages.Add(
                message
            );
        }

        public static void Warning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            message = $"Warning : {message}";
            Console.WriteLine(
                message
            );
            Console.ResetColor();
            Messages.Add(
                message
            );
        }

        public static void Info(string message)
        {
            message = $"Info : {message}";
            Console.WriteLine(
                message
            );
            Messages.Add(
                message
            );
        }
    }
}
