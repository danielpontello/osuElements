﻿namespace osuElements.Beatmaps.Difficulty
{
    public class TaikoDifficultyCalculator : DifficultyCalculatorBase
    {
        public override GameMode GameMode => GameMode.Taiko;
        public override double StarDifficulty { get; protected set; }
        public override void Calculate(Mods mods) {
            base.Calculate(mods);
            throw new System.NotImplementedException();
        }
    }
}