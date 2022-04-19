using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectData : MonoBehaviour
{
    [SerializeField]
    public string objectName;

    private void Awake()
    {
        InputHandler.allObjectData.Add(this);
    }


    private void OnDestroy()
    {
        InputHandler.allObjectData.Remove(this);
    }



}
