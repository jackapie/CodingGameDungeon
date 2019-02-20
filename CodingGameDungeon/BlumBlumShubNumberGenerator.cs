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
                
        public int LambdaM(int p, int q)
        {
            return LeastCommonMultiple(p - 1, q - 1);
        }

        public int Power(int p, int q, int n)
        {

            var factor = new BigInteger(1);
            for (int i = 0; i < n; i++)
            {
                factor = factor * 2;
            }
            return (int)(factor % LambdaM(p, q));
        }

        public int GenerateNthTerm(int r, int p, int q, int n)
        {
            var power = Power(p, q, n);
            var factor = new BigInteger(1);
            for (int i = 0; i < power; i++)
            {
                factor = factor * r;
            }

            return (int)(factor % (p * q));
        }

        public int GenerateNextTerm(int xn, int p, int q)
        {
            return (xn * xn) % (p * q);
        }
    }
}
