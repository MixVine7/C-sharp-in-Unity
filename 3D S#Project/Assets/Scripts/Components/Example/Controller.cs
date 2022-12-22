using System.Collections;
using System.Collections.Generic;
using TestMVC;
using UnityEditor;
using UnityEngine;

namespace TestMCV
{
    public class Controller
    {
        private View _playerView;
        private View _triggerView;
        private Transform _playerT;

        public Controller(View playerView, View triggerView)
        {
            _playerView = playerView;
            _triggerView = triggerView;
            _playerT = _playerView._Transform;

            _triggerView.OnLevelObjectContact += ControllerRecieveAction;
        }

        private void ControllerRecieveAction(Collider col, int val, Transform ObjT)
        {
            Debug.Log("обработчик события: Имя объекта в триггере - " + col.name);
            GameObject.Destroy(col.gameObject);
        }
    }
}
