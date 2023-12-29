using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public float NoteSpeed;
    //NoteSpeed = Tempo
    public bool hasStarted;

    void Start()
    {
        NoteSpeed = NoteSpeed / 60f;
    }

    void Update()
    {
        if (!hasStarted)
        {/*
            if(Input.anyKeyDown)
            {
                hasStarted = true;
            }*/

        }
        else
        {
            transform.position -= new Vector3(0f, NoteSpeed * Time.deltaTime, 0f);
        }
    }
}