using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities;

public class TestLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            LevelManager.Instance.LoadScene(2);
        }
        if(Input.GetKey(KeyCode.Escape))
        {
            GameStateManager.Instance.Pause();
          
        }
    }
}
