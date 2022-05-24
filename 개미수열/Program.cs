using System;

namespace 개미수열
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = "1"; //초기값
            string num2 = "";
            int i = 0; // i번째 수열
            char x; //숫자 x
            int j; // 숫자 X가 j개 있다
            while (i < 20)
            {
                Console.WriteLine(num); //출력
                j = 0; 
                while (j < num.Length)
                {
                    int k = 0;
                    x = num[j]; //숫자 x입력
                    while (num[j] == x)
                    {
                        j++;
                        k++;
                        if (j >= num.Length)
                        {
                            break;
                        }
                    }
                    num2 += k.ToString() + x.ToString();
                }
                num = num2;
                num2 = "";
                i++;
            }
        }
    }
}
