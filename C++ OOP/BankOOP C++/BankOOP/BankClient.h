struct account {
    char bankAccountType[20];
    char IBAN[23];
    double sum;

    account() { sum = 0; bankAccountType[0] = 0; IBAN[0] = 0; }
    account(const char* bankAccType, const char* iBAN, double Sum);
};


class BankClient {
private:
    char fname[20];
    char lname[20];
    int bankAccountNum;
    int clientNum;
    account bankAccountInfo[10];

public:
    BankClient();
    BankClient(const char* fName, const char* lName, int cNum, account info);
    BankClient(BankClient& p);
    ~BankClient();
    int newBankAccount(account info);
    int deleteBankAccount(char* iBAN);
    account* searchByIBAN(char* iBAN);
    int addSumToAcc(char* iBAN, double Sum);
    double allMoney();
    int getClientNum();
    int getBankAccNum();
    int printAll();
    BankClient& operator = (const BankClient& p);
};

