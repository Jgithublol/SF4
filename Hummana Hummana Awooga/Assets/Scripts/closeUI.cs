using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeUI : MonoBehaviour
{
    public GameObject Canvas;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void whenButtonClicked()
    {
        if (Canvas.activeInHierarchy == true)
            Canvas.SetActive(false);
        else
            Canvas.SetActive(true);


    }


}
