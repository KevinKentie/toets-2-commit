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
        //Maak een enumaration voor de mogelijke buttons
        private enum Buttons { Start, Load, Scores, Help, Quit };

        //Maak een variabele van het type Buttons en geef hem de waarde Buttons.Start
        private Buttons buttonActive = Buttons.Start;

        private Image start;
        private Image load;
        private Image scores;
        private Image help;
        private Image quit;

        //Maak een variable van het type Pyramid panic
        private PyramidPanic game;

        private Color activeColor = Color.SandyBrown;

        //Maak een variabele buttenlist van het type List<Image>
        private List<Image> buttenList;

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
            this.buttenList = new List<Image>();
            this.buttenList.Add(this.start = new Image(game, @"StartScene\Button_start", new Vector2(10f, 410)));
            this.buttenList.Add(this.load = new Image(game, @"StartScene\Button_load", new Vector2(140f, 410)));
            this.buttenList.Add(this.scores = new Image(game, @"StartScene\Button_scores", new Vector2(270f, 410)));
            this.buttenList.Add(this.help = new Image(game, @"StartScene\Button_help", new Vector2(400f, 410)));
            this.buttenList.Add(this.quit = new Image(game, @"StartScene\Button_quit", new Vector2(530f, 410)));
            
            
            
            
        }

        //Update
        public void Update()
        {

            //Maak een switch case constructie voor de variable buttonActive
            //Deze if - instructie checkt of er op de rechter rechterpijltoets wordt gedrukt.
            //De actie die daarop volgt is het ophogen van de variabele buttenActive
            if (Input.EdgeDetectKeyDown(Keys.Right))
            {
                this.buttonActive++;
            }
            if (Input.EdgeDetectKeyDown(Keys.Left))
            {
                this.buttonActive--;
            }

            

            //We doorlopen het this.buttonList object (List<Image> ) met een foreach instructie
            //En we roepen ieder image-opject de propertie Color op en geven deze de waarde Color.White
            foreach (Image image in this.buttenList)
            {
                image.Color = Color.White;
            }

            switch (this.buttonActive)
            {
                case Buttons.Start:
                    this.start.Color = this.activeColor;
                    break;
                case Buttons.Load:
                    this.load.Color = this.activeColor;
                    break;
                case Buttons.Scores:
                    this.scores.Color = this.activeColor;
                    break;
                case Buttons.Help:
                    this.help.Color = this.activeColor;
                    break;
                case Buttons.Quit:
                    this.quit.Color = this.activeColor;
                    break;
            }
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
