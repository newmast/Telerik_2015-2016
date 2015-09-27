using Gravity;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Test3D
{

    public class Test3DDemo2 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Player player;

        public Test3DDemo2()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            player = new Player(new Vector2(100, 100));
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            player.Model = Content.Load<Texture2D>("main-character/Idle__000");
        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            graphics.GraphicsDevice.Clear(Color.White);


            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                player.Acceleration = new Vector2(player.Acceleration.X, player.Acceleration.Y - Player.Speed);
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                player.Acceleration = new Vector2(player.Acceleration.X, player.Acceleration.Y + Player.Speed);
            } 

            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                player.Acceleration = new Vector2(player.Acceleration.X - Player.Speed, player.Acceleration.Y);
            } 

            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                player.Acceleration = new Vector2(player.Acceleration.X + Player.Speed, player.Acceleration.Y);
            }

            if (!Keyboard.GetState().IsKeyDown(Keys.Up) &&
                !Keyboard.GetState().IsKeyDown(Keys.Down) &&
                !Keyboard.GetState().IsKeyDown(Keys.Left) &&
                !Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                player.Acceleration = Vector2.Zero;
                player.Velocity /= Player.Friction;
            }

            Vector2 oldVelocity = player.Velocity;
            player.Velocity += player.Acceleration * (float)gameTime.ElapsedGameTime.TotalSeconds;
            player.Position += (oldVelocity + player.Velocity) * 0.5f * (float)gameTime.ElapsedGameTime.TotalMilliseconds;

            ////if (player.Position.X < 0 ||
            //    player.Position.Y < 0 ||
            //    player.Position.X + player.Bounds.Width < graphics.GraphicsDevice.Viewport.Width ||
            //    player.Position.Y + player.Bounds.Height < graphics.GraphicsDevice.Viewport.Height)
            //{
            //    player.Position -= (oldVelocity + player.Velocity) * 0.5f * (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            //}

            spriteBatch.Begin();

            spriteBatch.Draw(player.Model, player.Bounds, Color.White);

            spriteBatch.End();
            base.Update(gameTime);
        }

    }
}