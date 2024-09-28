#include "Animal.h"
using namespace std;

Animal::Animal()
{
	age = 0;
	weight = 0;
	isCarnivore = false;
};

Animal::Animal(int _age, double _weight, bool _isCarnivore)
{
	if (_age < 0 || _weight < 0.0)
		return;

	age = _age;
	weight = _weight;
	isCarnivore = _isCarnivore;
};

Animal::~Animal()
{
};

void Animal::getInfo()
{
	cout << "Возраст: " + to_string(age) << endl;
	cout << "Вес: " + to_string(weight) << endl;
	cout << "Плотоядное: " + to_string(isCarnivore) << endl;
}

void Animal::growUp()
{
	age++;
}

void Animal::feed()
{
	weight += 0.5;
}