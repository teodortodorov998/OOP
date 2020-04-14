#include <iostream>
#include "DescriptorTable.h"
#include <string>
#include <fstream>



using namespace std;


int main(){
    
        fstream table;

        table.open("DescriptorTable.txt", ios::out);

        LexicalUnit lu[4];

        DescriptorTable D;

        if (!table)
        {
            cout << "Error in opening the file!" << endl;
            return 0;
        }

        cout << "File opened successfuly!" << endl;
        
       
        lu[0] = LexicalUnit("i", "int", lu[0].setDescriptor(), 0);
        D.AddLexicalUnit(lu[0]);
        table << D.GetTable(0).GetIdentificator() << " " << D.GetTable(0).GetType() << endl;
        
        
        
        lu[1] = LexicalUnit("delta", "float", lu[1].setDescriptor(), lu[0].setAddress("int"));
        D.AddLexicalUnit(lu[1]);
        table << D.GetTable(1).GetIdentificator() << " " << D.GetTable(1).GetType() << endl;
        
        
        
        
        lu[2] = LexicalUnit("varch", "char", lu[2].setDescriptor(), lu[2].setAddress("float"));
        D.AddLexicalUnit(lu[2]);
        table << D.GetTable(2).GetIdentificator() << " " << D.GetTable(2).GetType() << endl;
        
        
        
        
        lu[3] = LexicalUnit("alpha", "double", lu[3].setDescriptor(), lu[3].setAddress("char"));
        D.AddLexicalUnit(lu[3]);
        table << D.GetTable(3).GetIdentificator() << " " << D.GetTable(3).GetType() << endl;

        table.close();
        
        table.open("DescriptorTable.txt", ios::in);

        if (!table)
        {
            cout << "Error in opening the file!" << endl;
            return 0;
        }

        string line;

        cout << "Lexical units:" << endl;

        while (getline(table, line))
        {
            
            cout << line << endl;
            
        }
        
        table.close();

        cout << endl;
        cout << "Descriptor table:" << endl;

        D.Print();

        return 0;
}


