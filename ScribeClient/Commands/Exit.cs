﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ScribeClient.Commands
{
    class Exit : ICommand
    {
        public string Command => "exit";

        public string Description => "Exits the program.";

        public string Ussage => "Type exit and the program quits.";

        /// <summary>
        /// Simply cloeses the program.
        /// </summary>
        /// <param name="args">Command args.</param>
        public void Execute(string[] args)
        {
            Environment.Exit(0);
        }
    }
}
