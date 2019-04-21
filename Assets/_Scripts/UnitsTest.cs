using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitsTest : MonoBehaviour
{
    public Transform _objectToTest;
   // public Transform _secondObject;

    [ContextMenu("do")]
    public void DoRandomTest()
    {

    }

    private void Start()
    {
        DoRandomTest();
    }
}
