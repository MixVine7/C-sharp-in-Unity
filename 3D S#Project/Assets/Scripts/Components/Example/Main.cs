using System.Collections;
using System.Collections.Generic;
using TestMVC;
using UnityEngine;

namespace TestMCV
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private View _player;
        [SerializeField] private View _trigger;

        private Controller _controller;

        private void Awake()
        {
            _controller = new Controller(_player, _trigger);
        }
    }
}
