#pragma once

#include <iostream>
#include <SFML/Graphics.hpp>

using namespace std;
using namespace sf;

//Масштабирование поля
#define scale 50	

//Шаг построения графика
#define step 0.01

double* x, *y;
int Size = 0;

//Отрисовка графика в окне
void drawGraphics(double(*function) (double)) {

	//Создание окна
	RenderWindow window(VideoMode(1000, 1000), "SFML");

	CircleShape circle(10, 10);
	circle.setFillColor(Color::White);
	circle.setRadius(3);

	CircleShape point(5, 5);
	point.setFillColor(Color::Red);
	point.setRadius(3);

	Font font;
	font.loadFromFile("Text.ttf");

	Text txt;
	txt.setCharacterSize(25);
	txt.setFont(font);
	txt.setFillColor(Color::Color(0, 255, 255, 255));

	double X = 0;
	double y;

	sf::RectangleShape vert, hor;

	vert.setSize(sf::Vector2f(2, 1000));
	vert.setFillColor(sf::Color::Yellow);
	vert.setPosition(500, 0);

	hor.setSize(sf::Vector2f(1000, 2));
	hor.setFillColor(sf::Color::Yellow);
	hor.setPosition(0, 500);

	while (window.isOpen()) {

		window.draw(vert);
		window.draw(hor);
		//Координатные прямые
		for (int i = 0; i < 10; i++) {

			txt.setPosition(500, 500 + i * scale);
			txt.setString(to_string(-i));
			point.setPosition(txt.getPosition());
			window.draw(point);
			window.draw(txt);

			txt.setPosition(500, 500 - i * scale);
			txt.setString(to_string(i));
			point.setPosition(txt.getPosition());
			window.draw(point);
			window.draw(txt);


			txt.setPosition(500 + i * scale, 500);
			txt.setString(to_string(i));
			point.setPosition(txt.getPosition());
			window.draw(point);
			window.draw(txt);

			txt.setPosition(500 - i * scale, 500);
			txt.setString(to_string(-i));
			point.setPosition(txt.getPosition());
			window.draw(point);
			window.draw(txt);
		}

		X += step;
		y = function(X);

		if (X > 10) {
			X *= -1;
		}

		//Отрисовка узлов
		for (int i = 0; i < Size; i++) {

			double y = function(x[i]);

			sf::CircleShape circle(10, 10);
			circle.setFillColor(Color::Blue);
			circle.setRadius(3);
			circle.setPosition(x[i] * scale + 500, -y * scale + 500);
			window.draw(circle);

			txt.setPosition(x[i] * scale + 500, -y * scale + 500 - scale / 3);
			txt.setString("y(" + to_string(x[i]) + ") = " + to_string(y));
			window.draw(txt);
		}

		//Отрисовка самого графика
		circle.setPosition(X * scale + 500, -y * scale + 500);
		window.draw(circle);

		sf::Event event;
		while (window.pollEvent(event))
		{
			if (event.type == sf::Event::Closed) {
				window.close();
			}
		}

		window.display();
	}
}

double* ydivlag; //Делители, вычисляемые из h и y

//Интерполяционный многочлен Лагранжа
double lagInt(double X) {

	double sum, Y = 0;

	for (int i = 0; i < Size; i++) {

		sum = y[i];

		for (int j = 0; j < Size; j++) {
			if (i == j) continue;
			
			sum *= (X - x[j]);
		}

		sum /= ydivlag[i];
		Y += sum;
	}

	return Y;
}

//Основная программа вычислений для Лагранжа
void lagrange() {

	ydivlag = new double[Size];

	for (int i = 0; i < Size; i++) {

		ydivlag[i] = 1;

		for (int j = 0; j < Size; j++) {
			if (i == j) continue;

			ydivlag[i] *= x[i] - x[j];
		}
	}

	//Отрисовка графика
	drawGraphics(lagInt);
}


//--------------------------------------------------------------


double* h; //шаг
double* insane_y; //Сложные значения, вычисляемые из h и y
double* c;
double** m; //матрица для вычисления С
double* d;
double* b;

//Вычисление соответствующего точке сплайна
double splineD(double X) {

	int i = 1;
	bool found = false;

	for (i = 1; i < Size; i++) {
		if (X >= x[i - 1] && X <= x[i]) {
			found = true; break;
		}
	}

	if (!found) return -99999;
	//Если вне пределов, выкинуть подальше

	double dif = 1;
	double Y = y[i];
	double diff = (X - x[i]);

	dif *= diff;
	Y += dif * b[i - 1];

	dif *= diff;
	Y += dif * c[i - 1];

	dif *= diff;
	Y += dif * d[i - 1];

	//cout << "y(" << X << ") = " << Y << " \n";

	return Y;
}

//Основная программа вычислений значений для сплайнов
void spline() {

	//Вычисление шагов
	h = new double[Size];
	h[0] = 0;

	for (int i = 1; i < Size; i++) {
		h[i] = x[i] - x[i - 1];
	}

	//Вычисление вспомогательных значений
	insane_y = new double[Size];

	for (int i = 1; i < Size - 1; i++) {
		insane_y[i] = 3 * ((y[i+1] - y[i]) / h[i+1] - (y[i] - y[i-1]) / h[i]);
	}

	//Нахождение матрицы для поиска С
	m = new double*[Size];
	for (int i = 0; i < Size; i++) {
		m[i] = new double[Size];

		for (int j = 0; j < Size; j++) {
			m[i][j] = 0;
		}
	}
	for (int i = 1; i < Size - 1; i++) {
		m[i - 1][i] = h[i];
		m[i][i]		= 2 * (h[i] + h[i + 1]);
		m[i + 1][i] = h[i + 1];
	}


	//Решаем матрицу, находим С
	//Метод прогонки

	c = new double[Size - 1];
	d = new double[Size - 1];
	b = new double[Size - 1];

	double* Y = new double[Size];
	double* a = new double[Size];
	b = new double[Size];
	double* B = new double[Size - 2];

	for (int i = 0; i < Size - 2; i++) { B[i] = insane_y[i + 1]; }

	Y[0] = m[1][1];

	a[0] = -m[1][2] / Y[0]; 
	b[0] = B[0] / Y[0];
	

	int i = 1;

	for (i = 1; i < Size - 3; i++)
	{
		y[i] = m[i + 1][i + 1] + m[i + 1][i] * a[i - 1];
		a[i] = -m[i + 1][i + 2] / Y[i];
		b[i] = (B[i] - m[i + 1][i] * b[i - 1]) / Y[i];
	}

	Y[i] = m[i + 1][i + 1] + m[i + 1][i] * a[i - 1];
	b[i] = (B[i] - m[i + 1][i] * b[i - 1]) / Y[i];

	//Обратный ход
	c[i] = b[i];
	for (i = i - 1; i >= 0; i--)
	{
		c[i] = a[i] * c[i + 1] + b[i];
	}
	c[Size - 2] = 0;

	//------------

	//Оставшиеся коэффициенты находят из С
	d[0] = c[0] / 3 / h[1];
	b[0] = ( (y[1] - y[0]) / h[1] ) + ( h[1] * c[0] ) - ( h[1] * h[1] * d[0] );
	for (int i = 1; i < Size - 1; i++) {
		d[i] = (c[i] - c[i - 1]) / 3 / h[i + 1];
		b[i] = (y[i + 1] - y[i]) / h[i + 1] + h[i + 1] * c[i] - h[i + 1] * h[i + 1] * d[i];
	}

	//Вывод для отладки
	cout << "\n";
	for (int i = 0; i < Size - 1; i++) {
		cout << "c[" << i << "] = " << c[i] << "\n";
		cout << "d[" << i << "] = " << d[i] << "\n";
		cout << "b[" << i << "] = " << b[i] << "\n";
	}

	//Отрисовка графика
	drawGraphics(splineD);
}


//----------------------------------------------------------

double** dy;
double H; //Step

double t(double X) {
	return (X - x[Size - 1]) / H;
}

double newton(double X) {

	double d = t(X); //is t(x) then t(x) * t(x + 1) / 2 then t(x) * t(x + 1) * t(x + 2) / 6
	double crazyFrog = d * dy[Size - 2][0];

	for (int i = 1; i < Size - 2; i++) {

		d *= d + 1;
		d /= i + 1;

		crazyFrog += d * dy[Size - i - 2][i];
	}

	return crazyFrog + y[Size - 1];
}

void newton() {

	H = x[1] - x[0];

	dy = new double* [Size - 1];
	for (int i = 0; i < Size - 1; i++) {
		dy[i] = new double[Size - 1];
	}

	for (int i = 0; i < Size - 1; i++) {
		dy[i][0] = y[i + 1] - y[i];
	}
	for (int j = 1; j < Size - 1; j++) {
		for (int i = 0; i < Size - j - 1; i++) {
			dy[i][j] = dy[i + 1][j - 1] - dy[i][j - 1];
		}
	}

	for (int i = 0; i < Size - 1; i++) {
		for (int j = 0; j < Size - 1; j++) {
			cout << dy[i][j] << "\t";
		}
		cout << "\n";
	}

	//Отрисовываем график
	drawGraphics(newton);
}