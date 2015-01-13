﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProspectorPeril
{    
    public interface Enemy
    {
        bool HasSpawned { get; set; }

        void Spawn(Vector2 spawnPosition);

        bool Collides(Sprite sprite);

        void UpdateEnemy(GameTime gameTime);

        void DrawEnemy(SpriteBatch spriteBatch);
    }
}
