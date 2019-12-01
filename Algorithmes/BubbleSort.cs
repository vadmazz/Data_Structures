using System;

namespace Data_and_Algoritmes.Algorithmes
{   /// <summary>
    /// Сортировка пузырьком.
    /// Сложность: o(n*n). За каждый проход элементы сравниваются попарно,
    /// пока не будет достигнут результат. 
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// Выполняет сортировку
        /// </summary>
        /// <param name="m">Множество</param>
        /// <typeparam name="T">Тип множества (должен реализовавыть IComparable)</typeparam>
        public void Sort<T>(T[] m)
            where T : IComparable<T>
        {
            for (int i = 0; i < m.Length; i++)
            {
                for (int j = i + 1; j < m.Length; j++)
                {
                    if (m[j].CompareTo(m[i]) < 0)
                    {
                        var temp = m[i];
                        m[i] = m[j];
                        m[j] = temp;
                    }
                }
            }
        }
    }
}