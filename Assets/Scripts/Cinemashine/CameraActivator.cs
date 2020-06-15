using System.Collections;
using Cinemachine;
using UnityEngine;

public class CameraActivator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private CinemachineVirtualCamera camera;
    private int lowVal = 9;
    private int highVal = 13;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            camera.Priority = highVal;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            camera.Priority = lowVal;
        }
    }


}
