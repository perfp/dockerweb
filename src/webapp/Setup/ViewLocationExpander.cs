using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Razor;

namespace webapp{

    public class ViewLocationExpander : IViewLocationExpander
    {
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            var locations = new []{
                "{1}/{0}.cshtml"
            };
            return locations.Union(viewLocations);
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
            
        }
    }
}