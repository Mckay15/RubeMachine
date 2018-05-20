using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cart_backwards : MonoBehaviour {

    private float timeTakenDuringLerp = 1.0f;
    private Vector3 start;
    private Vector3 End;
    public float journeyLength = 3;
    private float Place = 0.0f;
    private bool IsLerping;


    void Lerping()
    {
        IsLerping = true;
        Place = Time.time;
        start = transform.position;
        End = transform.position + Vector3.back * journeyLength;
    }

    void FixedUpdate()
    {
        if (IsLerping)
        {
            float timeSinceStared = Time.time - Place;
            float percentageComplate = timeSinceStared / timeTakenDuringLerp;
            transform.position = Vector3.Lerp(start, End, percentageComplate);
            if (percentageComplate >= 1.0f)
            {
                IsLerping = false;
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Lerping();
        }
    }
}
