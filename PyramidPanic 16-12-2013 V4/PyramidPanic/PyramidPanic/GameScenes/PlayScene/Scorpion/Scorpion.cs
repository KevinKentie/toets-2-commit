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
    public class Scorpion : IAnimatedSprite
    {
        //fields
        private PyramidPanic game;
        private IEntityState state;
        private Texture2D texture;
        private int speed = 2;
        private Vector2 position;
        private WalkLeft walkLeft;
        private WalkRight walkRight;


        //propperties
        public IEntityState State
        {
            set { this.state = value; }
        }
        public PyramidPanic Game
        {
            get { return this.game; }
        }
        public int Speed
        {
            get { return this.speed; }
        }
        public Texture2D Texture
        {
            get { return this.texture; }
        }
        public Vector2 Position
        {
            get { return this.position; }
            set { this.position = value; }
        }
        public WalkRight WalkRight
        {
            get { return this.walkRight; }
        }
        public WalkLeft WalkLeft
        {
            get { return this.walkLeft; }
        }



        //constructor
        public Scorpion(PyramidPanic game, Vector2 position)
        {
            this.game = game;
            this.position = position;
            this.texture = game.Content.Load<Texture2D>(@"Scorpion/Scorpion");
            this.walkLeft = new WalkLeft(this);
            this.walkRight = new WalkRight(this);
            this.state = walkLeft;

        }



        //update
        public void Update(GameTime gameTime)
        {
            this.state.Update(gameTime);
        }


        //draw
        public void Draw(GameTime gameTime)
        {
            this.state.Draw(gameTime);
        }
    }
}
