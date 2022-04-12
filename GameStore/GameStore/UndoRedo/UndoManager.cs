using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GameStore.UndoRedo
{
    public static class UndoManager
    {
        private static ObservableCollection<ObservableCollection<Game>> _state = new ObservableCollection<ObservableCollection<Game>>();
        private static int _currentState = -1;

        public static void Add(ObservableCollection<Game> games)
        {
            _state.Add(games);
            _currentState++;
        }

        public static ObservableCollection<Game> Undo()
        {
            _currentState--;
            return _state[_currentState];
        }

        public static ObservableCollection<Game> Redo()
        {
            _currentState++;
            return _state[_currentState];
        }

        public static int State
        {
            get => _currentState;
        }
        public static int Count
        {
            get => _state.Count;
        }
    }
}