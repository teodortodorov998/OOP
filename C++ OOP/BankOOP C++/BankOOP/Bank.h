#include "TFibonacci.h"
#include "BankClient.h"

class Bank {
private:
    BankClient* Table;
    TFibonacci FNumber;
    int Size;
    int tableEnd;




public:
    Bank() { Table = new BankClient[2]; Size = 2; tableEnd = 0; }
    Bank(int size);
    ~Bank() { delete[] Table; Size = 0; tableEnd = 0; }
    void Resize();
    int newClient(BankClient& p);
    int deleteClient(int clNum);
    Bank getTableEnd();
    int printClients();


};