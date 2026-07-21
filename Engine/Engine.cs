using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;

namespace GMTK_Game_Jam.Engine
{
    public class Engine : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Engine()
        {
            // window config
            _graphics = new GraphicsDeviceManager(this);

            Content.RootDirectory = "Content";
            IsMouseVisible = EngineConfig.MouseVisible;

            Window.Title = EngineConfig.WindowTitle;

            _graphics.PreferredBackBufferWidth = EngineConfig.WindowWidth;
            _graphics.PreferredBackBufferHeight = EngineConfig.WindowHeight;
            _graphics.IsFullScreen = EngineConfig.FullScreen;
            _graphics.SynchronizeWithVerticalRetrace = EngineConfig.VSync;

            _graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            Input.Update();

            if (Input.IsKeyPressed(Keys.Escape))
                Exit();


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
