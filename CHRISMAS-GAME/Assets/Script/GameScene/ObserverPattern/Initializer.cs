using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour
{
    public List<IObserver> observersList = new List<IObserver>();

    private void Awake()
    {
        PlayerManager.SetPlayer(this);
        DontDestroyOnLoad(this);
    }

    //=============== OBSERVERS LIST ===============

    //--------------- RegisterObserver -------------
    // subscribers(class):
    //                 -  
    //                 - 
    //                 - 
    //                 - 
    //                 - 
    //                 - 
    //=============== END ==========================

    public void RegisterObserver(IObserver observer)
    {
        if (!observersList.Contains(observer))
        {
            observersList.Add(observer);
        }
    }

    public void UnregisterObserver(IObserver observer)
    {
        observersList.Remove(observer);
    }

    public void NotifyObservers(string aMsg)
    {
        foreach (IObserver observer in observersList)
        {
            observer.Notify(aMsg);
        }
    }

}
