using System.Collections;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour {
    private Score score;
	// Use this for initialization
	void Start () {
        score = GameObject.Find("Main Camera").GetComponent<Score>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Obstacle" || other.tag == "Player")
        {
            return;
        }
        Destroy(other.gameObject);
        Destroy(gameObject);
    }

    void OnDestroy()
    {
        score.UpdateScore();        
    }
}
