using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject deathScreen;

    private bool onDeathScreen = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Death()
    {
        // Makes the camera not move anymore
        Camera.main.transform.parent.GetComponent<CameraMoveScript>().beginMovement = false;
        // Destroys cat
        Destroy(GameObject.FindGameObjectWithTag("Player"));

        deathScreen.SetActive(true);

        onDeathScreen = true;
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void PauseGame()
    {
        if (!onDeathScreen)
        {

        }
    }

    private void SwitchTime()
    {

    }
}
