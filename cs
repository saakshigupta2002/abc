//only have a key
#include<cs50.h>
#include<stdio.h>
#include<ctype.h>
#include<stdlib.h>
#include<string.h>

int main(int argc, string argv[])
{
    int key = 0;
    if(argc == 2)
    {
        key = atio(argv[1]);
        if(key > 26)
        {
            key %= 26;
        }
    }
    if(argc != 2 || key<=0)
    {
        printf("usage not define");
        return 1;
    }
}
