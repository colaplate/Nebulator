﻿using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Nebulator.Common
{
    // https://stackoverflow.com/questions/1100285/how-to-detect-the-currently-pressed-key

    public static class KeyboardState
    {
        [Flags]
        private enum KeyStates { None = 0, Down = 1, Toggled = 2 }

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern short GetKeyState(int keyCode);

        private static KeyStates GetKeyState(Keys key)
        {
            KeyStates state = KeyStates.None;

            short retVal = GetKeyState((int)key);

            // If the high-order bit is 1, the key is down otherwise, it is up.
            if ((retVal & 0x8000) == 0x8000)
            {
                state |= KeyStates.Down;
            }

            // If the low-order bit is 1, the key is toggled.
            if ((retVal & 1) == 1)
            {
                state |= KeyStates.Toggled;
            }

            return state;
        }

        public static bool IsKeyDown(Keys key)
        {
            return KeyStates.Down == (GetKeyState(key) & KeyStates.Down);
        }

        public static bool IsKeyToggled(Keys key)
        {
            return KeyStates.Toggled == (GetKeyState(key) & KeyStates.Toggled);
        }
    }
}
