// C++_project.cpp: 定义 DLL 应用程序的导出函数。
//

#include "stdafx.h"
#include "c++_file.h"  
int CPlusPlusClass::Add(int a, int b,Addmethod* method)
{
	if(method)
		return method->add(a,b);
	else 
		return a + b;
}

