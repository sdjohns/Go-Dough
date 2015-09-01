using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using System.IO;
using Microsoft.Xna.Framework.Input;


namespace Game1.Game
{
    class Level : IDisposable
    {

        Texture2D[] layers;
        Tile[,] tiles;
        //ContentManager Content;
        SpriteBatch spriteBatch;
        Rectangle screenRect;

        const int playerLayer = 1;
        Player player;

        public Level (ContentManager content, SpriteBatch i_spriteBatch, int levelIndex, Rectangle i_screenRect)
        {
            // Load tiles for the level

            layers = new Texture2D[4];

            spriteBatch = i_spriteBatch;
            screenRect = i_screenRect;

            for (int i = 0; i < playerLayer; ++i)
            {
                layers[i] = content.Load<Texture2D>("Graphics\\background-0" + (i+1));
            }

            //layers[0] = content.Load<Texture2D>("Graphics\\background-01");

        }

        public void Update (GameTime gameTime, KeyboardState keyboardState)
        {

        }

        public void Draw()
        {
            for (int i = 0; i < playerLayer; ++i)
            {
                spriteBatch.Draw(layers[0],                      // PLayer Texture
                                 screenRect,                           // Position of the texture
                                 null,                               // Source Rectangle ??
                                 Color.White                    // Color applied onto the image
                                 );

            }

           



        }

        public void Dispose()
        {

        }


    }
}
