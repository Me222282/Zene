﻿using System.Collections.Generic;

namespace ObjLoader.Data
{
    internal class Group
    {
        private readonly List<Face> _faces = new List<Face>();
        
        public Group(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public IList<Face> Faces { get { return _faces; } }

        public void AddFace(Face face)
        {
            _faces.Add(face);
        }
    }
}