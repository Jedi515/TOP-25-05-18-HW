using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Reload()
    {
        //Debug.Log("Reloading game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
