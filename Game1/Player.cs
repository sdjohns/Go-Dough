using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class Player
    {

        public Texture2D PlayerTexture;

        public Vector2 Position;

        public Rectangle Rectangle;

        public bool Active;

        public int Health;

        public int Width
        {
            get { return PlayerTexture.Width; }
        }

        public int Height
        {
            get { return PlayerTexture.Height; }
        }

        public void Initialize(Texture2D texture, Vector2 position, Rectangle winRect)
        {
            PlayerTexture = texture;

            Rectangle = winRect;
                 
            Position = position;

            Active = true;

            Health = 100;
        
        }

        public void Update(Vector2 position)
        {
            Position = position;
        }


        public void Draw(SpriteBatch spriteBatch)
        {

            /*
            
            spriteBatch.Draw(   PlayerTexture,                      // PLayer Texture
                                Position,                           // Position of the texture
                                null,                               // Source Rectangle ??
                                Color.LightBlue,                    // Color applied onto the image
                                0f,                                 // Rotation
                                Vector2.One,                        // Origin -- origin of the texture about which operations such as rotation are carried out.
                                0f,                                 // scale
                                SpriteEffects.None,                 // flipping the image vertically/horizontally
                                1f);                                // Depth to determine which comes on top

            */

            spriteBatch.Draw(   PlayerTexture,
                                Rectangle,
                                null,
                                Color.White,
                                0f,
                                Vector2.Zero,
                                SpriteEffects.None,
                                0f
                            );
        }

    }
}
