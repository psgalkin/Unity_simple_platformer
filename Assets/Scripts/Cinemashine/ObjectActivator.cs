using System.Collections;
using UnityEngine;
using Cinemachine;

[ExecuteAlways]
public sealed class ObjectActivator : MonoBehaviour
{
    [SerializeField] private TagType activatorTag;
    [SerializeField] private bool deactivateOnExit;
    [SerializeField] private GameObject[] objects;
    public CinemachineVirtualCamera vc;

    private void OnTriggerEnter2D(Collider2D p_collision)
    {
        if (p_collision.CompareTag(TagManager.GetTag(activatorTag)))
        {
            for (int i = 0; i < objects.Length; ++i)
            {
                GameObject obj = objects[i];
                vc.Priority = 12;
                obj.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D p_collision)
    {
        if (deactivateOnExit && p_collision.CompareTag(TagManager.GetTag(activatorTag)))
        {
            
            for (int i = 0; i < objects.Length; ++i)
            {
                GameObject obj = objects[i];
                vc.Priority = 10;
                //obj.SetActive(false);
            }
        }
    }

}
