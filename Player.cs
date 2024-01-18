using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace OO_2
{
    public class Player : Entity
    {
        public Player(Texture2D texture, Vector2 startPosition) : base(texture, startPosition)
        {
            
        }
        
        
        public override void Update()
        {
            hitbox.Location = position.ToPoint();
            Move();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }

        private void Move(){
            KeyboardState kState = Keyboard.GetState();
            if(kState.IsKeyDown(Keys.W))
            {
                position.Y--;
            }
            if(kState.IsKeyDown(Keys.S))
            {
                position.Y++;
            }
            if(kState.IsKeyDown(Keys.A))
            {
                position.X--;
            }
            if(kState.IsKeyDown(Keys.D))
            {
                position.X++;
            }
        }
    }
}