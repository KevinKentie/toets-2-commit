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
    //Dit is een toestands class (dus moet hij de interface toepassen)
    //Deze class belooft dan plechtig dat hij de methods uit de interface heeft
    public class WalkUp : AnimatedSprite, IBeetleState
    {
        //fields
        private Beetle beetle;
        private Vector2 velocity;

        //Constructor
        public WalkUp(Beetle beetle) : base(beetle)
        {
            this.beetle = beetle;
            this.destinationRect = new Rectangle((int)this.beetle.Position.X,
                                                (int)this.beetle.Position.Y,
                                                32,
                                                32);
            this.velocity = new Vector2(0f,this.beetle.Speed);
        }

        public void Initialize()
        {
            this.destinationRect.X = (int)this.beetle.Position.X;
            this.destinationRect.Y = (int)this.beetle.Position.Y;
        }

        public void Update(GameTime gameTime)
        {
            if (this.beetle.Position.Y < 0 + 16)
            {
                this.beetle.State = this.beetle.WalkDown;
                this.beetle.WalkDown.Initialize();
            }
            this.beetle.Position -= this.velocity;
            this.destinationRect.X = (int)this.beetle.Position.X;
            this.destinationRect.Y = (int)this.beetle.Position.Y;
            base.Update(gameTime);
        }


        public void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
