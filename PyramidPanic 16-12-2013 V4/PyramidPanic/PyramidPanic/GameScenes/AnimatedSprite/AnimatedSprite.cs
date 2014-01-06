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
    public class AnimatedSprite
    {
        //fields
        private PyramidPanic game;
        private Texture2D texture;
        protected Rectangle destinationRect, sourceRect;
        private float timer = 0f;
        protected SpriteEffects effect = SpriteEffects.None;


        //constructor
        public AnimatedSprite(PyramidPanic game)
        {
            this.game = game;
            this.destinationRect = new Rectangle(100, 200, 32, 32);
            this.sourceRect = new Rectangle(0, 0, 32, 32);
        }

        //update
        public void Update(GameTime gameTime)
        {
            if (this.timer > 10 / 60f)
            {
                if (this.sourceRect.X < 96)
                {
                    this.sourceRect.X += 32;
                }
                else
                {
                    this.sourceRect.X = 0;
                }
                this.timer = 0;

            }

            this.timer += 1 / 60f;
        }


        //draw method van de animatedsprite class
        public void Draw(GameTime gameTime, Texture2D texture)
        {
            this.game.spritebatch.Draw     (texture,
                                           this.destinationRect,
                                           this.sourceRect,
                                           Color.White,
                                           0f,
                                           Vector2.Zero,
                                           this.effect,
                                           0f);
        }
    }
}
