using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PhotoSpot : MonoBehaviour
{
    public Sprite Photo;


    public bool IsComplete
    {
        get;
        private set;
    }
 
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakePhoto()
    {
        Debug.Log($"Correct photo taken for {name}");
        IsComplete = true;
    }


}
