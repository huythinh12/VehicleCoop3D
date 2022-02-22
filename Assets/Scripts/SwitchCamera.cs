using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public GameObject viewAll,viewFPerson;
    bool isViewAll =true, isViewFPerson=false;

    // Start is called before the first frame update
    void Start()
    {
        viewAll.SetActive(false);
        viewFPerson.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isViewAll = !isViewAll;
            isViewFPerson = !isViewFPerson;
            viewAll.SetActive(isViewAll);
            viewFPerson.SetActive(isViewFPerson);
        }
    }
}
