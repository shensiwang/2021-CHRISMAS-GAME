using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubTreeLObserver : MonoBehaviour, IObserver
{
    public GameObject subtreel_0;
    public GameObject subtreel_1;
    public GameObject subtreel_2;
    public GameObject subtreel_3;


    private void Start()
    {
        PlayerManager.m_player.RegisterObserver(this);
        PlayerManager.m_player.NotifyObservers("SubTreeL_-1");
    }

    public void Notify(string aMsg)
    {
        Debug.Log("SubTreeL_" + aMsg);
        switch (aMsg)
        {
            case "SubTreeL_-1":
                // DEFAULT SETTING
                subtreel_0.SetActive(false);
                subtreel_1.SetActive(false);
                subtreel_2.SetActive(false);
                subtreel_3.SetActive(false);
                break;

            case "SubTreeL_0":
                subtreel_0.SetActive(true);
                subtreel_1.SetActive(false);
                subtreel_2.SetActive(false);
                subtreel_3.SetActive(false);
                break;

            case "SubTreeL_1":
                subtreel_0.SetActive(false);
                subtreel_1.SetActive(true);
                subtreel_2.SetActive(false);
                subtreel_3.SetActive(false);
                break;

            case "SubTreeL_2":
                subtreel_0.SetActive(false);
                subtreel_1.SetActive(false);
                subtreel_2.SetActive(true);
                subtreel_3.SetActive(false);
                break;

            case "SubTreeL_3":
                subtreel_0.SetActive(false);
                subtreel_1.SetActive(false);
                subtreel_2.SetActive(false);
                subtreel_3.SetActive(true);
                break;
        }
    }
}
