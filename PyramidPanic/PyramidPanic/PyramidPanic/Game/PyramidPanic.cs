//met Using kan je een XNA codebibliotheer gebruiken in je class
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace PyramidPanic
{
    public class PyramidPanic : Microsoft.Xna.Framework.Game
    {
        //fields
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private KeyboardState ks, oks;

        //Dit is de constructor. Heeft altijd dezelfde naam als de class
        public PyramidPanic()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            //Veranderd de titel vam het canvas
            Window.Title = "Pyramid Panic beta 00.00.00.01";
            //Maakt de muis zichtbaar
            IsMouseVisible = true;
            //Verandert de breedte van het canvas
            this.graphics.PreferredBackBufferWidth = 640;
            //veranderd de hoogte van het canvas
            this.graphics.PreferredBackBufferHeight = 480;
            //past de nieuwe hoogte en breedte aan
            this.graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            //een spritebatch is nodig voor het tekenen van textures op het canvas
            spriteBatch = new SpriteBatch(GraphicsDevice);

        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            this.ks = Keyboard.GetState();

            //zorgt dat je stopt als je de back butten op de gamepad indrukt
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            if (this.ks.IsKeyDown(Keys.Escape))
                this.Exit();

            this.ks = this.oks;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);


            base.Draw(gameTime);
        }
    }
}
