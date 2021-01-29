using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Image PhotoTakenImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowTakenPhoto(PhotoSpot photoTaken)
    {
        StartCoroutine(DisplayPhoto(photoTaken));
    }

    public IEnumerator DisplayPhoto(PhotoSpot photoTaken)
    {
        PhotoTakenImage.sprite = photoTaken.Photo;
        PhotoTakenImage.enabled = true;
        yield return new WaitForSeconds(1.0f);
        PhotoTakenImage.enabled = false;
    }
}
