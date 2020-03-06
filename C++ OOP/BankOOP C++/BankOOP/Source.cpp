#include <iostream>
#include <string>
#include <stdio.h>
#include <new>
#include "Bank.h"

using namespace std;


int main() {
    Bank b(1);

    account info[7];

    info[0] = account("Debit", "LAKS2367", 867.50);
    info[1] = account("Credit", "NIFW9873", 583.20);
    info[2] = account("Credit", "LSKO5364", 1254.40);
    info[3] = account("Credit", "MPIE9872", 234.20);
    info[4] = account("Debit", "IBWM9874", 945.60);
    info[5] = account("Debit", "NOGH9486", 546.60);
    info[6] = account("Credit", "ONUY7483", 324.49);

    BankClient p[5];

    p[0] = BankClient("John", "Wick", 666, info[0]);
    p[1] = BankClient("Arthur", "Bishop", 111, info[1]);
    p[2] = BankClient("Denzel", "Washington", 981, info[2]);
    p[3] = BankClient("Slade", "Wilson", 234, info[3]);
    p[4] = BankClient("Bruce", "Wayne", 456, info[4]);

    p[0].newBankAccount(info[4]);
    p[1].newBankAccount(info[5]);

    b.newClient(p[0]);
    b.newClient(p[1]);
    b.newClient(p[2]);
    b.newClient(p[3]);

    //b.printClients();

    if (b.deleteClient(981)) {
        b.printClients();
    }
    else {
        cout << "No client!" << endl;
    }
    if (b.deleteClient(982)) {
        b.printClients();
    }
    else {
        cout << "No client!\n";
    }


    return 0;
}