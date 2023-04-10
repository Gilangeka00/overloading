using System;
class Program
{
    static void Main(string[] args)
    {
        int[] inputNilai = new int[3];

        for (int i = 0; i < inputNilai.Length; i++)
        {
            Console.Write("Inputkan Nilai Mahasiswa Ke-" + (i + 1) + ": ");
            inputNilai[i] = int.Parse(Console.ReadLine());
        }

        int maxNilai = CariNilaiTertinggi(inputNilai);
        int minNilai = CariNilaiTerendah(inputNilai);

        Console.WriteLine("Nilai tertinggi adalah: " + maxNilai);
        Console.WriteLine("Nilai terendah adalah: " + minNilai);

        Console.ReadLine();
    }
    static int CariNilaiTertinggi(int[] nilai)
    {
        int maxNilai = int.MinValue;
        for (int i = 0; i < nilai.Length; i++)
        {
            if (nilai[i] > maxNilai)
            {
                maxNilai = nilai[i];
            }
        }
        return maxNilai;
    }
    static int CariNilaiTerendah(int[] nilai)
    {
        int minNilai = int.MaxValue;
        for (int i = 0; i < nilai.Length; i++)
        {
            if (nilai[i] < minNilai)
            {
                minNilai = nilai[i];
            }
        }
        return minNilai;
    }
}
