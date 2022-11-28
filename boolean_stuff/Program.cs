// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using System.Collections.Generic;

int n = 128;
bool nextXOR = false;


string nString = Convert.ToString(n, 2);

char[] bitArray = nString.ToCharArray();
List<bool> boolList = new List<bool>();

foreach (char chars in bitArray)
{
    if (Convert.ToInt16(Convert.ToString(chars)) == 1)
    {
        boolList.Add(true);
    }
    else
    {
        boolList.Add(false);
    }
}
Console.WriteLine(String.Join(",", boolList));

//task 2

nextXOR = Convert.ToBoolean(Convert.ToInt16(Convert.ToString(bitArray[0]))) ^ Convert.ToBoolean(Convert.ToInt16(Convert.ToString(bitArray[1])));

for (int i = 2;i<bitArray.Length;i++)
{
    nextXOR = nextXOR ^ Convert.ToBoolean(Convert.ToInt16(Convert.ToString(bitArray[i])));
}

//even parity check
Debug.Assert(nextXOR == true);



//task 3
int count = 0;
for (int i = 0; i < bitArray.Length; i++)
{
    if (bitArray[i] == '1')
    {
        count += 1;
    }
}
Debug.Assert(count == 1);

//task 4

int count2 = 0;
while (n!=0)
{
    n = n & n - 1;
    count2++;
}

Debug.Assert(count2 == 1);

//task 5

string word1 = "hello";
string word2 = "world";

char[] word1Array = word1.ToCharArray();
char[] word2Array = word2.ToCharArray();

List<string> vernamList = new List<string>();

for (int i = 0; i < word1Array.Length; i++)
{
    vernamList.Add(Convert.ToString(word1Array[i] ^ word2Array[i],2));
}

Console.WriteLine(String.Join(",", vernamList));