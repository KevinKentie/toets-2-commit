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
    public class Menu
    {
        //fields
        private Image start;
        private Image load;
        private Image scores;
        private Image help;
        private Image quit;

        //Maak een variable van het type Pyramid panic
        private PyramidPanic game;

        //constructor
        public Menu(PyramidPanic game)
        {
            this.game = game;
            this.Initialize();
        }

        //Initialize
        public void Initialize()
        {
            this.LoadContent();
        }

        //LoadContent
        public void LoadContent()
        {
            this.start = new Image(game, @"StartScene\Button_start", new Vector2(10f, 410));
            this.load = new Image(game, @"StartScene\Button_load", new Vector2(140f, 410));
            this.scores = new Image(game, @"StartScene\Button_scores", new Vector2(270f, 410));
            this.help = new Image(game, @"StartScene\Button_help", new Vector2(400f, 410));
            this.quit = new Image(game, @"StartScene\Button_quit", new Vector2(510f, 410));
        }

        //Update
        public void Update()
        {

        }

        //draw
        public void Draw(GameTime gameTime)
        {
            this.start.Draw(gameTime);
            this.load.Draw(gameTime);
            this.scores.Draw(gameTime);
            this.help.Draw(gameTime);
            this.quit.Draw(gameTime);
        }
    }
}
