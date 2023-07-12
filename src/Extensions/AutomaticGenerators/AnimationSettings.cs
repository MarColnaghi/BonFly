
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
    public partial class AnimationSettings
    {
        public IObservable<AnimationSettings> Process()
        {
            return Observable.Defer(() =>
            {
                var value = new AnimationSettings
                {
					Duration = Duration,
					InitialRadius = InitialRadius,
					InitialVirtualDistance = InitialVirtualDistance,
					LinearApproachingVelocity = LinearApproachingVelocity,
					MaxRadius = MaxRadius,
					MonitorDistance = MonitorDistance,
					AdditionalProperties = AdditionalProperties,

                };
                return Observable.Return(value);
            });
        }
    }
}
