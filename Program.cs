string[] arrayStart = {"ехали", "медведи", "на", "велосипеде", "а", "за", "ними", "раки", "на", "хромой", "собаке", "вот", "и", "сказочке", "esc", "кто", "не", "понял", "F1"};
string[] arrayResult = new string[arrayStart.Length];
int count = 0;

for (int i = 0; i < arrayStart.Length; i++)
{
    if (arrayStart[i].Length < 4)
    {
        arrayResult[count] = arrayStart[i];
        count++;
    }
}

string[] arrayItog = new string[count];

for (int i = 0; i < count; i++)
{
    arrayItog[i] = arrayResult[i];
}

Console.WriteLine(string.Join(", ", arrayItog));