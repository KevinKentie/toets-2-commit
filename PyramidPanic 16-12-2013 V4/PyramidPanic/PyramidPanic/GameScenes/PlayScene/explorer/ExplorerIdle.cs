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
    public class ExplorerIdle : AnimatedSprite, IEntityState
    {
        //fields
        private Explorer explorer;
        private Vector2 velocity;
        
        //properties
        public SpriteEffects Effect
        {
            set { this.effect = value; }
        }

        public float Rotation
        {
            set { this.rotation = value; }
        }


        //Constructor
        public ExplorerIdle(Explorer explorer) : base(explorer)
        {
            this.explorer = explorer;
            this.destinationRect = new Rectangle((int)this.explorer.Position.X,
                                                (int)this.explorer.Position.Y,
                                                32,
                                                32);
            this.velocity = new Vector2(this.explorer.Speed, 0f);
            this.imageNumber = 1;
        }

        public void Initialize()
        {
            
            this.destinationRect.X = (int)this.explorer.Position.X;
            this.destinationRect.Y = (int)this.explorer.Position.Y;
        }

        public void Update(GameTime gameTime)
        {
            if (this.explorer.Position.X > 640 - 32)
            {
                //this.explorer.State = this.explorer.ExplorerWalkLeft;
                //this.explorer.WalkRight.Initialize();
            }
            //Bij het indrukken van de Right knop moet de toestand van de explorer veranderen in ExplorerWalkRight
            if (Input.EdgeDetectKeyDown(Keys.Right))
            {
                this.explorer.State = this.explorer.WalkRight;
                this.explorer.WalkRight.Initialize();
            }
            if (Input.EdgeDetectKeyDown(Keys.Left))
            {
                this.explorer.State = this.explorer.WalkLeft;
                this.explorer.WalkLeft.Initialize();
                this.explorer.Idle.effect = SpriteEffects.FlipHorizontally;
            }
            if (Input.EdgeDetectKeyDown(Keys.Down))
            {
                this.explorer.State = this.explorer.WalkDown;
                this.explorer.WalkDown.Initialize();
                
                
            }
            if (Input.EdgeDetectKeyDown(Keys.Up))
            {
                this.explorer.State = this.explorer.WalkUp;
                this.explorer.WalkUp.Initialize();
            }

            //this.explorer.Position += this.velocity;
            this.destinationRect.X = (int)this.explorer.Position.X;
            this.destinationRect.Y = (int)this.explorer.Position.Y;
            //base.Update(gameTime);
        }


        public new void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
