using UnityEngine;

public class SRGUITexture : SRBaseGUIElement {

    private Texture2D _Texture = null;
    public bool hasCoords = false;
    public Rect Coords;
    public Vector2 Offset;

    public void SetTexture(Texture texture) {
        hasCoords = false;
        _Texture = texture as Texture2D;
        if (texture) {
            _Size = new Vector2(texture.width, texture.height);
        }
    }

    public void SetTexture(Sprite sprite) {
        hasCoords = true;
        _Texture = sprite.texture;
        //Coords = sprite.textureRect;
        Coords = new Rect(0f, 0f, 1f, 1f);
        _Size = new Vector2(sprite.rect.width, sprite.rect.height);
        Offset = new Vector2(sprite.textureRectOffset.x, sprite.textureRectOffset.y) * sprite.pixelsPerUnit;
    }

    public void SetTexture() {
        _Texture = null;
    }

    public void SetTexture(Texture texture, Vector2 size, bool fitToSize = false) {
        hasCoords = false;
        _Texture = texture as Texture2D;
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
