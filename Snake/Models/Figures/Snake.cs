﻿using SnakeApp.Enams;
using SnakeApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeApp.Models.Figures
{
    //TODO: везде в методах добавить комменты (///); запрограммировать метод MOVE (без циклов);
    public class Snake : Figure
    {
        private IPoint _head;
        private IPoint _tail;

        private MoveDirection _direction;

        public Snake(IPoint tail, int length, MoveDirection direction)
        {
            _tail = tail;
            _direction = direction;

            Init(length);
        }

        private void Init(int length)
        {
            _points.Add(_tail);

            for (int i = 1; i < length; i++)
            {
                IPoint point = (IPoint)_points.Last().Clone();
                point.Move(_direction, 1);
                _points.Add(point);
            }
        }

        private void Move()
        {

        }
    }
}