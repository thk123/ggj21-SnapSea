using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class PlayerController : MonoBehaviour
{
    public float MovementSpeed = 10.0f;

    public KeyCode TakePhoto = KeyCode.Space;

    public Collider2D Collider;

    public AudioSource TakePhotoAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        Collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movementVector = Vector3.zero;
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            movementVector.x -= MovementSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movementVector.x += MovementSpeed;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            movementVector.y += MovementSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movementVector.y -= MovementSpeed;
        }

        movementVector *= Time.deltaTime;

        transform.Translate(movementVector);

        if(Input.GetKeyDown(TakePhoto))
        {
            TakePhotoAudioSource?.Play();
            var contactFilter = new ContactFilter2D();
            List<Collider2D> overlappingColliders = new List<Collider2D>();
            var foundColliders = Collider.OverlapCollider(contactFilter, overlappingColliders);
            foreach(var collider in overlappingColliders)
            {
                collider.GetComponent<PhotoSpot>()?.TakePhoto();
                break;
            }
        }
    }
}
