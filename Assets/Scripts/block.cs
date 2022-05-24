using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class block : MonoBehaviour
{
    public bool level = false;

    // Start is called before the first frame update
    void Start()
    {

    }
    
     void OnTriggerEnter(Collider other)
    {
        //Активируем bool level
        Debug.Log("Молодец");
        level = true;
    }
    void OnGUI()
    {
        //Проверяем завершение lv и выводим gui
        if (level == true)
        {
            Debug.Log(level);
            GUI.Label(new Rect(400, 200, 200, 50), "ПЕРВЫЙ УРОВЕНЬ ПРОЙДЕТ!");
            new System.Timers.Timer(10000);
            SceneManager.LoadScene(2);//
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
