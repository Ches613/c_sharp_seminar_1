//======================================================================
// запрашивает коэффициенты линейных функций у пользователя и 
// печатает график в консоль
//======================================================================

namespace Utils
{
    public class LinearFunctionPrinter
    {
        const int HorizontalLine = 1; // символ горизонтальной линии
        const int VerticalLine = 2; // символ вертикальной линии
        const int FunctionLine = 3; // символ линии графика функции
        const int LineCrossing = 4; // символ пересечения линий графиков функций

        protected int[,] chart;

        public LinearFunctionPrinter(int size)
        {
            chart = CreateChart(size);
        }
        // Запрашивает коэффициенты линейной функции у пользователя
        public static (double k, double b) RequestData(string text)
        {
            Console.Write($"{text}: ");
            string[] inputNums = (Console.ReadLine() ?? "0,0").Split(",");
            return (double.Parse(inputNums[0]), double.Parse(inputNums[1]));
        }

        // Создает заготовку для графика
        private int[,] CreateChart(int size)
        {
            int[,] chart = new int[size * 2 + 1, size * 2 + 1];
            for (int i = 0; i <= size * 2; i++)
            {
                chart[size, i] = HorizontalLine;
                chart[i, size] = VerticalLine;
            }
            return chart;
        }

        // Добавляет график линейной функции на график
        public LinearFunctionPrinter AddLinearFunction(double k, double b)
        {
            double y = 0;
            int charSize = chart.GetLength(0);
            int charSizeHalf = charSize / 2;

            for (int x = -charSizeHalf; x <= charSizeHalf; x++)
            {
                y = ((double)k * x + b);
                int xPosition = x + charSizeHalf;
                int yPosition = charSize - ((int)y + charSizeHalf + 1);

                if (yPosition >= 0 && xPosition >= 0
                    && yPosition < charSize && xPosition < charSize)
                {
                    if (chart[yPosition, xPosition] == FunctionLine)
                        chart[yPosition, xPosition] = LineCrossing;
                    else
                        chart[yPosition, xPosition] = FunctionLine;
                }


            }
            return this;
        }

        // Печатает график в консоль
        public void printChart()
        {
            Console.WriteLine();
            for (int i = 0; i < chart.GetLength(0); i++)
            {
                for (int j = 0; j < chart.GetLength(1); j++)
                {
                    switch (chart[i, j])
                    {
                        case VerticalLine:
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write($"| ");
                            break;
                        case HorizontalLine:
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write($"- ");
                            break;
                        case LineCrossing:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"+ ");
                            break;
                        case FunctionLine:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write($"* ");
                            break;
                        default:
                            Console.Write($"  ");
                            break;
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
