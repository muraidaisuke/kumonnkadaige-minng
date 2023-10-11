using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLPL : MonoBehaviour
{
    [SerializeField] GameObject PLHB;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 18; i++)
        {
            Instantiate(PLHB, new Vector3(0, 1,-45+(5*i) ), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
