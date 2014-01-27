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
        private IAnimatedSprite iAnimatedSprite;
        private Scorpion scorpion;
        private Texture2D texture;
        protected Rectangle destinationRect, sourceRect;
        private float timer = 0f;
        protected SpriteEffects effect;
        protected int imageNumber = 1; //loopt van 0 tot en met 3
        protected float rotation = 0f;

        private Vector2 pivot;


        //constructor
        public AnimatedSprite(IAnimatedSprite iAnimatedSprite)
        {
            this.iAnimatedSprite = iAnimatedSprite;
            this.sourceRect = new Rectangle(this.imageNumber * 32, 0, 32, 32);
            this.effect = SpriteEffects.None;

            this.pivot = new Vector2(16f, 16);
            
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
        public void Draw(GameTime gameTime)
        {
            this.iAnimatedSprite.Game.spritebatch.Draw(this.iAnimatedSprite.Texture,
                                              this.destinationRect,
                                              this.sourceRect,
                                              Color.White,
                                              this.rotation,
                                              this.pivot,
                                              this.effect,
                                              0f);


        }
    }
}
