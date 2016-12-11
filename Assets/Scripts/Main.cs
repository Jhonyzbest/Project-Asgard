using Assets.Scripts;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject Player;
    public GameObject Backgorund;

	// Use this for initialization
    void Start()
    {
        Player = Instantiate(Resources.Load<GameObject>("Prefabs/PlayerShip"));
        Backgorund = Instantiate(Resources.Load<GameObject>("Prefabs/Background"));
        gameObject.AddComponent<Obstacles>();
    }
	
	// Update is called once per frame
	void Update () 
    {

	}
}
