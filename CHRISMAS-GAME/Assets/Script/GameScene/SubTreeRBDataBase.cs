using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SubTreeRBDataBase : ScriptableObject
{
    public SubTreeRB[] subTreeRB;

    public int SubTreeRBCount
    {
        get
        {
            return subTreeRB.Length;
        }
    }

    public SubTreeRB GetSubTreeRB(int index)
    {
        return subTreeRB[index];
    }
}
