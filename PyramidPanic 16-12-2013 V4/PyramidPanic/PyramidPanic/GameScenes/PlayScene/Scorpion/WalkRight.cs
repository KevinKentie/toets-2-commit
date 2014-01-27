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
    public class WalkRight : AnimatedSprite, IEntityState
    {
        //fields
        private Scorpion scorpion;
        private Vector2 velocity;

        //Constructor
        public WalkRight(Scorpion scorpion) : base(scorpion)
        {
            this.scorpion = scorpion;
            this.destinationRect = new Rectangle((int)this.scorpion.Position.X,
                                                (int)this.scorpion.Position.Y,
                                                32,
                                                32);
            this.velocity = new Vector2(this.scorpion.Speed, 0f);
        }

        public void Initialize()
        {
            this.destinationRect.X = (int)this.scorpion.Position.X;
            this.destinationRect.Y = (int)this.scorpion.Position.Y;
        }

        public void Update(GameTime gameTime)
        {
            if (this.scorpion.Position.X > 640 - 16)
            {
                this.scorpion.State = this.scorpion.WalkLeft;
                this.scorpion.WalkLeft.Initialize();
            }
            this.scorpion.Position += this.velocity;
            this.destinationRect.X = (int)this.scorpion.Position.X;
            this.destinationRect.Y = (int)this.scorpion.Position.Y;
            base.Update(gameTime);
        }


        public void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
