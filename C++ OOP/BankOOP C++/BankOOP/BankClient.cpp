#include <iostream>
#include <string>
#include <stdio.h>
#include <new>
#include "Bank.h"


using namespace std;


account::account(const char* bankAccType, const char* iBAN, double Sum) {
    strcpy_s(bankAccountType, bankAccType);
    strcpy_s(IBAN, iBAN);
    sum = Sum;

};

BankClient::BankClient() {
    clientNum = 0;
    bankAccountNum = 0;
}


BankClient::BankClient(const char* fName, const char* lName, int cNum, account info) {
    strcpy_s(fname, fName);
    strcpy_s(lname, lName);
    bankAccountNum = 0;
    clientNum = cNum;

    strcpy_s(bankAccountInfo[bankAccountNum].bankAccountType, info.bankAccountType);
    strcpy_s(bankAccountInfo[bankAccountNum].IBAN, info.IBAN);
    bankAccountInfo[bankAccountNum].sum = info.sum;
    bankAccountNum++;

}
BankClient::BankClient(BankClient& p) {
    strcpy_s(fname, p.fname);
    strcpy_s(lname, p.lname);
    bankAccountNum = p.bankAccountNum;
    clientNum = p.clientNum;

    for (size_t i = 0; i < bankAccountNum; i++)
    {
        strcpy_s(bankAccountInfo[i].bankAccountType, p.bankAccountInfo->bankAccountType);
        strcpy_s(bankAccountInfo[i].IBAN, p.bankAccountInfo->IBAN);
        bankAccountInfo[i].sum = p.bankAccountInfo->sum;

    }

}

BankClient::~BankClient() {};

BankClient& BankClient::operator = (const BankClient& p) {
    strcpy_s(fname, p.fname);
    strcpy_s(lname, p.lname);
    bankAccountNum = p.bankAccountNum;
    clientNum = p.clientNum;
    for (size_t i = 0; i < bankAccountNum; i++)
    {
        strcpy_s(bankAccountInfo[i].bankAccountType, p.bankAccountInfo[i].bankAccountType);
        strcpy_s(bankAccountInfo[i].IBAN, p.bankAccountInfo[i].IBAN);
        bankAccountInfo[i].sum = p.bankAccountInfo[i].sum;
    }
    return *this;
}



int BankClient::getBankAccNum() {
    return bankAccountNum;
}

int BankClient::newBankAccount(account info) {
    strcpy_s(bankAccountInfo[bankAccountNum].bankAccountType, info.bankAccountType);
    strcpy_s(bankAccountInfo[bankAccountNum].IBAN, info.IBAN);
    bankAccountInfo[bankAccountNum].sum = info.sum;
    bankAccountNum++;
    return 1;
}

account* BankClient::searchByIBAN(char* iBAN) {

    for (int i = 0; i < bankAccountNum; i++) {
        if (strcmp(bankAccountInfo[i].IBAN, iBAN)) {
            return &bankAccountInfo[i];
        }
    }

    return NULL;
}

int BankClient::deleteBankAccount(char* iBAN) {
    account* p = searchByIBAN(iBAN);
    if (p == NULL) return 0;
    for (size_t i = 0; i < bankAccountNum; i++)
    {
        if (strcmp(bankAccountInfo[i].IBAN, p->IBAN)) {
            if (p->sum < 0) return 0;

            while (i <= bankAccountNum - 1)
                bankAccountInfo[i++] = bankAccountInfo[i + 1];
            bankAccountNum--; return 1;
        }
    }
}




int BankClient::addSumToAcc(char* iBAN, double Sum) {
    account* p = searchByIBAN(iBAN);
    if (p == NULL) return 0;
    p->sum += Sum;
    return 1;
}

double BankClient::allMoney() {
    double allSum = 0;
    for (int i = 0; i < bankAccountNum; i++) {
        allSum += bankAccountInfo[i].sum;
    }
    return allSum;
}

int BankClient::printAll() {
    cout << "Name\t" << fname << endl << "Fam\t" << lname << endl;
    cout << "Number of accounts " << bankAccountNum << endl;
    for (int i = 0; i < bankAccountNum; i++) {
        cout << " Account " << i << endl;
        cout << "\tType: " << bankAccountInfo[i].bankAccountType << endl;
        cout << "\tIBAN: " << bankAccountInfo[i].IBAN << endl;
        cout << "\tSum: " << bankAccountInfo[i].sum << endl;
    }
    cout << endl;
    return 1;
}

int BankClient::getClientNum() {
    return clientNum;
}