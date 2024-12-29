using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleCoin : MonoBehaviour
{
    [SerializeField] float speed = 7f;
    public ParticleSystem doubleCoinParticle;
    public GameObject doubleCoinObject;
    public int numberOfCoin;
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
            doubleCoinObject.SetActive(false);
            doubleCoinParticle.Play();
            FindObjectOfType<Bank>().AddCoin(numberOfCoin);
            Destroy(gameObject, 3);
        }
    }
}
