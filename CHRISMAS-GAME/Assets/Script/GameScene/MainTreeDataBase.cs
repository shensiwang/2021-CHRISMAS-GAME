using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MainTreeDataBase : ScriptableObject
{
    public MainTree[] mainTree;

    public int MainTreeCount
    {
        get 
        {
            return mainTree.Length;
        }
    }

    public MainTree GetMainTree(int index)
    {
        return mainTree[index];
    }


}
