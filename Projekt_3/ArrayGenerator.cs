using System;
using System.Collections.Generic;

namespace Projekt_3
{
    class ArrayGenerator
    {

        public List<int[]> AscendingTabList = new List<int[]>();
        public List<int[]> DescendingTabList = new List<int[]>();
        public List<int[]> RandomizedTabList = new List<int[]>();
        public List<int[]> VShapedTabList = new List<int[]>();
        public List<int[]> AShapedTabList = new List<int[]>();
        public List<int[]> ConstantTabList = new List<int[]>();

        public ArrayGenerator()
        {
            AscendingTabList = GenerateAscendingArrayList(AscendingTabList);
            DescendingTabList = GenerateDescendingArrayList(DescendingTabList);
            RandomizedTabList = GenerateRandomizedArrayList(RandomizedTabList);
            VShapedTabList = GenerateVShapedArrayList(VShapedTabList);
            AShapedTabList = GenerateAShapedArrayList(AShapedTabList);
            ConstantTabList = GenerateConstantArrayList(ConstantTabList);
        }

        public static List<int[]> GenerateAscendingArrayList(List<int[]> TabList)
        {

            for (int k = 50000; k <= 200000; k += 5000)
            {
                int[] tab = new int[k];

                for (int j = 0; j < k; j++)
                {
                    tab[j] = j;
                }

                TabList.Add(tab);
            }

            return TabList;
        }

        public static List<int[]> GenerateDescendingArrayList(List<int[]> TabList)
        {

            for (int k = 50000; k <= 200000; k += 5000)
            {
                int[] tab = new int[k];

                for (int j = 0; j < k; j++)
                {
                    tab[j] = -j;
                }

                TabList.Add(tab);
            }

            return TabList;
        }

        public static List<int[]> GenerateRandomizedArrayList(List<int[]> TabList)
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());

            for (int k = 50000; k <= 200000; k += 5000)
            {
                int[] tab = new int[k];

                for (int j = 0; j < k; j++)
                {
                    tab[j] = rnd.Next(k);
                }

                TabList.Add(tab);
            }

            return TabList;
        }

        public static List<int[]> GenerateVShapedArrayList(List<int[]> TabList)
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());

            for (int k = 50000; k <= 200000; k += 5000)
            {
                int[] tab = new int[k];

                for (int j = 0; j < k; j++)
                {
                    if (j <= k / 2)
                    {
                        tab[j] = k / 2 - j;
                    }
                    else if (j > k / 2)
                    {
                        tab[j] = j - k / 2;
                    }
                }

                TabList.Add(tab);
            }

            return TabList;
        }

        public static List<int[]> GenerateConstantArrayList(List<int[]> TabList)
        {

            for (int k = 50000; k <= 200000; k += 5000)
            {
                int[] tab = new int[k];

                for (int j = 0; j < k; j++)
                {
                    tab[j] = 5;
                }

                TabList.Add(tab);
            }

            return TabList;
        }

        public static List<int[]> GenerateAShapedArrayList(List<int[]> TabList)
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());

            for (int k = 50000; k <= 200000; k += 5000)
            {
                int[] tab = new int[k];

                for (int j = 0; j < k; j++)
                {
                    if (j <= k / 2)
                    {
                        tab[j] = j - k / 2;
                    }
                    else if (j > k / 2)
                    {
                        tab[j] = k / 2 - j;
                    }
                }

                TabList.Add(tab);
            }

            return TabList;
        }
    }
}