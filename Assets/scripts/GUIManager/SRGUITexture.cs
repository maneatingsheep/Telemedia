using UnityEngine;

public class SRGUITexture : SRBaseGUIElement {

    private Texture _Texture = null;
    
    public void SetTexture(Texture texture) {
        _Texture = texture;
        if (texture) {
            _Size = new Vector2(texture.width, texture.height);
        }
    }

    public void SetTexture(Texture texture, Vector2 size, bool fitToSize = false) {
        _Texture = texture;
        if (fitToSize) {
            float minRat = Mathf.Min(size.x / texture.width, size.y / texture.height);
            _Size = new Vector2(texture.width * minRat, texture.height * minRat); 
        } else {
            _Size = size;
        }
        
    }
    
    public void SetcustomSize(Vector2 size) {
        _Size = size;
    }

    public Texture Texture {
        get {
            return _Texture;
        }
    }
}
