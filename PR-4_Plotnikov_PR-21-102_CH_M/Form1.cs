using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_4_Plotnikov_PR_21_102_CH_M
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBoxMinDelta.Text = "0,00001";
        }

        int matrixSize = 1;
        int currentLine; //редактируемая строка
        double[,] A; //исходная матрица
        double[] B; //дополнение к исходной
        double[] X; //Корни
        int max_member_size = 7; //для вывода

        string line_str; //вспомогательная переменная (для вывода)

        double[,] L, U; //для метода разложения
        double minDelta = 0.00001; //для метода итерации

        //____Вывод данных [

        //Выводит исхоную матрицу, очищает поле вывода
        void update_output_matrix()
        {
            listBoxAnswer.Items.Clear();

            for (int i = 0; i < matrixSize; i++)
            {
                line_str = "";
                for (int j = 0; j < matrixSize; j++)
                {
                    line_str += string.Format("{0," + (max_member_size - A[i, j].ToString().Length) + "} ", A[i, j]);
                }

                if (i == currentLine)
                {
                    textBoxLine.Text = line_str;
                    line_str += "  <--";
                }

                line_str += " | " + B[i].ToString();

                listBoxAnswer.Items.Add(line_str);
            }
        }

        //Выводит матрицу
        void out_matrix(double[,] a)
        {
            for (int i = 0; i < matrixSize; i++)
            {
                line_str = "";
                for (int j = 0; j < matrixSize; j++)
                {
                    line_str += string.Format("{0," + (max_member_size - a[i, j].ToString().Length) + "} ", a[i, j]);
                }

                listBoxAnswer.Items.Add(line_str);
            }
        }

        //Вывод и проведение проверки ответа на правильность
        void checkAnswer()
        {
            listBoxAnswer.Items.Add("");
            listBoxAnswer.Items.Add("Проверка:");

            double[] C = new double[matrixSize];
            bool allRight = true;

            for (int i = 0; i < matrixSize; i++)
            {
                line_str = B[i].ToString() + " = ";

                for (int j = 0; j < matrixSize; j++)
                {
                    line_str += $"{A[i, j]} * {X[j]} + ";
                    C[i] += A[i, j] * X[j];
                }

                line_str += "0 = " + C[i];

                if (Math.Round(C[i], textBoxMinDelta.Text.Length - 2) != Math.Round(B[i], textBoxMinDelta.Text.Length - 2)) allRight = false;

                listBoxAnswer.Items.Add(line_str);
            }

            if (allRight) listBoxAnswer.Items.Add("Ответ сходится");
            else listBoxAnswer.Items.Add("Ответ НЕ сходится (есть ошибки или данные введены неверно)");
        }

        //Вывод инструкции по пользованию программой
        private void btnHelp_Click(object sender, EventArgs e)
        {
            listBoxAnswer.Items.Clear();

            listBoxAnswer.Items.Add("1. Введите размер изначальной матрицы и нажмите на кнопку создания");
            listBoxAnswer.Items.Add("2. Введите первую строку в поле \"строка\" (предыдущие данные сотрите)");
            listBoxAnswer.Items.Add("2. Десятичные дроби вводятся через запятую, например, 6,43 или -78,202");
            listBoxAnswer.Items.Add("");
            listBoxAnswer.Items.Add("3. Нажмите на кнопку \"изменить выбранную строку\", чтобы сохранить");
            listBoxAnswer.Items.Add("");
            listBoxAnswer.Items.Add("Обратите внимание, ваша расширенная матрица отображается справа (в консоли вывода)");
            listBoxAnswer.Items.Add("");
            listBoxAnswer.Items.Add("4. Перейдите к следующей строке, нажав \"Следующая строка\"");
            listBoxAnswer.Items.Add("5. В случае необходимости можно вернуться к предыдущим строкам и отредактировать");
            listBoxAnswer.Items.Add("");
            listBoxAnswer.Items.Add("(2-5) выбранная строка помечена стрелочкой. Не забывайте сохранять изменения!");
            listBoxAnswer.Items.Add("");
            listBoxAnswer.Items.Add("6. Введите матрицу В (дополнение к расширенной) в нужное поле");
            listBoxAnswer.Items.Add("7. Сохраните изменения кнопкой \"Обновить значения\"");
            listBoxAnswer.Items.Add("8. Выберите нужный вам метод решения");
            listBoxAnswer.Items.Add("");
            listBoxAnswer.Items.Add("9. Если элементы матриц съезжают, настройте отступы в поле ниже");
            listBoxAnswer.Items.Add("10. Также можно настроить точность метода итераций (максимальную погрешность, а не число итераций, оно всегда менее 1000)");
        }

        //  ]


        //____Ввод данных [

        //создаёт новую матрицу
        private void btnNewMatrix_Click(object sender, EventArgs e)
        {
            matrixSize = int.Parse(textBoxMatrixSize.Text);
            A = new double[matrixSize, matrixSize];
            currentLine = 0;

            L = new double[matrixSize, matrixSize];
            U = new double[matrixSize, matrixSize];
            B = new double[matrixSize];
            X = new double[matrixSize];

            textBoxB.Text = "";
            for (int i = 0; i < matrixSize; i++)
            {
                textBoxB.Text += "0 ";
            }

            update_output_matrix();
        }

        //Обновляет матрицу B
        private void btnUPDB_Click(object sender, EventArgs e)
        {
            line_str = textBoxB.Text + " ";

            int i = 0;

            MatchCollection d = Regex.Matches(line_str, @"(-*)(\d+)(,*)\d*\s");
            foreach (Match y in d)
            {
                B[i] = double.Parse(y.Value);
                i++;
            }

            update_output_matrix();
        }

        //обновляет строку в матрице A
        private void btnUpd_Click(object sender, EventArgs e)
        {
            line_str = textBoxLine.Text + " ";

            int i = 0;

            MatchCollection d = Regex.Matches(line_str, @"(-*)(\d+)(,*)(\d*)\s");
            foreach (Match y in d)
            {
                A[currentLine, i] = double.Parse(y.Value);
                i++;
            }

            update_output_matrix();
        }

        //Обновление отступов (при выводе матрицы)
        private void btnUPDmaxMemSize_Click(object sender, EventArgs e)
        {
            max_member_size = int.Parse(textBoxMaxMemSize.Text);
            update_output_matrix();
        }

        //Переход по строкам матрицы для редактирования
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentLine > 0) currentLine--;
            update_output_matrix();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentLine < matrixSize - 1) currentLine++;
            update_output_matrix();
        }

        //Ввод точности
        private void btnMinDelta_Click(object sender, EventArgs e)
        {
            minDelta = double.Parse(textBoxMinDelta.Text);
        }

        //      ]


        //Методы решения СЛАУ [


        //Разложение LU
        private void btnLU_Click(object sender, EventArgs e)
        {

            //копируем элементы в U из A
            for (int i = 0; i < matrixSize; i++)
                for (int j = 0; j < matrixSize; j++)
                    U[i, j] = A[i, j];

            //Первый столбец матрицы L
            for (int i = 0; i < matrixSize; i++)
                for (int j = i; j < matrixSize; j++)
                    L[j,i] = U[j,i] / U[i,i];

            //Вычисляем остальные элементы
            for (int k = 1; k < matrixSize; k++)
            {
                for (int i = k - 1; i < matrixSize; i++)
                    for (int j = i; j < matrixSize; j++)
                        L[j,i] = U[j,i] / U[i,i];

                for (int i = k; i < matrixSize; i++)
                    for (int j = k - 1; j < matrixSize; j++)
                        U[i,j] -= L[i,k - 1] * U[k - 1,j];
            }

            //Выводим значения
            listBoxAnswer.Items.Add("Решение методом LU разложения:");

            listBoxAnswer.Items.Add(" ");
            listBoxAnswer.Items.Add("L:");
            out_matrix(L);

            listBoxAnswer.Items.Add(" ");
            listBoxAnswer.Items.Add("U:");
            out_matrix(U);

            listBoxAnswer.Items.Add(" ");

            //Проверка разложения
            A = new double[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    A[i, j] = 0;
                    for (int k = 0; k < matrixSize; k++)
                    {
                        A[i, j] += L[i, k] * U[k, j];
                    }
                }
            }
            listBoxAnswer.Items.Add("L * U =");
            out_matrix(A);


            double[] Y = new double[matrixSize];

            //Промежуточное значение
            for (int i = 0; i < matrixSize; i++)
            {
                Y[i] = B[i];
                for (int k = 0; k < i; k++)
                {
                    Y[i] -= L[i, k] * Y[k];
                }
                listBoxAnswer.Items.Add($"Y[{i}] = {Y[i]}");
            }

            listBoxAnswer.Items.Add("");
            listBoxAnswer.Items.Add("Ответ:");

            //Значение самих корней (обратный ход)
            int n = matrixSize - 1;

            for (int i = 0; i <= n; i++)
            {
                X[n - i] = Y[n - i];
                for (int p = 0; p <= i - 1; p++)
                {
                    X[n - i] -= U[n - i, n - p] * X[n - p];
                }
                X[n - i] /= U[n - i, n - i];
            }

            for (int i = 0; i < matrixSize; i++)
            {
                listBoxAnswer.Items.Add($"X[{i}] = {X[i]}");
            }

            checkAnswer();
        }

        //Метод простой итерации
        private void btnSimpleIteration_Click(object sender, EventArgs e)
        {
            double[] NX = new double[matrixSize]; //Приближение
            double delta = double.MaxValue;

            //Нулевое приближение
            for (int i = 0; i < matrixSize; i++)
            {
                NX[i] = B[i] / A[i, i];
                X[i] = NX[i];
            }

            listBoxAnswer.Items.Add("Решение методом простой итерации:");

            int k = 1;

            //Основные вычисления
            while (delta > 0.000001 && k < 1000)
            {

                delta = 0;

                for (int i = 0; i < matrixSize; i++)
                {
                    NX[i] = B[i];

                    for (int j = 0; j < matrixSize; j++)
                    {
                        if (i == j) continue;
                        NX[i] -= A[i, j] * X[j];
                    }

                    NX[i] /= A[i, i];
                    delta += Math.Abs(NX[i] - X[i]);
                }

                for (int i = 0; i < matrixSize; i++)
                {
                    X[i] = NX[i];
                }

                listBoxAnswer.Items.Add($"Итерация {k}, текущие приближения: ");
                for (int i = 0; i < matrixSize; i++)
                {
                    listBoxAnswer.Items.Add($"X[{i}] = {X[i]}");
                }

                k++;
            }
            listBoxAnswer.Items.Add("");
            listBoxAnswer.Items.Add("Ответ:");
            for (int i = 0; i < matrixSize; i++)
            {
                listBoxAnswer.Items.Add($"X[{i}] = {X[i]}");
            }
            listBoxAnswer.Items.Add("Внимание! Матрица может не сходиться и тогда ответ не будет найден");

            checkAnswer();
        }

        //Метод прогонки
        private void btnPRGNK_Click(object sender, EventArgs e)
        {
            listBoxAnswer.Items.Add("Решение методом прогонки:");

            double[] 
                y = new double[matrixSize],
                a = new double[matrixSize],
                b = new double[matrixSize];

            listBoxAnswer.Items.Add("");

            y[0] = A[0, 0];
            a[0] = -A[0, 1] / y[0]; //beta
            b[0] = B[0] / y[0]; //alpha

            int i = 1;

            for (i = 1; i < matrixSize - 1; i++)
            {
                y[i] = A[i, i] + A[i, i - 1] * a[i - 1];
                a[i] = -A[i, i + 1] / y[i];
                b[i] = (B[i] - A[i, i - 1] * b[i - 1]) / y[i];
            }

            y[i] = A[i,i] + A[i, i - 1] * a[i - 1];
            b[i] = (B[i] - A[i, i - 1] * b[i - 1]) / y[i];

            //Обратный ход
            X[i] = b[i];
            for (i = i - 1; i >= 0; i--)
            {
                X[i] = a[i] * X[i + 1] + b[i];
            }

            //Для отладки:
            for (i = 0; i < matrixSize; i++)
            {
                listBoxAnswer.Items.Add($"a[{i}] = {a[i]} | b[{i}] = {b[i]} | y[{i}] = {y[i]}");
            }

            //Вывод ответа
            listBoxAnswer.Items.Add("Ответ:");
            for (i = 0; i < matrixSize; i++)
            {
                listBoxAnswer.Items.Add($"X[{i}] = {X[i]}");
            }
            listBoxAnswer.Items.Add("");
            listBoxAnswer.Items.Add("Внимание! Матрица должна быть трёхдиагональной!");
            listBoxAnswer.Items.Add("Иначе ответ получится неверный");

            checkAnswer();
        }


        //     ]

    }
}
