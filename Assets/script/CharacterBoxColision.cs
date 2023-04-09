using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBoxColision : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.CompareTag("box"))
        {
            Destroy(collision.gameObject);
        }
    }
}
