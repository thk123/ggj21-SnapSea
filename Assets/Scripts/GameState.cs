using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public List<PhotoSpot> AllPhotos;

    private PhotoSpot NextPhoto;
    private Queue<PhotoSpot> RemainingPhotos;

    public UIController UIController;

    // Start is called before the first frame update
    void Start()
    {
        if (AllPhotos.Count == 0)
        {
            Debug.LogError("No photos configured for this scene");
        }

        // Disable all photo spots except for the next one
        foreach(var photoSpot in AllPhotos)
        {
            photoSpot.gameObject.SetActive(false);
        }

        RemainingPhotos = new Queue<PhotoSpot>(AllPhotos);
        ActivateNextPhoto();
    }

    private void ActivateNextPhoto()
    {
        NextPhoto = RemainingPhotos.Dequeue();
        NextPhoto.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(NextPhoto != null && NextPhoto.IsComplete)
        {
            UIController.ShowTakenPhoto(NextPhoto);
            if (RemainingPhotos.Count > 0)
            {
                ActivateNextPhoto();
            }
            else
            {
                Debug.Log("All photos complete");
                NextPhoto = null;
            }
        }
    }

    
}
