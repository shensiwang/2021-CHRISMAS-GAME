using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SubTreeLDataBase : ScriptableObject
{
    public SubTreeL[] subTreeL;

    public int SubTreeLCount
    {
        get
        {
            return subTreeL.Length;
        }
    }

    public SubTreeL GetSubTreeL(int index)
    {
        return subTreeL[index];
    }
}
