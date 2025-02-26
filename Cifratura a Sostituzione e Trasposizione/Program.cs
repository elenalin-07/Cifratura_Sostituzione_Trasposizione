void sostituzione(int k, char[] c)
{
    int position = 0;
    char[] alfabeto = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
    for (int i = 0; i < c.Length; i++)
    {
        for (int j = 0; j < alfabeto.Length; j++)
        {
            if(c[i] == alfabeto[j])
            {
                position = j;
            }
        }
        if (position + k < alfabeto.Length)
        {
            c[i] = alfabeto[position + k];
        }
        else
        {
            c[i] = alfabeto[position + k - alfabeto.Length];
        }

    }
}

void trasposizione(int k, char[] c)
{
    char[] a = new char[c.Length];
    for(int i  = 0; i < c.Length; i++)
    {
        a[i] = c[i];
    }
    for (int i = 0; i < c.Length; i++)
    {
        if(i+k < c.Length)
        {
            c[i + k] = a[i];
        }
        else
        {
            c[i + k - c.Length] = a[i];
        }
    }
}

void stampa(char[] c)
{
    string m_ST = string.Concat(c);
    Console.WriteLine(m_ST.ToUpper());
}

void decifratura_t(){

}

Console.WriteLine("inserisci un messaggio da cifrare formato da solo lettere");
string messaggio = Console.ReadLine();
Console.WriteLine("inserisci un numero per posizione da spostare nell'alfabeto");
int k1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("inserisci un numero per posizione da spostare");
int k2 = Int32.Parse(Console.ReadLine());

char[] char_messaggio = messaggio.ToCharArray(0, messaggio.Length);
sostituzione(k1, char_messaggio);
trasposizione(k2, char_messaggio);
stampa(char_messaggio);
