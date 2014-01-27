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
    public class PlayScene : IState
    {
        //Fields van de class StartScene
        private Beetle beetle, beetle1;
        private Scorpion scorpion, scorpion1;
        private PyramidPanic game;
        private Explorer explorer;

        //Constructor van de StartScene-class krijgt een object mee van het type PyramidPanic 
        public PlayScene(PyramidPanic game)
        {
            this.game = game;
            this.Initialize();
        }

        //Initialize methode. deze methode initialiseert (geeft startwaarden aan variabelen)
        //Void wil zeggen dat er niets terug gegeven word
        public void Initialize()
        {
            this.LoadContent();
        }

        //LoadContent methode. Deze methode maakt nieuwe objecten aan van verschillende
        //classes
        public void LoadContent()
        {
            this.scorpion = new Scorpion(this.game, new Vector2(300f, 188f));
            this.scorpion1 = new Scorpion(this.game, new Vector2(350f, 288f));
            this.beetle = new Beetle(this.game, new Vector2(100f, 300f));
            this.beetle1 = new Beetle(this.game, new Vector2(150f, 250f));
            this.explorer = new Explorer(this.game, new Vector2(16f, 240f));
        }

        // Update methode. Deze methode wordt normaal 60 maal per seconde aangeroepen
        // en update alle variabelen, methods enz.......
        public void Update(GameTime gameTime)
        {
            if (Input.EdgeDetectKeyDown(Keys.B))
            {
                this.game.IState = this.game.StartScene;
            }
            this.beetle.Update(gameTime);
            this.beetle1.Update(gameTime);
            this.scorpion.Update(gameTime);
            this.scorpion1.Update(gameTime);
            this.explorer.Update(gameTime);
        }

        // Draw methode. Deze methode wordt normaal 60 maal per seconde aangeroepen en
        // tekent de textures p[ het canvas
        public void Draw(GameTime gameTime)
        {
            this.game.GraphicsDevice.Clear(Color.LightGreen);
            this.beetle.Draw(gameTime);
            this.scorpion.Draw(gameTime);
            this.beetle1.Draw(gameTime);
            this.scorpion1.Draw(gameTime);
            this.explorer.Draw(gameTime);
        }
    }
}
