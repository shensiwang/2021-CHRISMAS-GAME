using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SubTreeRSDataBase : ScriptableObject
{
    public SubTreeRS[] subTreeRS;

    public int SubTreeRSCount
    {
        get
        {
            return subTreeRS.Length;
        }
    }

    public SubTreeRS GetSubTreeRS(int index)
    {
        return subTreeRS[index];
    }
}
