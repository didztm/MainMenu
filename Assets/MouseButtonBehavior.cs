using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseButtonBehavior : MonoBehaviour

{
    #region Public Members

    #endregion
    public Sprite m_hooverSprite;
    public Sprite m_outSprite;
    #region Public void

    #endregion

    #region System

    void Start ()
    {
        m_image = GetComponent<Button>().GetComponent<Image>();
    }

    void Update ()
    {
        	
    }

    #endregion

    #region Tools Debug and Utility

    public void OnHooverButton() {
        m_image.sprite = m_hooverSprite;
    }
    public void OutButton()
    {

        m_image.sprite = m_outSprite;
    }
    #endregion

    #region Private and Protected Members

    #endregion
    private Image m_image;
    
}
