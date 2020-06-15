using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AllienTrigger : MonoBehaviour
{
    [SerializeField] private Animator alienAnimation;
    [SerializeField] private Canvas alienMsg;
    // Start is called before the first frame update
    void Start()
    {
        alienMsg.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            alienAnimation.SetTrigger("StartHello");
            //alienMsg.gameObject.SetActive(true);
        }
    }

    public void StartHello()
    {
        alienMsg.gameObject.SetActive(true);
    }
    public void EndHello()
    {
        alienMsg.gameObject.SetActive(false);
    }
}
