using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VagonSabitleyici : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = new Vector3(transform.position.x, 0.8f, transform.position.z);
    }
}
