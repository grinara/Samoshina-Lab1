using System;
namespace Samohina_Lab1
{
    class Step
    {
        static float Deg(float num, float step) {
            if (step == 0 || num == 1) { return 1; }
            if (num == 0) {  return 0; }
            float s = 1, s1 = 0;
            for (int i = 1; i <= Math.Abs(step); i++)
            {
                for (int j = 1; j <= Math.Abs(num); j++)
                {
                    s1 = s1 + s;
                }
                s = s1;
                s1 = 0;
            }
            if (num < 0 && step%2!=0) { s*=-1; }
            if(step<0) { s=1/s; }
            return s;
        }
        static void Main()
        {
            Console.Write("число - ");
            var num = float.Parse(Console.ReadLine());
            Console.Write("степень - ");
            var step = float.Parse(Console.ReadLine());
            Console.Write(Deg(num, step));
        }
    }
}
