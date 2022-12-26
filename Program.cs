
Main();

void Main()
{
	bool isWorking = true;
	while (isWorking)
	{
		Console.Write("Input command: ");
		switch (Console.ReadLine())
		{
			case "Task41": Task41(); break;
			case "Task43": Task43(); break;
			case "exit": isWorking = false; break;
		}
		Console.WriteLine();
	}
}
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
void Task41()
{
	int N = ReadInt("количество чисел");
	Console.WriteLine();
	Console.WriteLine($"Количество положительных чисел {PositiveNumbers(GetArray(N))}");
}

int ReadInt(string argument)
{
	Console.Write($"Введите {argument}: ");
	return int.Parse(Console.ReadLine());
}

int[] GetArray(int N)
{
	int[] array = new int[N];

	for (int i = 0; i < N; i++)
	{
		array[i] =ReadInt("число");
	}
	return array;
}


string PrintArray(int[] array)
{
	string result = string.Empty;

	for (int i = 0; i < array.Length; i++)
	{
		result += $"{array[i]} ";
	}

	return result;
}

int PositiveNumbers(int[] array)
{   int count = 0;
    for (int i = 0; i < array.Length; i++)
	{
		if (array[i] > 0)
        {
            count=count+1;
        }
	}return count;
}

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void Task43()
{
	double k1 = ReadInt("k1");
	Console.WriteLine();
	double k2 = ReadInt("k2");
	Console.WriteLine();
	double b1 = ReadInt("b1");
	Console.WriteLine();
	double b2 = ReadInt("b2");
	Console.WriteLine();
	FunctionX(k1, k2, b1, b2);
}

void FunctionX(double k1, double k2, double b1, double b2)
{   
	if (k1 == k2)
        {
           Console.WriteLine("Прямые параллельны");
        }
		else 
        {	
           double x = (b2 - b1) / (k1 - k2);
		   double y = k2 * x + b2;
		   Console.WriteLine($"Точка пересечения прямых {Math.Round(x,2)}, {Math.Round(y,2)}");
        }
}

