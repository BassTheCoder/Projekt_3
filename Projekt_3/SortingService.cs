using System;
using System.IO;
using System.Text;

namespace Projekt_3
{
    class SortingService
    {
        static void Log(StreamWriter writer, string text)
        {
            Console.WriteLine(text);
            writer.WriteLine(text);
            writer.Flush();
        }

        public static void Run()
        {
            string filePath = @"C:\Users\Patryk\Desktop\Projekt_3\wyniki.txt";
            FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate);
            using StreamWriter writer = new StreamWriter(stream, Encoding.UTF8);

            ArrayGenerator arrayGenerator = new ArrayGenerator();
            ArrayGenerator generatedArraysCopy = arrayGenerator;

            InsertionSort insertionSort = new InsertionSort();
            CocktailSort cocktailSort = new CocktailSort();
            SelectionSort selectionSort = new SelectionSort();
            HeapSort heapSort = new HeapSort();

            #region Ascending Array
            Log(writer, selectionSort.Type + " Sort - Ascending Array (length; elapsed time)");
            foreach (int[] item in arrayGenerator.AscendingTabList)
            {
                selectionSort.Sort(item);
                Log(writer, item.Length + ";" + selectionSort.ElapsedTime);
            }


            arrayGenerator.AscendingTabList = generatedArraysCopy.AscendingTabList;
            Log(writer, "\n" + insertionSort.Type + " Sort - Ascending Array (length; elapsed time)");
            foreach (int[] item in arrayGenerator.AscendingTabList)
            {
                insertionSort.Sort(item);
                Log(writer, item.Length + ";" + insertionSort.ElapsedTime);
            }


            arrayGenerator.AscendingTabList = generatedArraysCopy.AscendingTabList;
            Log(writer, "\n" + cocktailSort.Type + " Sort - Ascending Array (length; elapsed time)");
            foreach (int[] item in arrayGenerator.AscendingTabList)
            {
                cocktailSort.Sort(item);
                Log(writer, item.Length + ";" + cocktailSort.ElapsedTime);
            }

            arrayGenerator.AscendingTabList = generatedArraysCopy.AscendingTabList;
            Log(writer, "\n" + heapSort.Type + " Sort - Ascending Array (length; elapsed time)");
            foreach (int[] item in arrayGenerator.AscendingTabList)
            {
                heapSort.Sort(item);
                Log(writer, item.Length + ";" + heapSort.ElapsedTime);
            }
            #endregion

            #region Descending Array
            Log(writer, "\n" + selectionSort.Type + " Sort - Descending Array (length; elapsed time)");
            foreach (int[] item in arrayGenerator.DescendingTabList)
            {
                selectionSort.Sort(item);
                Log(writer, item.Length + ";" + selectionSort.ElapsedTime);
            }

            arrayGenerator.DescendingTabList = generatedArraysCopy.DescendingTabList;
            Log(writer, "\n" + insertionSort.Type + " Sort - Descending Array (length; elapsed time)");
            foreach (int[] item in arrayGenerator.DescendingTabList)
            {
                insertionSort.Sort(item);
                Log(writer, item.Length + ";" + insertionSort.ElapsedTime);
            }

            arrayGenerator.DescendingTabList = generatedArraysCopy.DescendingTabList;
            Log(writer, "\n" + cocktailSort.Type + " Sort - Descending Array (length; elapsed time)");
            foreach (int[] item in arrayGenerator.DescendingTabList)
            {
                cocktailSort.Sort(item);
                Log(writer, item.Length + ";" + cocktailSort.ElapsedTime);
            }

            arrayGenerator.DescendingTabList = generatedArraysCopy.DescendingTabList;
            Log(writer, "\n" + heapSort.Type + " Sort - Descending Array (length; elapsed time)");
            foreach (int[] item in arrayGenerator.DescendingTabList)
            {
                heapSort.Sort(item);
                Log(writer, item.Length + ";" + heapSort.ElapsedTime);
            }
            #endregion

            #region Randomized Array
            Log(writer, "\n" + selectionSort.Type + " Sort - Randomized Array (length; elapsed time)");
            foreach (int[] item in arrayGenerator.RandomizedTabList)
            {
                selectionSort.Sort(item);
                Log(writer, item.Length + ";" + selectionSort.ElapsedTime);
            }

            arrayGenerator.RandomizedTabList = generatedArraysCopy.RandomizedTabList;
            Log(writer, "\n" + insertionSort.Type + " Sort - Randomized Array (length; elapsed time)");
            foreach (int[] item in arrayGenerator.RandomizedTabList)
            {
                insertionSort.Sort(item);
                Log(writer, item.Length + ";" + insertionSort.ElapsedTime);
            }

            arrayGenerator.RandomizedTabList = generatedArraysCopy.RandomizedTabList;
            Log(writer, "\n" + cocktailSort.Type + " Sort - Randomized Array (length; elapsed time)");
            foreach (int[] item in arrayGenerator.RandomizedTabList)
            {
                cocktailSort.Sort(item);
                Log(writer, item.Length + ";" + cocktailSort.ElapsedTime);
            }

            arrayGenerator.RandomizedTabList = generatedArraysCopy.RandomizedTabList;
            Log(writer, "\n" + heapSort.Type + " Sort - Randomized Array (length; elapsed time)");
            foreach (int[] item in arrayGenerator.RandomizedTabList)
            {
                heapSort.Sort(item);
                Log(writer, item.Length + ";" + heapSort.ElapsedTime);
            }
            #endregion

            #region V-Shaped Array
            Log(writer, "\n" + selectionSort.Type + " Sort - V-Shaped Array (length; elapsed time)");
            foreach (int[] item in arrayGenerator.VShapedTabList)
            {
                selectionSort.Sort(item);
                Log(writer, item.Length + ";" + selectionSort.ElapsedTime);
            }

            arrayGenerator.VShapedTabList = generatedArraysCopy.VShapedTabList;
            Log(writer, "\n" + insertionSort.Type + " Sort - V-Shaped Array (length; elapsed time)");
            foreach (int[] item in arrayGenerator.VShapedTabList)
            {
                insertionSort.Sort(item);
                Log(writer, item.Length + ";" + insertionSort.ElapsedTime);
            }

            arrayGenerator.VShapedTabList = generatedArraysCopy.VShapedTabList;
            Log(writer, "\n" + cocktailSort.Type + " Sort - V-Shaped Array (length; elapsed time)");
            foreach (int[] item in arrayGenerator.VShapedTabList)
            {
                cocktailSort.Sort(item);
                Log(writer, item.Length + ";" + cocktailSort.ElapsedTime);
            }

            arrayGenerator.VShapedTabList = generatedArraysCopy.VShapedTabList;
            Log(writer, "\n" + heapSort.Type + " Sort - V-Shaped Array (length; elapsed time)");
            foreach (int[] item in arrayGenerator.VShapedTabList)
            {
                heapSort.Sort(item);
                Log(writer, item.Length + ";" + heapSort.ElapsedTime);
            }
            #endregion
        }
    }
}
