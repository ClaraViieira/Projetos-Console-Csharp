﻿using System;
using System.Collections.Generic;
using ConsoleMetodosEClassesAbstratas.Entities;
using ConsoleMetodosEClassesAbstratas.Entities.Enums;

namespace ConsoleMetodosEClassesAbstratas.Entities {
    class Circle : Shape {
        public double Radius { get; set; }
        public Circle(double radius, Color color) :base(color){
            Radius = radius;
        }
        public override double Area() {
            return Math.PI * Radius * Radius;
        }
    }
}
