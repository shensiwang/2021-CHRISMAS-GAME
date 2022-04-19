using System;
using UnityEngine;

[Serializable]
public class InputEntry
{
    public string type;

    public Vector3 position;

    public Vector3 rotation;

    public Vector3 scale;

    public InputEntry(string Type, Vector3 Position, Vector3 Rotation, Vector3 Scale)
    {
        type = Type;
        position = Position;
        rotation = Rotation;
        scale = Scale;
    }

}
