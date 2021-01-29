using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Image PhotoTakenImageUIElement;
    public Image NextPhotoUIElement;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Assert(PhotoTakenImageUIElement != null, "No photo taken image set on the UI");
        Debug.Assert(NextPhotoUIElement != null, "No next photo taken set on the UI");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowTakenPhoto(PhotoSpot photoTaken)
    {
        StartCoroutine(DisplayPhoto(photoTaken));
    }

    public void ShowNextPhoto(PhotoSpot nextPhoto)
    {
        NextPhotoUIElement.sprite = nextPhoto.Photo;
    }

    public IEnumerator DisplayPhoto(PhotoSpot photoTaken)
    {
        PhotoTakenImageUIElement.sprite = photoTaken.Photo;
        PhotoTakenImageUIElement.enabled = true;
        yield return new WaitForSeconds(1.0f);
        PhotoTakenImageUIElement.enabled = false;
    }
}
