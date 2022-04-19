using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using System;
using System.IO;



public class InputHandler : MonoBehaviour
{
    public GameObject MainTree  ;
    public GameObject SubTree_L ;
    public GameObject SubTree_RB;
    public GameObject SubTree_RS;


    [SerializeField]
    private string filename;
    private        List<InputEntry> entries       = new List<InputEntry>();
    public  static List<ObjectData> allObjectData = new List<ObjectData>();

    private void Start()
    {
        entries = FileHandler.ReadFromJSON<InputEntry>(filename);

        if (entries.Count != 0)
        {
            allObjectData = GameObject.FindObjectsOfType<ObjectData>().ToList<ObjectData>();
        }
        else { }

    }

    //----------Load()----------
    public void LoadData()
    {
        if (entries.Count == 0)
        {
            for (int i = 0; i < allObjectData.Count; i++)
            {
                entries.Add(new InputEntry(allObjectData[i].objectName, allObjectData[i].transform.position, allObjectData[i].transform.eulerAngles, allObjectData[i].transform.localScale));
            }
        }


        foreach (ObjectData objectData in allObjectData.ToArray())
        {
            Destroy(objectData.gameObject);

            if (objectData.objectName == "MainTree")
            {
                allObjectData.Remove(objectData);
            }

            if (objectData.objectName == "SubTree_L")
            {
                allObjectData.Remove(objectData);
            }

            if (objectData.objectName == "SubTree_RB")
            {
                allObjectData.Remove(objectData);
            }

            if (objectData.objectName == "SubTree_RS")
            {
                allObjectData.Remove(objectData);
            }

        }


        for (int i = 0; i < entries.Count; i++)
        {
            if (entries[i].type == "MainTree")
            {

                Instantiate(MainTree, entries[i].position, Quaternion.identity);
            }

            if (entries[i].type == "SubTree_L")
            {
                Instantiate(SubTree_L, entries[i].position, Quaternion.identity);
            }

            if (entries[i].type == "SubTree_RB")
            {
                Instantiate(SubTree_RB, entries[i].position, Quaternion.identity);
            }

            if (entries[i].type == "SubTree_RS")
            {
                Instantiate(SubTree_RS, entries[i].position, Quaternion.identity);
            }
        }

    }

    //----------Save()----------
    public void AddPosDataToList()
    {

        entries = new List<InputEntry>();

        for (int i = 0; i < allObjectData.Count; i++)
        {

            entries.Add(new InputEntry(allObjectData[i].objectName, allObjectData[i].transform.position, allObjectData[i].transform.eulerAngles, allObjectData[i].transform.localScale));

        }

        FileHandler.SaveToJSON<InputEntry>(entries, filename);

    }
}
