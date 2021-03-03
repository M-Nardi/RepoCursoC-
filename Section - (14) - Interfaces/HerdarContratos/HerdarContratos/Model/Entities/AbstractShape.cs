using System;
using System.Collections.Generic;
using System.Text;
using HerdarContratos.Model.Entities;
using HerdarContratos.Model.Enums;


namespace HerdarContratos.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
