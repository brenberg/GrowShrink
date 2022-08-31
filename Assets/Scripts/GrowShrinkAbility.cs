using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowShrinkAbility : MonoBehaviour
{
    float GrowSpeed;
    public float CustomSpeed;
    public float MaxSize;
    public float MinSize;
    bool grow;
    bool shrink;
    // Start is called before the first frame update
    void Start()
    {
        grow = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(GrowSpeed, GrowSpeed, 0f) * Time.deltaTime;
        if (transform.localScale.x >= MaxSize && shrink)
        {
            GrowSpeed = 0;
        }
        if (transform.localScale.x <= MinSize && grow)
        {
            GrowSpeed = 0;
        }
        if (grow == true && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Grow");  
  
            if (transform.localScale.x < MaxSize)
            {
                GrowSpeed = CustomSpeed;
            }
            shrink = true;
            grow = false;
        }
        else if (shrink == true && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Shrink");
            GrowSpeed = -CustomSpeed;
            grow = true;
            shrink = false;
        }
    }
}
