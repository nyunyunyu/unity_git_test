using UnityEngine;
using System.Collections;

public class translate : MonoBehaviour {

    [SerializeField]
    float velocity = 5.0f;

    Transform myTransform;

    // Use this for initialization
    void Start()    {
        myTransform = transform;
    }

    // Update is called once per frame
    void Update()    {
        myTransform.Translate(0, velocity * Time.deltaTime, 0);
    }
}
