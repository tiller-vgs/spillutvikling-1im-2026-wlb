using UnityEngine;

namespace topdown.shooting
{
    public class GunControl : MonoBehaviour
    {
        
        [Header("Cooldown")]
        [SerializeField] private float cooldown = 0.25f;
        private float cooldownTimer;

        //Bullet prefab 
        [Header("References")]
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private Transform firePoint;
        [SerializeField] private Animator muzzleFlashAnimator;
        //Shooting point

    

        private void Update()
        {
            cooldownTimer += Time.deltaTime;
        }

        private void Shoot()
        {
            if (cooldownTimer < cooldown) return;
            Debug.Log("Shooting  ...");
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation, null);
            var rbBullet = bullet.GetComponent<Rigidbody2D>();
            rbBullet.AddForce(firePoint.up * 30, ForceMode2D.Impulse);

            muzzleFlashAnimator.SetTrigger("Shoot");
            cooldownTimer = 0;
        }

        #region Input
        private void OnShoot()
        {
            Shoot();
        }
        #endregion
    }
    
}

