
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
    public partial class LoomingCircleStimuli
    {
        public IObservable<LoomingCircleStimuli> Process()
        {
            return Observable.Defer(() =>
            {
                var value = new LoomingCircleStimuli
                {
					AnimationSettings = AnimationSettings,
					BackgroundColor = BackgroundColor,
					Color = Color,
					DelayOffset = DelayOffset,
					DelayOnset = DelayOnset,
					Diameter = Diameter,
					AdditionalProperties = AdditionalProperties,

                };
                return Observable.Return(value);
            });
        }
    }
}
