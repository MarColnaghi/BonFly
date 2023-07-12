
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
    public partial class LoomingImageStimuli
    {
        public IObservable<LoomingImageStimuli> Process()
        {
            return Observable.Defer(() =>
            {
                var value = new LoomingImageStimuli
                {
					AnimationSettings = AnimationSettings,
					BackgroundColor = BackgroundColor,
					DelayOffset = DelayOffset,
					DelayOnset = DelayOnset,
					ScaleX = ScaleX,
					ScaleY = ScaleY,
					TextureName = TextureName,
					AdditionalProperties = AdditionalProperties,

                };
                return Observable.Return(value);
            });
        }
    }
}
