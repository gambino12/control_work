string[] FealNewArray(string[] a)
    {
    string[] NewArr = new string[a.Length];
        for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length <= 3)
                NewArr[i] = a[i];
            }
        return NewArr;
    }

void ShowArr(string[] txt)
{
    for (int i = 0; i < txt.GetLength(0); i++)
        {
            Console.Write(txt[i] + " ");
        }
}

string[] arr = { "privet", "ya", "aleksandr","mne","20","let" ,"<3"};

ShowArr(FealNewArray(arr));