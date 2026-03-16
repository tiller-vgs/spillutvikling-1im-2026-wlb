using UnityEngine;

namespace topdown.shooting
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Projectile1 : MonoBehaviour
    {
        [Header("Movement Stats")]
        [SerializeField] private float speed;
        [SerializeField] private float lifeTime;
        private Rigidbody2D body;
        private float lifeTimer;

        private void Awake()
        {
            body = GetComponent<Rigidbody2D>();
        }

        public void ShootBullet(Transform shootPoint)
        {
            lifeTimer = 0;
            body.linearVelocity = Vector2.zero;

            transform.position = shootPoint.position;
            transform.rotation = shootPoint.rotation;

            body.AddForce(-transform.up * speed, ForceMode2D.Impulse);

            gameObject.SetActive(true);
        }

        private void Update()
        {
            lifeTimer += Time.deltaTime;

            if (lifeTimer >= lifeTime)
                gameObject.SetActive(false);
        }
    }
}