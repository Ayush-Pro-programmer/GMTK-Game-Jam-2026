using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

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
            Graphics.Initialize(GraphicsDevice);
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
            Graphics.Clear(Color.CornflowerBlue);

            Graphics.Begin();

            //drawing goes here...

            Graphics.DrawRectangle(
               new Rectangle(100, 100, 200, 100),
               Color.Red);

            Graphics.DrawRectangleOutline(
                new Rectangle(100, 100, 200, 100),
                Color.White);

            Graphics.End();

            base.Draw(gameTime);
        }
    }
}
