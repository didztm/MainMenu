using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class SpriteImport : AssetPostprocessor
{
    #region Public Members

    #endregion

    #region Public void

    #endregion

    #region System

    void OnPreprocessTexture() {
        // Debug.Log("toto");
        string name = "SPR_" + Path.GetFileNameWithoutExtension(assetPath);
        TextureImporter textureImporter = (TextureImporter)assetImporter;
        textureImporter.textureType = TextureImporterType.Sprite;
        textureImporter.spriteImportMode = SpriteImportMode.Multiple;
        textureImporter.filterMode = FilterMode.Point;
        textureImporter.name = name;
        Debug.Log("ici++++" + textureImporter.name);
    }//ici on clique sur apply
    void OnPostprocessTexture(Texture2D _texture) {
        
        Debug.Log("ici****"+ _texture.name);
       // if (_texture.name == "SPR_Start")
       // {
            CutSprite(_texture, 4,1);
       // }

    }
    
    private void CutSprite(Texture2D _texture,int colCount,int rowCount)
    {
        //On veut diviser en plusieur partie la spriteSheet
        Debug.Log("Texture2d" + _texture.width + "---" + _texture.height);
        // spriteSize = 10;
        int colSize = (_texture.width / colCount);
        int rowSize = (_texture.height / rowCount) ;
        List<SpriteMetaData> metas = new List<SpriteMetaData>();
        
        if(colCount==1 ){


        }
        for (int r = 0; r < rowCount; r++)
        {
            for (int c = 0; c < colCount; c++)
            {
                Debug.Log(c* colSize + "<----->"+ r * rowSize  +" c="+c + " r=" + r);
                SpriteMetaData meta = new SpriteMetaData();
                meta.rect = new Rect(c*colSize, r*rowSize, colSize,rowSize);
                meta.name = c + " - " + r;
                metas.Add(meta);
            }
        }
        //ImageConversion.EncodeToPNG();
        TextureImporter textureImporter = (TextureImporter)assetImporter;
        textureImporter.spritesheet = metas.ToArray();

    }
    private void RecompileSprite() {

        

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

    #endregion
}
