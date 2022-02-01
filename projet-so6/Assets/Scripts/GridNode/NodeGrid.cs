using System;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public class NodeGrid
{
     public bool Walkable;
     public Vector3 NodePosition;

     public int XIndex;
     public int YIndex;

     //for AStar
     public int GCost { get; set; } //Dijkstra will use this
     public int HCost { get; set; }
     public int FCost => GCost + HCost;

     public NodeGrid parentNodeGrid;

     public NodeGrid(bool walkable, Vector3 nodePosition, int X, int Y)
     {
          Walkable = walkable;
          NodePosition = nodePosition;
          XIndex = X;
          YIndex = Y;
     }
}
