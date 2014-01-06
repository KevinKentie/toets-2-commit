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
    public class ScorpionClass
    {
        //fields
        private PyramidPanic game;
        private Texture2D texture;
        private Rectangle destinationRect, sourceRect;
        private float timer = 0f;


        //propperties




        //constructor
        public ScorpionClass(PyramidPanic game)
        {
            this.game = game;
            this.texture = game.Content.Load<Texture2D>(@"Scorpion/Scorpion");
            this.destinationRect = new Rectangle(100, 200, this.texture.Width/4, this.texture.Height);
            this.sourceRect = new Rectangle(0,0,32,32);
        }



        //update
        public void update(GameTime gameTime)
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


        //draw
        public void Draw(GameTime gametime)
        {
            this.game.spritebatch.Draw(this.texture,
                                       this.destinationRect,
                                       this.sourceRect,
                                       Color.White,
                                       0f,
                                       Vector2.Zero,
                                       SpriteEffects.None,
                                       0f);
        }
    }
}
