using System;

namespace Data_and_Algoritmes.Algorithmes
{
    /// <summary>
    /// Быстрая сортировка.
    /// Сложность o(n log(n)). Выбираем опорный элемент,
    /// рекурсивно разбиваем массив на подмассив элементов относительно опорного.
    /// </summary>
    public class QuickSort
    {
        #region Partition()
        /// <summary>
        /// Меняет местами элементы подмножества от a до b,
        /// сравнивая методом CompareTo
        /// </summary>
        /// <param name="m">Подмножество</param>
        /// <param name="a">Начало подмножества</param>
        /// <param name="b">Конец подмножества</param>
        /// <typeparam name="T">Тип элементов (должен реализовавыть IComparable)</typeparam>
        /// <returns></returns>
        private int Partition<T>(T[] m, int a, int b)
            where T : IComparable<T>
        {
            var i = a;
            for (int j = a; j <= b; j++)
            {
                if (m[j].CompareTo(m[b]) <= 0)// Сравниваем каждый элемент подмножества, начиная с нулевого с последним
                {
                    var t = m[i];//в результате перемещаем значения, меньше пивота(i)влево
                    m[i] = m[j];// возвращаем сам пивот
                    m[j] = t;
                    i++;
                }  
            }

            return i - 1;
        }
        #endregion
        #region Sort()
        /// <summary>
        /// Отсортировать массив алгоритмом быстрой сортировки
        /// </summary>
        /// <param name="m">Множество элементов</param>
        /// <param name="a">Начало пмножества</param>
        /// <param name="b">Конец подмножества</param>
        /// <typeparam name="T">Тип элементов множества</typeparam>
        public void Sort<T>(T[] m, int a, int b)
         where T : IComparable<T>
        {
            var pivot = Partition(m, a, b);
            Sort(m, a, pivot - 1);// Сортируем элементы слева от пивота
            Sort(m, pivot +1, b);// Сортируем элементы справа от пивота
        } 
        #endregion
    }
}