using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MathUtility
{
    public static class MathUtility
    {
        public static string Addition(int firstNum, int secondNum) => $"{firstNum} + {secondNum} = {firstNum + secondNum}";
        public static string Subtraction(int firstNum, int secondNum) => $"{firstNum} - {secondNum} = {firstNum - secondNum}";

        public static string Multiplication(int firstNum, int secondNum) => $"{firstNum} * {secondNum} = {firstNum * secondNum}";
        public static string Division(int firstNum, int secondNum)
        {
            try { return $"{firstNum} / {secondNum} = {firstNum / secondNum}"; }
            catch (DivideByZeroException)
            {
                return $"Error : Division of {secondNum} by zero.";
            }
        }

    }
}
