// MathLibrary.cpp : Определяет экспортируемые функции для DLL.
//

#include "pch.h"
#include "framework.h"
#include "MathLibrary.h"


int Sum(int a, int b) {
	return a + b;
}


int Diff(int a, int b) {
	return a - b;
}

int Composition(int a, int b) {
	return a * b;
}

int Division(int a, int b) {
	return a / b;
}