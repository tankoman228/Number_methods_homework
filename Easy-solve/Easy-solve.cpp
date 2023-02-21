#include <iostream>

using namespace std;

//Сами функции из уравнений:
double f1(double x) {
	return 3 * x - exp(x);
}
double f2(double x) {
	return x * x * x + 2 * x + 4;
}

//Производные функций из уравнений
double ff1(double x) {
	return 3 - exp(x);
}
double ff2(double x) {
	return 3 * x * x + 2;
}

double (*f)(double) = f1; //указатель на функцию (из задания)
double (*ff)(double) = f1; //указатель на её производную

int main()
{
	//Для вычислений

	double a, b, c, xn, xp = -99990000000000000000000000000000000000000000.0;
	//xn - x now, xp - x previous
	double m, e;

	char mode = ' '; //Какой метод использовать
	int number; //Номер задания
	int i = 0, imax = 9999;

	while (mode != 'q') {

		cout << "Choose method (\"a\" for half-div, \"b\" for simple iteration,";
		cout << "\"c\" for tangent, \"d\" for chord, \"q\" to quit) \n";
		cin >> mode;

		switch (mode)
		{

		case 'a':
			//Метод половинного деления. Параметра два: обе границы
			cout << "Enter a (like 0.323)\n";
			cin >> a;
			cout << "Enter b (like 1.323) [b > a !!!!!!!!!!]\n";
			cin >> b;

			break;
		case 'b':
			//Метод простой итерации
			cout << "Enter start x (like 0.323)\n";
			cin >> xn;

			cout << "Enter start m (like 0.3)\n";
			cin >> m;

			break;

		case 'c':
			//Метод касательной
			cout << "Enter start x (like 1.5)\n";
			cin >> xn;
			break;
		case 'd':
			//Метод хорды
			cout << "Enter a (like 0.3)\n";
			cin >> a;
			cout << "Enter b (like 1.8) [b > a !!!!!]\n";
			cin >> b;

			break;

		default:

			cout << "Error: unknown mode!";
			system("pause");
			return -1;

			break;
		}

		cout << "Enter number (of equalation) (1 or 2) \n";
		cin >> number;

		//Выбираем функцию, с которой будем работать (по заданию)
		switch (number) {
		case 1: f = f1; ff = ff1; break;
		case 2: f = f2; ff = ff2; break;
			default: break;
		}

		cout << "Enter accuracy (like 0.001) \n";
		cin >> e;

		//Половинное деление
		if (mode == 'a') {

			while (b - a > e)
			{
				c = (a + b) / 2;
				if (f(a) * f(c) > 0) a = c;
				else b = c;
				i++;
			}
			cout << "success! X = " << c << "\n Iterations left:"
				<< i << endl << endl;
		}

		//Простая итерация
		if (mode == 'b') {

			while (abs(xn - xp) > e && i < imax) {

				xp = xn;
				xn = xp - m * f(xp);

				i++;
			}
			if (i == imax) cout << "Error! Too much iterations\n Try another m \n\n";
			else cout << "success! X = " << xn << "\n Iterations left:"
				<< i << endl << endl;
		}

		//Касательная
		if (mode == 'c') {

			double xstart = xn;

			while (abs(xn - xp) > e && i < imax) {

				xp = xn;
				xn = xp - f(xp) / ff(xp);		

				i++;
			}
			if (i == imax) {

				xn - xstart; 
				xp = 9000000000000000000000000.0; 
				i = 0;

				while (abs(xn - xp) > e && i < imax) {

					xp = xn;
					xn = xp + f(xp) / ff(xp);

					i++;
				}
			}

			if (i == imax) {
				cout << "Error: try another start x\n";
			}
			else cout << "success! X = " << xn << "\n Iterations left:" << i << endl << endl;
		}

		//хорда
		if (mode == 'd') {

			double fb = f(b), fx;

			do {
				xp = a;
				fx = f(a);

				a = a - (b - a) * fx / (fb - fx);

				i++;
			} while (abs(a - xp) > e && i < imax);

			if (i == imax) cout << "Error! Too much iterations\n Try other a and b \n\n";
			else cout << "success! X = " << a << "\n Iterations left:"
				<< i << endl << endl;
		}
		system("pause");
	}

	system("pause");
	return 0;
}