﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Werewolf_Website.Models
{
    public class GameInfo
    {
        public HashSet<int> Users { get; set; } = new HashSet<int>();
        public long GroupId { get; set; }
        public string Language { get; set; }
        public string ChatGroup { get; set; }
        public GameState State { get; set; }
        public HashSet<IPlayer> Players { get; set; } = new HashSet<IPlayer>();
        public Guid NodeId { get; set; }
    }
    public enum GameState
    {
        Joining, Running, Dead
    }
}