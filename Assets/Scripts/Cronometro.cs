using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cronometro : MonoBehaviour
{
    public float tiempo = 0;
    void Update()
    {
        if (tiempo > 0)
        {
            tiempo -= Time.deltaTime;

            if (tiempo <= 0)
            {
                tiempo = 0;
                Debug.Log(gameObject.transform.position.x);
            }
        }
    }
}
