using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GMTK_Game_Jam;

public static class Graphics
{
    private static GraphicsDevice _graphicsDevice = null;
    private static SpriteBatch _spriteBatch = null;
    private static Texture2D _whiteTexture = null;

    internal static SpriteBatch SpriteBatch => _spriteBatch;
    internal static GraphicsDevice GraphicsDevice => _graphicsDevice;

    public static void Initialize(GraphicsDevice graphicsDevice)
    {
        _graphicsDevice = graphicsDevice;
        _spriteBatch = new SpriteBatch(graphicsDevice);

        _whiteTexture = new Texture2D(graphicsDevice, 1, 1);
        _whiteTexture.SetData(new[] { Color.White });
    }

    public static void Clear(Color color) => _graphicsDevice.Clear(color);

    public static void Begin(Matrix? transform = null)
    {
        _spriteBatch.Begin(
            sortMode: SpriteSortMode.Deferred,
            blendState: BlendState.AlphaBlend,
            samplerState: SamplerState.PointClamp,
            depthStencilState: DepthStencilState.None,
            rasterizerState: RasterizerState.CullNone,
            effect: null,
            transformMatrix: transform
        );
    }

    public static void End() => _spriteBatch.End();

    public static void Draw(Texture2D texture, Vector2 position) =>
        _spriteBatch.Draw(texture, position, Color.White);

    public static void Draw(Texture2D texture, Vector2 position, Color color) =>
        _spriteBatch.Draw(texture, position, color);

    public static void Draw(Texture2D texture, Rectangle dest) =>
        _spriteBatch.Draw(texture, dest, Color.White);

    public static void Draw(Texture2D texture, Rectangle dest, Color color) =>
        _spriteBatch.Draw(texture, dest, color);

    public static void Draw(
        Texture2D texture,
        Rectangle dest,
        Rectangle src,
        Color color
    ) =>
        _spriteBatch.Draw(texture, src, dest, color);

    public static void DrawRectangle(Rectangle rect, Color color) =>
        _spriteBatch.Draw(_whiteTexture, rect, color);

    public static void DrawRectangleOutline(Rectangle rect) =>
        DrawRectangleOutline(rect, Color.White, 4);

    public static void DrawRectangleOutline(Rectangle rect, Color color) =>
        DrawRectangleOutline(rect, color, 4);

    public static void DrawRectangleOutline(Rectangle rect, Color color, int thickness)
    {
        // Top
        DrawRectangle(new Rectangle(rect.X, rect.Y, rect.Width, thickness), color);
        
        // Bottom
        DrawRectangle(new Rectangle(rect.X, rect.Bottom - thickness, rect.Width, thickness), color);
        
        // Left
        DrawRectangle(new Rectangle(rect.X, rect.Y, thickness, rect.Height), color);
        
        // Right
        DrawRectangle(new Rectangle(rect.Right - thickness, rect.Y, thickness, rect.Height), color);
    }
}