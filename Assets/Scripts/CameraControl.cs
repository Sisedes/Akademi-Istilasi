using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    
        [SerializeField] Transform playerTransform;
        [SerializeField] float minX, maxX; 
        [SerializeField] float minY, maxY;
    private void Update()
        {
            transform.position = new Vector3(Mathf.Clamp(playerTransform.position.x, minX, maxX), Mathf.Clamp(playerTransform.position.y, minY, maxY), transform.position.z);
    }
}
