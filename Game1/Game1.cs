using Game1.Game;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Level level1;
        Vector2 playerPos;
        Rectangle screenRect;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            //player1 = new Player();

            //player2 = new Player();


            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            screenRect = new Rectangle(0, 0, GraphicsDevice.Viewport.TitleSafeArea.Width, GraphicsDevice.Viewport.TitleSafeArea.Height);

            level1 = new Level(Content, spriteBatch, 1, screenRect);


            playerPos = new Vector2(GraphicsDevice.Viewport.TitleSafeArea.X, GraphicsDevice.Viewport.TitleSafeArea.Y /*+ GraphicsDevice.Viewport.TitleSafeArea.Height / 2*/);



            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            


            // TODO: use this.Content to load your game content here

             

            //player1.Initialize(Content.Load<Texture2D>("Graphics\\sky"),playerPos, GraphicsDevice.Viewport.Bounds);
            //player2.Initialize(Content.Load<Texture2D>("Graphics\\clouds"), playerPos, GraphicsDevice.Viewport.Bounds);

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            /*
            
            Vector2 temp = new Vector2(1, 0);

            // TODO: Add your update logic here
            playerPos = playerPos + temp;

            if (playerPos.X == (GraphicsDevice.Viewport.TitleSafeArea.X + GraphicsDevice.Viewport.TitleSafeArea.Width))
                playerPos.X = GraphicsDevice.Viewport.TitleSafeArea.X;

            
            */

            //player1.Update(playerPos);



            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            // TODO: Add your drawing code here

            spriteBatch.Begin();

            //player1.Draw(spriteBatch);
            //player2.Draw(spriteBatch);

            level1.Draw();

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
