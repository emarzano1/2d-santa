using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class CameraControlloer : MonoBehaviour
{
    [SerializeField] private Transform Personaggio;

    [SerializeField ]private bool seguiAsseX = false;

    [SerializeField] private float maxY;
    [SerializeField] private float minY;



    private void Update()
    {
        float posX = seguiAsseX ? Personaggio.position.x : transform.position.x;
        float posY;

        if (seguiAsseX)
        {
            posY = transform.position.y;
        }
        else
        {
            posY = Mathf.Clamp(Personaggio.position.y, minY, maxY);
        }

        transform.position = new Vector3(posX, posY, transform.position.z);
    }
}



