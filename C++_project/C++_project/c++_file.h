#pragma once


class Addmethod
{
public:
	virtual int add(int a, int b) { return 0; };
	virtual ~Addmethod() {}
};

class CPlusPlusClass
{
public:
	// ���Զ�C++ģ���ж����Class�ĵ���  
	int Add(int a,int b,Addmethod* method);
};
