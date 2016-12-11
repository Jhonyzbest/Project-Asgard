using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
