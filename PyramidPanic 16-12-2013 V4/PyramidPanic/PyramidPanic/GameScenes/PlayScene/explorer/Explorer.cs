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
    public class Explorer : AnimatedSprite
    {
        //fields
        private PyramidPanic game;
        private Texture2D texture;


        //propperties




        //constructor
        public Explorer(PyramidPanic game)
            : base(game)
        {
            this.game = game;
            this.texture = game.Content.Load<Texture2D>(@"explorer/Explorer");
            this.destinationRect.X = 300;
            this.destinationRect.Y = 400;
        }



        //update
        public void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }


        //draw
        public void Draw(GameTime gameTime)
        {
            base.Draw(gameTime, this.texture);
        }
    }
}