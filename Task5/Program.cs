





using System.Diagnostics.CodeAnalysis;

static string ReverseWord(string strNew)
{
    string[] strNewSplit = strNew.Split();

    string res = "";
    for (int i = strNewSplit.Length - 1; i >= 0; i--)
    {
        res += strNewSplit[i] + " ";
    }

    return res;
}
string strNew = "Hello my World";
string res = ReverseWord(strNew);

Console.WriteLine(res);
