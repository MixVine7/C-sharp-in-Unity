using System.Collections;
using System;
using UnityEngine;
using System.Collections.Generic;

namespace Maze
{
    public class ListExecuteObjectController : IEnumerable, IEnumerator
    {
        private int _index = -1;
        private IExecute[] _interactiveObject;
        private List<IExecute> temp;
        public int Length => _interactiveObject.Length;
        public object Current => _interactiveObject[_index];

        public IExecute this[int curr]
        { 
            get => _interactiveObject[curr]; 
            private set => _interactiveObject[curr] = value; 
        }

        public ListExecuteObjectController(Bonus[] bonuses)
        {
            for (int i = 0; i < bonuses.Length; i++)
            {
                if (bonuses[i] is IExecute intObject)
                {
                    AddExecuteObject(intObject);
                }
            }
        }

        public void AddExecuteObject(IExecute execute)
        {
            if(_interactiveObject == null)
            {
                _interactiveObject = new[] {execute};
                return;
            }

            Array.Resize(ref _interactiveObject, Length + 1);
            _interactiveObject[Length -1] = execute;
        }

        public bool MoveNext()
        {
            if(_index==Length-1)
            {
                return false;
            }
            _index++;
            return true;
        }

        public void Reset()
        {
            _index = -1;
        }

        public IEnumerator GetEnumerator() 
        {
            return this;
        }

    }
}
