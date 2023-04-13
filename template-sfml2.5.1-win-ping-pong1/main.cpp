#include "Interpolations.h"

const string menu = "\nEnter e to enter function \nEnter i to interpolate\nEnter x to close";

int main() {

	cout << "Welcome to interpolation master\n\n";

	char option = '0';
	//Выбор в консоли нужного действия

	while (option != 'x') {

		cout << menu << "\n";

		cin >> option;

		if (option == 'e') {

			cout << "Enter table length\n";
			cin >> Size;
			
			x = new double[Size];
			y = new double[Size];

			for (int i = 0; i < Size; i++) {
				cout << "Enter x[" << i << "] = ";
				cin >> x[i];

				cout << "Enter y[" << i << "] = ";
				cin >> y[i];
			}
		}
		else if (option == 'i') {

			if (Size == 0) {

				cout << "You need enter function to interpolate!";
				system("pause");
			}
			else {
				cout << "Enter interpolstion type\n";
				cout << "n - Newton\n";
				cout << "s - Qubic splines\n";
				cout << "l - Lagrange\n";

				cin >> option;

				switch (option)
				{
				case 'n': newton(); break;
				case 's': spline(); break;
				case 'l': lagrange(); break;
				default:
					cout << "Wrong input value!\n"; break;
				}
			}
		}

	}

	return 0;
}