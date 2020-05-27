namespace Projekt_3
{
    public class SelectionSort : ASorting
    {
        public SelectionSort()
        {
            Type = "Selection";
        }

        public override void Sort(int[] tab)
        {
            stopwatch.Reset();
            stopwatch.Start();

            uint k;
            for (uint i = 0; i < (tab.Length - 1); i++)
            {
                int temp = tab[i];
                k = i;
                for (uint j = i + 1; j < tab.Length; j++)
                    if (tab[j] < temp)
                    {
                        k = j;
                        temp = tab[j];
                    }

                tab[k] = tab[i];
                tab[i] = temp;
            }

            stopwatch.Stop();
            ElapsedTime = stopwatch.Elapsed;
        }
    }
}