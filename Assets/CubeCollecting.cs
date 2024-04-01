using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class CubeCollecting : MonoBehaviour
{
  
   // GameManager gameManager;

    private void Start()
    {
      //  gameManager = GameManager.FindAnyObjectByType<GameManager>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(gameObject);
            GameManager.inst.IncrementScore();


        }
    }
}
