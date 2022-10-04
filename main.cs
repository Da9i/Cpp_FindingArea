using namespace std;
//for circle.
int calcArea(int& a)
{
	return 3.14*a*a;
}
float calcArea(float& a)
{
	return 3.14*a*a;
}
double calcArea(double& a)
{
	return 3.14*a*a;
}
//for rectangle.
int calcArea(int& a, int& b)
{
	return a * b;
}
float calcArea(float& a, float& b)
{
	return a * b;
}
double calcArea(double& a, double& b)
{
	return a * b;
}
int main()
{
	int opt;
	char option;
	cout << "PRESS 1 FOR FINDING AREA OF CIRCLE :" << endl;
	cout<< "PRESS 2 FOR FINDING AREA OF RECTANGLE :" << endl;
	cin >> opt;
	if (opt == 1)
	{
		cout << "PRESS A FOR INT :" << endl;
		cout << "PRESS B FOR FLOAT :" << endl;
		cout << "PRESS C FOR DOUBLE :" << endl;
		cin >> option;
		if (option == 'a' || option == 'A')
		{
			int r;
			cout << "ENTER THE RADIUS :"<<endl;
			cin >> r;
			cout << calcArea(r);
		}
		else if (option == 'b' || option == 'B')
		{
			float r;
			cout << "ENTER THE RADIUS :" << endl;
			cin >> r;
			cout << calcArea(r);
		}
		else if (option == 'c' || option == 'C')
		{
			double r;
			cout << "ENTER THE RADIUS :" << endl;
			cin >> r;
			cout << calcArea(r);
		}

	}
	else if (opt == 2)
	{
		cout << "PRESS A FOR INT :" << endl;
		cout << "PRESS B FOR FLOAT :" << endl;
		cout << "PRESS C FOR DOUBLE :" << endl;
		cin >> option;
		if (option == 'a'||option=='A')
		{
			int length, width;
			cout << "ENTER THE LENGTH OF RECTANGLE :"<<endl;
			cin >> length;
			cout << "ENTER THE WIDTH OF RECTANGLE :" << endl;
			cin>> width;
			cout << calcArea(length, width);
		}
		else if (option == 'b' || option == 'B')
		{
			float length, width;
			cout << "ENTER THE LENGTH OF RECTANGLE :" << endl;
			cin >> length;
			cout << "ENTER THE WIDTH OF RECTANGLE :" << endl;
			cin >> width;
			cout << calcArea(length, width);
		}
		else if (option == 'c' || option == 'C')
		{
			double length, width;
			cout << "ENTER THE LENGTH OF RECTANGLE :" << endl;
			cin >> length;
			cout << "ENTER THE WIDTH OF RECTANGLE :" << endl;
			cin >> width;
			cout << calcArea(length, width);
		}
	}
	cout << endl;
	system("pause>0");
}
