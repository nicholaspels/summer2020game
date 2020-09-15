﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class PFRulesVariable : PathfindingRules {

    [Serializable]
    public struct variantRuleset {
        public bool northIn;
        public bool eastIn;
        public bool southIn;
        public bool westIn;
        public bool northEastIn;
        public bool southEastIn;
        public bool southWestIn;
        public bool northWestIn;
        public bool upIn;
        public bool downIn;
        public bool upNorthIn;
        public bool upEastIn;
        public bool upSouthIn;
        public bool upWestIn;
        public bool downNorthIn;
        public bool downEastIn;
        public bool downSouthIn;
        public bool downWestIn;
        public bool upNorthEastIn;
        public bool upSouthEastIn;
        public bool upSouthWestIn;
        public bool upNorthWestIn;
        public bool downNorthEastIn;
        public bool downSouthEastIn;
        public bool downSouthWestIn;
        public bool downNorthWestIn;

        public bool northOut;
        public bool eastOut;
        public bool southOut;
        public bool westOut;
        public bool northEastOut;
        public bool southEastOut;
        public bool southWestOut;
        public bool northWestOut;
        public bool upOut;
        public bool downOut;
        public bool upNorthOut;
        public bool upEastOut;
        public bool upSouthOut;
        public bool upWestOut;
        public bool downNorthOut;
        public bool downEastOut;
        public bool downSouthOut;
        public bool downWestOut;
        public bool upNorthEastOut;
        public bool upSouthEastOut;
        public bool upSouthWestOut;
        public bool upNorthWestOut;
        public bool downNorthEastOut;
        public bool downSouthEastOut;
        public bool downSouthWestOut;
        public bool downNorthWestOut;
    }

    public variantRuleset[] variantRules;

    public void SwitchRuleset(int rulesetIndex) {
        variantRuleset rules = variantRules[rulesetIndex];
        northIn = rules.northIn;
        eastIn = rules.eastIn;
        southIn = rules.southIn;
        westIn = rules.westIn;
        northEastIn = rules.northEastIn;
        southEastIn = rules.southEastIn;
        southWestIn = rules.southWestIn;
        northWestIn = rules.northWestIn;
        upIn = rules.upIn;
        downIn = rules.downIn;
        upNorthIn = rules.upNorthIn;
        upEastIn = rules.upEastIn;
        upSouthIn = rules.upSouthIn;
        upWestIn = rules.upWestIn;
        downNorthIn = rules.downNorthIn;
        downEastIn = rules.downEastIn;
        downSouthIn = rules.downSouthIn;
        downWestIn = rules.downWestIn;
        upNorthEastIn = rules.upNorthEastIn;
        upSouthEastIn = rules.upSouthEastIn;
        upSouthWestIn = rules.upSouthWestIn;
        upNorthWestIn = rules.upNorthWestIn;
        downNorthEastIn = rules.downNorthEastIn;
        downSouthEastIn = rules.downSouthEastIn;
        downSouthWestIn = rules.downSouthWestIn;
        downNorthWestIn = rules.downNorthWestIn;

        northOut = rules.northOut;
        eastOut = rules.eastOut;
        southOut = rules.southOut;
        westOut = rules.westOut;
        northEastOut = rules.northEastOut;
        southEastOut = rules.southEastOut;
        southWestOut = rules.southWestOut;
        northWestOut = rules.northWestOut;
        upOut = rules.upOut;
        downOut = rules.downOut;
        upNorthOut = rules.upNorthOut;
        upEastOut = rules.upEastOut;
        upSouthOut = rules.upSouthOut;
        upWestOut = rules.upWestOut;
        downNorthOut = rules.downNorthOut;
        downEastOut = rules.downEastOut;
        downSouthOut = rules.downSouthOut;
        downWestOut = rules.downWestOut;
        upNorthEastOut = rules.upNorthEastOut;
        upSouthEastOut = rules.upSouthEastOut;
        upSouthWestOut = rules.upSouthWestOut;
        upNorthWestOut = rules.upNorthWestOut;
        downNorthEastOut = rules.downNorthEastOut;
        downSouthEastOut = rules.downSouthEastOut;
        downSouthWestOut = rules.downSouthWestOut;
        downNorthWestOut = rules.downNorthWestOut;
    }

    public void UseRuleset(variantRuleset rules) {
        northIn = rules.northIn;
        eastIn = rules.eastIn;
        southIn = rules.southIn;
        westIn = rules.westIn;
        northEastIn = rules.northEastIn;
        southEastIn = rules.southEastIn;
        southWestIn = rules.southWestIn;
        northWestIn = rules.northWestIn;
        upIn = rules.upIn;
        downIn = rules.downIn;
        upNorthIn = rules.upNorthIn;
        upEastIn = rules.upEastIn;
        upSouthIn = rules.upSouthIn;
        upWestIn = rules.upWestIn;
        downNorthIn = rules.downNorthIn;
        downEastIn = rules.downEastIn;
        downSouthIn = rules.downSouthIn;
        downWestIn = rules.downWestIn;
        upNorthEastIn = rules.upNorthEastIn;
        upSouthEastIn = rules.upSouthEastIn;
        upSouthWestIn = rules.upSouthWestIn;
        upNorthWestIn = rules.upNorthWestIn;
        downNorthEastIn = rules.downNorthEastIn;
        downSouthEastIn = rules.downSouthEastIn;
        downSouthWestIn = rules.downSouthWestIn;
        downNorthWestIn = rules.downNorthWestIn;

        northOut = rules.northOut;
        eastOut = rules.eastOut;
        southOut = rules.southOut;
        westOut = rules.westOut;
        northEastOut = rules.northEastOut;
        southEastOut = rules.southEastOut;
        southWestOut = rules.southWestOut;
        northWestOut = rules.northWestOut;
        upOut = rules.upOut;
        downOut = rules.downOut;
        upNorthOut = rules.upNorthOut;
        upEastOut = rules.upEastOut;
        upSouthOut = rules.upSouthOut;
        upWestOut = rules.upWestOut;
        downNorthOut = rules.downNorthOut;
        downEastOut = rules.downEastOut;
        downSouthOut = rules.downSouthOut;
        downWestOut = rules.downWestOut;
        upNorthEastOut = rules.upNorthEastOut;
        upSouthEastOut = rules.upSouthEastOut;
        upSouthWestOut = rules.upSouthWestOut;
        upNorthWestOut = rules.upNorthWestOut;
        downNorthEastOut = rules.downNorthEastOut;
        downSouthEastOut = rules.downSouthEastOut;
        downSouthWestOut = rules.downSouthWestOut;
        downNorthWestOut = rules.downNorthWestOut;
    }
}