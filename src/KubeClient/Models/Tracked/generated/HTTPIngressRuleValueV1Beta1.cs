using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models.Tracked
{
    /// <summary>
    ///     HTTPIngressRuleValue is a list of http selectors pointing to backends. In the example: http://&lt;host&gt;/&lt;path&gt;?&lt;searchpart&gt; -&gt; backend where where parts of the url correspond to RFC 3986, this resource will be used to match against everything after the last '/' and before the first '?' or '#'.
    /// </summary>
    public partial class HTTPIngressRuleValueV1Beta1 : Models.HTTPIngressRuleValueV1Beta1, ITracked
    {
        /// <summary>
        ///     A collection of paths that map requests to backends.
        /// </summary>
        [YamlMember(Alias = "paths")]
        [JsonProperty("paths", NullValueHandling = NullValueHandling.Ignore)]
        public override List<Models.HTTPIngressPathV1Beta1> Paths { get; set; } = new List<Models.HTTPIngressPathV1Beta1>();

        /// <summary>
        ///     Names of model properties that have been modified.
        /// </summary>
        [JsonIgnore, YamlIgnore]
        public ISet<string> __ModifiedProperties__ { get; } = new HashSet<string>();
    }
}
