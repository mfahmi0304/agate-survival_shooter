using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public Text warningText;
    public PlayerHealth playerHealth;
    
    public bool isDead = false;

    Animator anim;
    
    float restartTimer = 0.0f;
    float restartDelay = 5.0f;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }
 
    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            if(!isDead){
                Debug.Log("Game Over");
                anim.SetTrigger("GameOver");
                isDead = true;
            }

            restartTimer += Time.deltaTime;

            if(restartTimer >= restartDelay){
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
 
    public void ShowWarning(float enemyDistance)
    {
        warningText.text = string.Format("! {0} m",Mathf.RoundToInt(enemyDistance));
        anim.SetTrigger("Warning");
    }
}