﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Retina.Stages
{
    class GroupStage : Stage
    {
        public List<Stage> Stages { get; set; }

        public GroupStage(Options options, List<Stage> stages) 
            : base(options)
        {
            Stages = stages;
        }

        protected override StringBuilder Process(string input)
        {
            string result = input;
            foreach (var stage in Stages)
                result = stage.Execute(result);

            return new StringBuilder(result);
        }
    }
}
