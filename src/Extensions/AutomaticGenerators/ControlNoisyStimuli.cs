
using Bonsai;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using YamlDotNet.Serialization;
using System.IO;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Core;
using AutomaticGenerators;

namespace AutomaticGenerators
{
    [Combinator]
    [Description("Constructor.")]
    [WorkflowElementCategory(ElementCategory.Source)]
    public partial class ControlNoisyStimuli
    {
        public IObservable<ControlNoisyStimuli> Process()
        {
            return Observable.Defer(() =>
            {
                var value = new ControlNoisyStimuli
                {
					AnimationSettings = AnimationSettings,
					BackgroundColor = BackgroundColor,
					DelayOffset = DelayOffset,
					DelayOnset = DelayOnset,
					Diameter = Diameter,
					OffColor = OffColor,
					OnColor = OnColor,
					AdditionalProperties = AdditionalProperties,

                };
                return Observable.Return(value);
            });
        }
    }
}
