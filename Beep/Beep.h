// Beep.h
#include <Windows.h>
#include <math.h>
#include <cmath>
#pragma once

using namespace System;

public ref class Beeper
{
public:
	static void beepnow(int freq,int ms) {
		Beep(freq,ms);
	}
};
