using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerShipController : MonoBehaviour
    {
        public Rigidbody2D bolt;
        public Transform boltSpawn;
        public float PlayerShipSpeed;
        public float xMin;
        public float xMax;
        public float yMin, yMax;
        public float FireRate;

        private float nextFire;
        public float BoltSpeed;
        
        void Start()
        {
            PlayerShipSpeed = 10f;
            xMin = -5.0f;
            xMax = 5.0f;
            yMin = -9.0f;
            yMax = -9.0f;
            FireRate = 0.25f;
            BoltSpeed = 10.0f;
            boltSpawn = transform.FindChild("BoltSpawn");
            bolt = Resources.Load<Rigidbody2D>("Prefabs/Bolt");
        }

        void Update()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            Vector2 movement = new Vector2(moveHorizontal, 0.0f);
            GetComponent<Rigidbody2D>().velocity = movement*PlayerShipSpeed;
            GetComponent<Rigidbody2D>().position = new Vector3(Mathf.Clamp(GetComponent<Rigidbody2D>().position.x, xMin, xMax), Mathf.Clamp(GetComponent<Rigidbody2D>().position.y, yMin, yMax), 0.0f);
        }

        void FixedUpdate()
        {
            if (Input.GetButton("Fire1") && Time.time > nextFire)
            {
                nextFire = Time.time + FireRate;
                Rigidbody2D instBolt = Instantiate(bolt, boltSpawn.position, boltSpawn.rotation) as Rigidbody2D;
                instBolt.velocity = transform.TransformDirection(new Vector3(0, BoltSpeed, 0));
            }
        }
    }
}