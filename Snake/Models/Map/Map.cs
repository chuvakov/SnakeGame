﻿using Snake.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Models.Map
{
    public class Map : IDrawable
    {
        public string Name { get; private set; }
        public int Height { get; private set; }
        public int Width { get; private set; }
        public List<Figure> Walls { get; private set; }

        private Point _food;
        private readonly FoodGenerator _foodGenerator;        

        public Map(string name, int height, int width, List<Figure> walls)
        {
            Name = name;
            Height = height;
            Width = width;
            Walls = walls;

            _foodGenerator = new FoodGenerator(Height, Width, '*');
        }

        public void Draw()
        {
            foreach (var wall in Walls)
            {
                wall.Draw();
            }
        }

        public void GenerateFood()
        {
            Point point = _foodGenerator.Generate();
            point.Draw();

            _food = point;
        }
    }
}