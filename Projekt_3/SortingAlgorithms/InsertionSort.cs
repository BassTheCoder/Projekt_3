namespace Projekt_3
{
    public class InsertionSort : ASorting
    {
        public InsertionSort()
        {
            Type = "Insertion";
        }

        public override void Sort(int[] tab)
        {
            stopwatch.Reset();
            stopwatch.Start();

            for (uint i = 1; i < tab.Length; i++)
            {
                uint j = i;
                int temp = tab[j];

                while ((j > 0) && (tab[j - 1] > temp))
                {
                    tab[j] = tab[j - 1];
                    j--;
                }

                tab[j] = temp;
            }

            stopwatch.Stop();
            ElapsedTime = stopwatch.Elapsed;
        }
    }
}