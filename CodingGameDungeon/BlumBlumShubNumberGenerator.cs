using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodingGameDungeon
{
    public class BlumBlumShubNumberGenerator
    {
       
        int R { get; set; }
        int P { get; set; }
        int Q { get; set; }

        public BlumBlumShubNumberGenerator(int r, int p, int q)
        {
            R = r;
            P = p;
            Q = q;
        }

        int LeastCommonMultiple(int a, int b)
        {
            int num1, num2;
            if (a > b)
            {
                num1 = a; num2 = b;
            }
            else
            {
                num1 = b; num2 = a;
            }

            for (int i = 1; i < num2; i++)
            {
                if ((num1 * i) % num2 == 0)
                {
                    return i * num1;
                }
            }
            return num1 * num2;
        }
                
        public int LambdaM()
        {
            return LeastCommonMultiple(P - 1, Q - 1);
        }

        public int Power( int n)
        {                       
            return (int)(BigInteger.ModPow(2, n , LambdaM()));
        }

        public int GenerateNthTerm(int n)
        {
            var power = Power(n);
            

            return (int)BigInteger.ModPow(R, power, (P * Q));
        }

        public int GenerateNextTerm(int xn)
        {
            return (xn * xn) % (P * Q);
        }
    }
}
