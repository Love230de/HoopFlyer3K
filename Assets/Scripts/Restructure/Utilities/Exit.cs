using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities;

public class Exit : IState
{
    public void Initiliaze()
    {
       
    }

    public void Update()
    {
        LevelManager.Instance.LoadScene(0);
    }

    void IState.Exit()
    {
       
    }
}
