namespace Projekt_3
{
    public class CocktailSort : ASorting
    {
        public CocktailSort()
        {
            Type = "Cocktail";
        }

        public override void Sort(int[] tab)
        {
            stopwatch.Reset();
            stopwatch.Start();

            int left = 1, right = tab.Length - 1, k = tab.Length - 1;
            do
            {
                for (int j = right; j >= left; j--)
                    if (tab[j - 1] > tab[j])
                    {
                        int temp = tab[j - 1];
                        tab[j - 1] = tab[j];
                        tab[j] = temp;
                        k = j;
                    }

                left = k + 1;

                for (int j = left; j <= right; j++)
                    if (tab[j - 1] > tab[j])
                    {
                        int temp = tab[j - 1];
                        tab[j - 1] = tab[j];
                        tab[j] = temp;
                        k = j;
                    }

                right = k - 1;
            } 
            while
                (left <= right);

            stopwatch.Stop();
            ElapsedTime = stopwatch.Elapsed;
        }
    }
}