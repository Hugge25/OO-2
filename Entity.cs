using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct3D9;

namespace OO_2
{
    public abstract class Entity
    {
        protected Texture2D texture;
        protected Vector2 position;
        protected Rectangle hitbox;
        protected Color color;
        public int hp;
    

        public Entity(Texture2D texture, Vector2 startPosition)
        {
            this.texture = texture;
            position = startPosition;
            hitbox = new Rectangle(0,0,25,50);
            color = Color.White;
        }

        public abstract void Update();

        public virtual void Draw(SpriteBatch spriteBatch){
            spriteBatch.Draw(texture, hitbox, color);
        }
    }
}