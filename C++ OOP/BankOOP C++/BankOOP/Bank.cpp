#include "Bank.h"
#include <iostream>
#include <string>
#include <stdio.h>
#include <new>

using namespace std;

Bank::Bank(int size) {
    Size = FNumber.Set(size);
    tableEnd = 0;
    Table = new BankClient[Size];

}

void Bank::Resize() {
    Size *= FNumber.Get();
    BankClient* newTable = new BankClient[Size];

    for (int i = 0; i < tableEnd; i++) {
        newTable[i] = Table[i];
    }

    delete[] Table;

    Table = newTable;
}




int Bank::newClient(BankClient& p) {
    if (tableEnd == Size) {

        Resize();

    }
    Table[tableEnd++] = p;
    return 1;
}




Bank Bank::getTableEnd() {
    return tableEnd;
}

int Bank::deleteClient(int clNum) {


    for (int i = 0; i < tableEnd; i++) {
        if (Table[i].getClientNum() == clNum) {
            while (i < tableEnd - 1) {
                Table[i] = Table[i + 1];
                i++;
            }
            tableEnd--;
            return 1;
        }
    }
    return 0;
}

int Bank::printClients() {
    for (int i = 0; i < tableEnd; i++)
        Table[i].printAll();
    return 1;
}
