namespace Projekt_3
{
    public class QuickSortRecursive : ASorting
    {
        public QuickSortRecursive()
        {
            Type = "Quicksort (recursive)";
        }

        private void sort(int[] tab, int left, int right)
        {
            int i, j, x;
            i = left;
            j = right;
            x = tab[(left + right) / 2];

            do
            {
                while (tab[i] < x) i++;
                while (x < tab[j]) j--;
                if (i <= j)
                {
                    int buf = tab[i];
                    tab[i] = tab[j];
                    tab[j] = buf;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (left < j) sort(tab, left, j);
            if (i < right) sort(tab, i, right);
        }

        public override void Sort(int[] tab)
        {
            stopwatch.Reset();
            stopwatch.Start();

            sort(tab, 0, tab.Length - 1);

            stopwatch.Stop();
            ElapsedTime = stopwatch.Elapsed;
        }
    }
}