using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

namespace Maze
{
    public class Main : MonoBehaviour
    {
        IEnumerator interactiveEnum;

        [SerializeField] private Unit _player;
        [SerializeField] private Bonus[] BonusObj;

        private InputController _inputController;
        private CameraController _cameraController;
        private ListExecuteObjectController _executeObject;

        private void Awake()
        {
            _inputController = new InputController(_player);
            _executeObject = new ListExecuteObjectController(BonusObj);
            _cameraController = new CameraController(_player.transform, Camera.main.transform);

            _executeObject.AddExecuteObject(_inputController);
            _executeObject.AddExecuteObject(_cameraController);
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

            if (Input.GetKey(KeyCode.R))
               SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
