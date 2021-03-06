﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace ProspectorPeril
{
    class OneUp : Sprite
    {
        public bool IsRising = false;
        float timer = 1000;

        /// <summary>
        /// Default constructor
        /// </summary>
        public OneUp() : base()
        {
            Layer = 5;
            Visible = false;
        }

        /// <summary>
        /// Constructor used when a sprite only uses a single texture
        /// </summary>
        /// <param name="texture">A valid Texture2D this sprite will render</param>
        public OneUp(Texture2D texture) : base(texture)
        {
            Layer = 5;
            Visible = false;
        }

        /// <summary>
        /// Constructor used when a sprite uses multiple textures
        /// </summary>
        /// <param name="textures">Generic list of Texture2D objects</param>
        public OneUp(List<Texture2D> textures)
            : base(textures)
        {
            Layer = 5;
            Visible = false;
        }
        
        public override void Update(GameTime gameTime)
        {
            if (Visible)
            {
                Position.Y -= 1;
                timer -= gameTime.ElapsedGameTime.Milliseconds;
            }

            if (timer <= 0)
            {
                Visible = false;
                timer = 1000;
            }

            base.Update(gameTime);            
        }

        public void Play(Vector2 position)
        {
            Position = position;
            Visible = true;
        }

        public void Stop()
        {
            Visible = false;
            timer = 1000;
        }
    }
}
