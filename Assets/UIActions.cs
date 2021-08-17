using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIActions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NameSetter(string pName)
    {
        NameScript.Instance.pName = pName;
    }

    public void NextScene()
    {
        SceneManager.LoadScene(1);
    }
}
