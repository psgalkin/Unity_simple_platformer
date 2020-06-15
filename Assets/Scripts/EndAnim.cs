using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndAnim : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private AllienTrigger trigger;

    void StartHello()
    {
        trigger.StartHello();
    }

    void EndHello()
    {
        trigger.EndHello();
    }
}
