StreamReader input = new StreamReader("../../../Large_Input.txt");
int t = int.Parse(input.ReadLine());
for (int i = 1; i <= t; i++)
{
    string[] parameters = input.ReadLine().Split(' ').Where(x => x.Trim().Length > 0).ToArray();
    int B = int.Parse(parameters[0]);
    int C = int.Parse(parameters[1]);
    int D = int.Parse(parameters[2]);
    int[] E = Array.ConvertAll(input.ReadLine().Split(' ').Where(x => x.Trim().Length > 0).ToArray(), int.Parse);
    int nBenches = 0, nStools = 0, rent = 0;
    for (int j = 0; j < E.Length; j += B)
    {
        int nCustomers = 0;
        for (int k = j; k < j + B && k < E.Length; k++)
        {
            nCustomers += E[k];
        }

        if (nCustomers <= 2)
        {
            nStools += nCustomers;
        }
        else if (nCustomers % 2 == 0)
        {
            nBenches += nCustomers / 2;
        }
        else
        {
            nBenches += nCustomers / 2;
            nStools += 1;
        }
    }

    rent = nBenches * D + nStools * C;
    Console.WriteLine("Case #{0}: {1} {2}", i, nBenches * 2 + nStools, rent);
}