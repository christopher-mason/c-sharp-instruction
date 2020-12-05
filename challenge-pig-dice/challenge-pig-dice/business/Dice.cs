using System;
using System.Collections.Generic;
using System.Text;

namespace challenge_pig_dice.business {
    class Dice {

        public static int getDiceRoll() {
            var r = new Random();
            int diceRoll = r.Next(6) + 1;
            return diceRoll;

            }

        }
    }
