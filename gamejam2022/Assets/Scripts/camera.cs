using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moverCamX = 0.003F;

        Camera.main.transform.Translate(moverCamX, 0, 0);
        
    }
}
