namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Collection empty.");
            }

            dynamic sum = 0;
            foreach (var element in collection)
                sum += element;

            return sum;
        }
        
        public static T Product<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Collection empty.");
            }

            dynamic product = 1;
            foreach (var element in collection)
                product *= element;

            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Collection empty");
            }
            dynamic min = collection.First();

            foreach (var element in collection)
	        {
                if (element.CompareTo(min) < 0)
                {
                    min = element;
                }
	        }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Collection empty");
            }
            dynamic max = collection.First();

            foreach (var element in collection)
            {
                if (element.CompareTo(max) > 0)
                {
                    max = element;
                }
            }
            return max;
        }

        public static T Average<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Collection empty");
            }
            dynamic average = 0;

            foreach (var element in collection)
            {
                average += element;
            }
            average /= collection.Count();

            return average;
        }
    }
}
