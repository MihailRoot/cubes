using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hp : MonoBehaviour

{
    public Image bar;
    public float fill = 1f;

    public float xp = 0.0001f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        fill -= Time.deltaTime *  xp;
        bar.fillAmount = fill;
         if (fill < 0)
         {
            Debug.Log("Вы програли!");
            Application.Quit();
         }
    }
}
