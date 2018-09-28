using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MEnuManager : MonoBehaviour {

	void On_Clic_Play ()
    {
        SceneManager.LoadScene("Accueil_Network");
    }
}
