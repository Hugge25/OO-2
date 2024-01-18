using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace OO_2
{
    public class Enemy : Entity
    {
        
        public Enemy(Texture2D texture, Vector2 startPosition) : base(texture, startPosition)
        {
            
        }

        public override void Update()
        {
            hitbox.Location = position.ToPoint();
        }
    }
}