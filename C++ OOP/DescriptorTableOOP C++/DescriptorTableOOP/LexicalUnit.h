
class LexicalUnit
{
private:
	char identificator[20];
	char type[20];
    char descriptor[10];
	int address;
	
	

public:
	LexicalUnit() { identificator[0] = 0; type[0] = 0; descriptor[0] = 0; address = 0; }
	LexicalUnit(const char* anIdentificator, const char* aType,const char* aDescriptor, int anAdress);
	LexicalUnit(LexicalUnit& p);
	~LexicalUnit();
	int setAddress(const char* type);
	char* setDescriptor();
	static int newAddress;
	static int newDescriptor;
	LexicalUnit& operator = (const LexicalUnit& p);
	char* GetIdentificator();
	char* GetType();
	char* GetDescriptor();
	int GetAddress();
	void Print();

    
};

