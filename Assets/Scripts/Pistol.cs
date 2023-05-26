using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Pistol : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform spawnPoint;

    public float fireSpeed;

    private void Start()
    {
        XRGrabInteractable xRGrabInteractable = GetComponent<XRGrabInteractable>();
        xRGrabInteractable.activated.AddListener(FireBullet);
    }

    private void FireBullet(ActivateEventArgs activateEventArgs)
    {
        GameObject bullet = Instantiate(bulletPrefab);
        bullet.transform.position = spawnPoint.position;
        bullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;
        Destroy(bullet, 5);
    }
}
