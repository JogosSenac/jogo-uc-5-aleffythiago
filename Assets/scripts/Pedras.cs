using UnityEngine;
using System.Collections;

public class Pedras : MonoBehaviour
{
    public GameObject Pedra;
    public float time = 1f; // Default time interval

    void OnEnable()
    {
        StartCoroutine(PedraCoroutine());
    }

    void OnDisable()
    {
        StopCoroutine(PedraCoroutine());
    }

    IEnumerator PedraCoroutine()
    {
        while (true)
        {
            Instantiate(Pedra, transform.position, transform.rotation);
            yield return new WaitForSeconds(time);
        }
    }
}


