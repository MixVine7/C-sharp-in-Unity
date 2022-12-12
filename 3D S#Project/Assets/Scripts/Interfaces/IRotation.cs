using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Maze;

namespace Maze // Оборачиваем в namespace, что бы не было конфликтов с отдельными сборками.
{
    public interface IRotation // Контракт кода - чек лист.
    {
        void Rotate();
    }
}

