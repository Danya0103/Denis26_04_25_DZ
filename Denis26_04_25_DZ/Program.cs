using System;

/*
class Program {

    static double MultiplyArrayElements(double[] arr) {

        double result = 1;

        for (int i = 0; i < arr.Length; i++) {

            result *= arr[i];

        }

        return result;

    }

    static void Main(string[] args) {

        double[] number = {1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9, 10.10};

        double numbersMultiplication = MultiplyArrayElements(number);

        Console.WriteLine($"Добуток всіх чисел у масиві: {numbersMultiplication}");

    }
}
*/


class Program {
    static void Main(string[] args) {

        double[] temperatures = {15.5, 17.8, 20.2, 18.1, 19.4, 21.3, 16.7};
        string[] days = {"Monday", "Tuesday", "Wed", "Thu", "Fri", "Sat", "Sun"};

        double maxTemperature = temperatures[0];
        string day = days[0];

        for (int i = 1; i < temperatures.Length; i++) {     // i = 1; i++ -  i = 2; i++  - i = 3; i++   ..... i = 7(stop)

            if (temperatures[i] > maxTemperature) {

                maxTemperature = temperatures[i];
                day = days[i];

            }
        }

        double totalTemperature = 0;
        for (int i = 0; i < temperatures.Length; i++) {

            totalTemperature += temperatures[i];

        }

        double averageTemperature = totalTemperature / temperatures.Length;

        Console.WriteLine($"Максимальна температура за тиждень: {maxTemperature} в день {day}");
        Console.WriteLine($"Середня температура за тиждень: {averageTemperature}");

    }
}
