using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Platformer
{
    public class Finish : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
                if(other.gameObject.name == "Player")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
