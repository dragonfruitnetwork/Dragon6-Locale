﻿// Dragon6 API Copyright 2021 DragonFruit Network <inbox@dragonfruit.network>
// Licensed under MIT. Please refer to the LICENSE file for more info

using System;
using System.Xml.Serialization;

namespace DragonFruit.Six.Locale.Agent.Crowdin
{
    [XmlRoot(ElementName = "success")]
    public class CrowdinProjectBuildResult
    {
        [XmlAttribute(AttributeName = "status")]
        private string StatusName
        {
            get => Status.ToString().ToLowerInvariant();
            set => Enum.Parse<BuildStatus>(value, true);
        }

        [XmlIgnore]
        public BuildStatus Status { get; set; }
    }

    public enum BuildStatus
    {
        Built,
        Skipped
    }
}
