

int SumValues(int[] pArray )
{
    int total = 0;

    foreach (int integer in pArray)
    {
        total += integer;
    }


    return total;
}

SumValues(pArray: new int[5] { 1, 2, 3, 4, 5 });

