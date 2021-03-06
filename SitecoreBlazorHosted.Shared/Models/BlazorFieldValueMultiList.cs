﻿using System.Collections.Generic;

namespace SitecoreBlazorHosted.Shared.Models
{
    public class BlazorFieldValueMultiList : IBlazorFieldValue
    {
        public List<BlazorFieldValueMultiListItem> Values { get; set; }
    }

    public class BlazorFieldValueMultiListItem
    {
        public string Id { get; set; }
        public string Url { get; set; }

        public Dictionary<string, BlazorRouteField> Fields { get; set; }
        public List<IBlazorItemField> BlazorItemFields { get; set; }

    }


}
