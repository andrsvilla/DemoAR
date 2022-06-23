using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
  public GameObject bullet;
  public Transform SpawnPoint;

  public float ShotForce;
  public float ShotRate;

  private float ShotRateTime = 0;

  // Start is called before the first frame update
  void Start() {
    
  }

  // Update is called once per frame
  void Update() {

  }

  public void Disparar() {
    if (Time.time > ShotRateTime) {
      GameObject newBullet;
      newBullet = Instantiate(bullet, SpawnPoint.position, SpawnPoint.rotation);
      newBullet.GetComponent<Rigidbody>().AddForce(SpawnPoint.forward*ShotForce);
      ShotRateTime = Time.time + ShotRate;
      Destroy(newBullet, 2);
    }
  }
}
