using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlayButtonPressed()
    {
        FindObjectOfType<AudioManager>().Play("Select");

        SceneManager.LoadScene("GameScene");
        Debug.Log("Game Pressed");
    }
}
