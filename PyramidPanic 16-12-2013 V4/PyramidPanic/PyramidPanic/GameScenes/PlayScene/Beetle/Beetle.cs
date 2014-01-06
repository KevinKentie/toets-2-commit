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
    public class Beetle : AnimatedSprite
    {
        //fields
        private PyramidPanic game;
        private Texture2D texture;
        private int speed = 2;


        //propperties




        //constructor
        public Beetle(PyramidPanic game)
            : base(game)
        {
            this.game = game;
            this.texture = game.Content.Load<Texture2D>(@"Scorpion/Beetle");
            this.destinationRect.X = 0;
            this.destinationRect.Y = 400;

        }



        //update
        public void Update(GameTime gameTime)
        {
            if (this.destinationRect.Y > (480 - 32) ||
                this.destinationRect.Y < 0)
            {
                if (this.speed > 0)
                {
                    this.effect = SpriteEffects.None;
                }
                else
                {
                    this.effect = SpriteEffects.FlipVertically;
                }
                this.speed = this.speed * -1;
            }
            this.destinationRect.Y += this.speed;
            base.Update(gameTime);
        }


        //draw
        public void Draw(GameTime gameTime)
        {
            base.Draw(gameTime, this.texture);
        }
    }
}
