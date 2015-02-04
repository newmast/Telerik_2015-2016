using System;

class Decode
{
    static void Main()
    {
        int salt = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        float encodeNumber = 0f;

        for (int i = 0; i < input.Length; i++)
		{
            if (input[i] == '@')
            {
                break;
            }
			if ((input[i] >= 'a' && input[i] <= 'z') ||
                (input[i] >= 'A' && input[i] <= 'Z'))
            {
                encodeNumber = (input[i] * salt) + 1000;
            }
            else if (input[i] >= '0' && input[i] <= '9')
            {
                encodeNumber = (input[i] + salt) + 500;
            }
            else
            {
                encodeNumber = input[i] - salt;
            }

            if (i % 2 == 0)
            {
                encodeNumber /= 100;
                Console.WriteLine("{0:F2}", encodeNumber);
            }
            else
            {
                encodeNumber *= 100;
                Console.WriteLine(encodeNumber);
            }
		}
    }
}