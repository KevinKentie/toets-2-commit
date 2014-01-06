﻿//met Using kan je een XNA codebibliotheer gebruiken in je class
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
    public class ScorpionClass : AnimatedSprite
    {
        //fields
        private PyramidPanic game;
        private Texture2D texture;
        private int speed = 2;


        //propperties
        



        //constructor
        public ScorpionClass(PyramidPanic game) : base(game)
        {
            this.game = game;
            this.texture = game.Content.Load<Texture2D>(@"Scorpion/Scorpion");

            
        }



        //update
        public void Update(GameTime gameTime)
        {
           
            if (this.destinationRect.X > (640 - 32) || 
                this.destinationRect.X < 0)
            {
                if (this.speed > 0)
                {
                    this.effect = SpriteEffects.FlipHorizontally;
                }
                else
                {
                    this.effect = SpriteEffects.None;
                }
                this.speed = this.speed * -1;
            }
            this.destinationRect.X += this.speed;
            base.Update(gameTime);
        }


        //draw
        public void Draw(GameTime gameTime)
        {
            base.Draw(gameTime, this.texture);
        }
    }
}
