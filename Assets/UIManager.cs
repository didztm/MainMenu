using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class UIManager : MonoBehaviour
{
    #region Public Members

    #endregion
    public GameObject m_buttonContinue;
    public GameObject m_buttonLoagGame;
    public GameObject m_buttonNewgame;
    public AudioSource m_hoverSound;
    public GameObject m_panelAreYouSure;
    
    #region Public void

    #endregion
    public void ToggleCampaign(bool _status) {
        m_buttonContinue.SetActive(_status);
        m_buttonLoagGame.SetActive(_status);
        m_buttonNewgame.SetActive(_status);
    }
    public void SettingsMenu()
    {
        m_animator.SetBool("boolSettings", true);
        m_animator.SetBool("boolMain", false);
    }
    public void MainMenu()
    {
        m_animator.SetBool("boolSettings", false);
        m_animator.SetBool("boolMain", true);
    }
    public void ToogleAreYouSure(bool _status)
    {
        //m_panelAreYouSure.SetActive(_status);
    }
    public void Play()
    {
        m_hoverSound.Play();
    }
    #region System
 
    private void Awake()
    {
        m_animator = GetComponent<Animator>();
    }
    void Start ()
    {
        
    }

    void Update ()
    {
        	
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members
    private Animator m_animator;
    #endregion
}
