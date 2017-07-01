using UnityEngine;
using System.Collections;

public class obsDestroyer : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
