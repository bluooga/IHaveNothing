using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{

    public GameObject pretoex;
    public GameObject HerDeathMessage;
    public GameObject mywords;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        if (other.gameObject.CompareTag("Grave"))
        {
            pretoex.SetActive(true);

            
        }



        Debug.Log(other.gameObject.name);
        Debug.Log(other.gameObject.tag);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Grave"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                pretoex.SetActive(false);
                HerDeathMessage.SetActive(true);
                StartCoroutine(herdeath());
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        pretoex.SetActive(false);
    }

    public IEnumerator herdeath()
    {
        yield return new WaitForSeconds(5f);

        HerDeathMessage.SetActive(false);

        mywords.SetActive(true);
    }



}
