
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
    public partial class MovingCircleStimuli
    {
        public IObservable<MovingCircleStimuli> Process()
        {
            return Observable.Defer(() =>
            {
                var value = new MovingCircleStimuli
                {
					StartPosition = StartPosition,
					EndPosition = EndPosition,
					BackgroundColor = BackgroundColor,
					Color = Color,
					DelayOffset = DelayOffset,
					DelayOnset = DelayOnset,
					Radius = Radius,
					Duration = Duration,
					AdditionalProperties = AdditionalProperties,

                };
                return Observable.Return(value);
            });
        }
    }
}
