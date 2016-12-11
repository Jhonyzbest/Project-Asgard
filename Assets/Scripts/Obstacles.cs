using System.Collections;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public Vector2 TimeRange = new Vector2(1.0f, 2.0f);
    public Rigidbody2D Obstacle;

	void Start ()
	{
	    Obstacle = Resources.Load<Rigidbody2D>("Prefabs/Obstacle");
	    StartCoroutine(SpawnObstacle());
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    IEnumerator SpawnObstacle()
    {
        yield return new WaitForSeconds(2.0f);
        while (true)
        {
            Vector2 xPosition = new Vector2(Random.Range(-5.0f, 5.0f), 11.0f);
            Rigidbody2D instObstacle = Instantiate(Obstacle, xPosition, transform.rotation) as Rigidbody2D;
            instObstacle.velocity = transform.TransformDirection(0, -10, 0);
            yield return new WaitForSeconds(Random.Range(TimeRange.x, TimeRange.y));
        }
    }
}
