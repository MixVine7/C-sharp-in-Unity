using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Maze
{
    public class Main : MonoBehaviour
    {
        private InputController _inputController;

        private ListExecuteObjectController _executeObject;

        [SerializeField] private Unit _player;

        [SerializeField] private Bonus[] BonusObj;

        IEnumerator interactiveEnum;

        private void Awake()
        {
            _inputController = new InputController(_player);

            _executeObject = new ListExecuteObjectController(BonusObj);

            _executeObject.AddExecuteObject(_inputController);

            interactiveEnum = _executeObject.GetEnumerator();
        }

        void Update()
        {
            if (_executeObject.MoveNext())
            {
                IExecute temp = (IExecute)_executeObject.Current;
                temp.Update();
            }
            else
            {
                _executeObject.Reset();
                Debug.Log("Reset");
            }

            for (int i = 0; i < _executeObject.Length; i++)
            {
                //if (_executeObject.InteractiveObject[i] == null)
               //{
               //     continue;
               // }
                //_executeObject.InteractiveObject[i].Update();
            }
        }
    }
}
