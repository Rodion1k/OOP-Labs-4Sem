using System.Collections.Generic;
using System.Data;

namespace LP_Lab10
{
    public static class UndoManager
    {
        private static List<DataSet> _Stack = new List<DataSet>();
        private static int _currentIndex = -1;
        public static void Add(DataSet dataSet)
        {
            _Stack.Add(dataSet);
            _currentIndex++;
        }

        public static void Clear()
        {
            _currentIndex = -1;
            _Stack.Clear();
        }
        

        public static DataSet Undo()
        {
            _currentIndex--;
            return _Stack[_currentIndex];
        }
        public static DataSet Redo()
        {
            _currentIndex++;
            return _Stack[_currentIndex];
        }
        public static int State
        {
            get => _currentIndex;
        }
        public static int Count
        {
            get => _Stack.Count;
        }
        
    }
}