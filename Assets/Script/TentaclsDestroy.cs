using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentaclsDestroy : MonoBehaviour
{
    [SerializeField] float DestroyTime = 3.0f;
    void Start()
    {
        //StartCoroutine("DestroyTentacl");
    }

    IEnumerator DestroyTentacl()
    {
        yield return new WaitForSeconds(DestroyTime);

        Destroy(this.gameObject);

    }
}
