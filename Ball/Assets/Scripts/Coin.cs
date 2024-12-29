using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] float speed = 7f;
    public ParticleSystem coinParticle;
    public GameObject coinObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * speed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            coinObject.SetActive(false);
            coinParticle.Play();
            FindObjectOfType<Bank>().AddCoin(1);
            Destroy(gameObject,3);
        }
    } 
}
