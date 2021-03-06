﻿using System;

namespace bubblegumMachine
{
    class Gui
    {
        public void RenderMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            RenderAscii();

            Console.WriteLine("1. withdraw a gum");
            Console.WriteLine("2. exit");

        }

        public void RenderAscii()
        {
            
            string title = @"            
                ______ _   _____________ _      _____ _____ _   ____  ___ 
                | ___ \ | | | ___ \ ___ \ |    |  ___|  __ \ | | |  \/  | 
                | |_/ / | | | |_/ / |_/ / |    | |__ | |  \/ | | | .  . | 
                | ___ \ | | | ___ \ ___ \ |    |  __|| | __| | | | |\/| | 
                | |_/ / |_| | |_/ / |_/ / |____| |___| |_\ \ |_| | |  | | 
                \____/ \___/\____/\____/\_____/\____/ \____/\___/\_|  |_/ 
                                                                          
                                                                          
                ___  ___  ___  _____  _   _ _____ _   _  _____            
                |  \/  | / _ \/  __ \| | | |_   _| \ | ||  ___|           
                | .  . |/ /_\ \ /  \/| |_| | | | |  \| || |__             
                | |\/| ||  _  | |    |  _  | | | | . ` ||  __|            
                | |  | || | | | \__/\| | | |_| |_| |\  || |___            
                \_|  |_/\_| |_/\____/\_| |_/\___/\_| \_/\____/    
            ";
            Console.WriteLine(title);
        }
    }
}