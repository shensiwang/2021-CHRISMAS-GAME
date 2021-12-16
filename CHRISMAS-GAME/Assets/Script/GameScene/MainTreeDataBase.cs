using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MainTreeDataBase : ScriptableObject
{
    public MainTree[] mainTree;//create an array, to store the maintree - properties

    public int MainTreeCount //define - property, the length the array. 
    {
        get 
        {
            return mainTree.Length;
        }
    }

    public MainTree GetMainTree(int index)
    {
        return mainTree[index]; //return a index, the sequence in an array
    }


}
