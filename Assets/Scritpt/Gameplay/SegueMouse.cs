using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegueMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        var posicao = (Vector2)(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        this.transform.position = posicao;
    }
}
