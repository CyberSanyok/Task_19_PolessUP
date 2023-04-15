internal class Program
{
    private static void Main(string[] args)
    {
        int j = 0;
        int[] barcodes = { 1, 1, 1, 2, 2, 2 };
        FixBarcode(barcodes,j);
        foreach(int i in barcodes) { Console.WriteLine(i); }
    }
    public static void FixBarcode(int[] barcodes,int j) 
    {
        if (barcodes[0] == barcodes[1] || barcodes[1] == barcodes[2])
        {

            for (int i = 0; i < barcodes.Length / 2; i += 1)
            {
                if (barcodes[i] == barcodes[i + 1])
                {
                    int temp = barcodes[i];
                    barcodes[i] = barcodes[barcodes.Length-i-1];
                    barcodes[barcodes.Length-i-1] = temp;
                }
            }
            j++;
            if (j > 10) return;
            FixBarcode(barcodes,j);
        }
        else return;
    }
}