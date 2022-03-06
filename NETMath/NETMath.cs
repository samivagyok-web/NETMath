using System;
using System.Linq;

namespace NETMath
{
    public static class NETMath
    {
        /// <summary>
        /// Calculates the sum for the values between the inclusive lower bounds and inclusive upper bound.
        /// </summary>
        /// <param name="lowerBound"></param>
        /// <param name="upperBound"></param>
        /// <returns>Calculates the sum for the values between the inclusive lower bounds and inclusive upper bound.</returns>
        public static int SumBetween(int lowerBound, int upperBound)
        {
            int sum = 0;

            for (int i = lowerBound; i <= upperBound; i++)
            {
                sum += i;
            }

            return sum;
        }

        /// <summary>
        /// Calculates the product for the values between the inclusive lower bounds and inclusive upper bound.
        /// </summary>
        /// <param name="lowerBound"></param>
        /// <param name="upperBound"></param>
        /// <returns>Returns the product for the values between the inclusive lower bounds and inclusive upper bound.</returns>
        public static int ProductBetween(int lowerBound, int upperBound)
        {
            int sum = 1;

            for (int i = lowerBound; i <= upperBound; i++)
            {
                sum *= i;
            }

            return sum;
        }

        /// <summary>
        /// Calculates the product of an array of doubles.
        /// </summary>
        /// <param name="values"></param>
        /// <returns>Returns the product on the values.</returns>
        public static double Product(double[] values)
        {
            double sum = 1;

            foreach (var value in values)
            {
                sum *= value;
            }

            return sum;
        }

        /// <summary>
        /// Finds the mean value of an array of doubles.
        /// </summary>
        /// <param name="values">Array of doubles for which you want to find the mean.</param>
        /// <returns>Returns the mean value of the values.</returns>
        public static double Mean(double[] values) => Sort(values)[values.Length / 2];

        /// <summary>
        /// Calculates the average of an array of doubles.
        /// </summary>
        /// <param name="values">Array of doubles for which you want to calculate the average.</param>
        /// <returns>Returns the average of the values.</returns>
        public static double Average(double[] values) => values.Average();

        /// <summary>
        /// Calculates the degree-th root for a double value.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="degree"></param>
        /// <returns>Returns the degree-th root for value.</returns>
        public static double Root(double value, double degree) => Math.Pow(value, 1 / degree);

        /// <summary>
        /// Calculates the geometric mean of an array of doubles.
        /// </summary>
        /// <param name="values"></param>
        /// <returns>Returns the geometric average of the values.</returns>
        public static double GeometricMean(double[] values) => Root(Product(values), values.Length);

        /// <summary>
        /// Calculates the factorial of n.
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Returns -1 in case n is negative, otherwise returns the factorial of n.</returns>
        public static int Factorial(int n)
        {
            if (n < 0)
                return -1;

            if (n == 0)
                return 1;

            return ProductBetween(1, n);
        }

        /// <summary>
        /// Calculates from a collection of n items, a way of selecting k items, such that the order of selection does matter.
        /// </summary>
        /// <param name="numberOfItems"></param>
        /// <param name="selectedItems"></param>
        /// <returns>Returns the number of variations of k items from n items.</returns>
        public static int Variation(int numberOfItems, int selectedItems)
        {
            if (numberOfItems < 1 && selectedItems < numberOfItems)
                return -1;

            return Factorial(numberOfItems) / Factorial(numberOfItems - selectedItems);
        }

        /// <summary>
        /// Calculates from a collection of n items, a way of selecting k items, such that the order of selection does not matter.
        /// </summary>
        /// <param name="numberOfItems"></param>
        /// <param name="selectedItems"></param>
        /// <returns>Returns the number of combinations of k items from n items.</returns>
        public static int Combination(int numberOfItems, int selectedItems)
        {
            if (numberOfItems < 1 && selectedItems < numberOfItems)
                return -1;

            return Factorial(numberOfItems) / (Factorial(numberOfItems - selectedItems) * Factorial(selectedItems));
        }

        private static double[] Sort(double[] values) => values.OrderBy(p => p).ToArray();
    }
}
