﻿namespace OceanBattle.DataModel.Game.Exceptions
{
    public class SessionNotFoundException : Exception
    { 
        public SessionNotFoundException()
            : base()
        {
        }

        public SessionNotFoundException(string? message)
            : base(message)
        {
        }

        public SessionNotFoundException(
            string? message, 
            Exception? innerException)
            : base(
                  message,
                  innerException)
        {
        }
    }
}
