using UnityEngine;
using System.Collections;

public class BackgroundScroll : MonoBehaviour
{
    public float Speed = 0;
    public static BackgroundScroll current;

    private float pos = 0;

	// Use this for initialization
	void Start ()
	{
	    current = this;
	}
	
	// Update is called once per frame
    void Update ()
	{
	    pos += Speed;
	    if (pos > 1.0f)
	        pos -= 1.0f;

        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, pos);
	}
}
