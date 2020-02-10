using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Alcom.App_Start
{
    public class BundleConfig
    {
        public static void BundleCalistir(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/myJs").IncludeDirectory("~/Template/assets/js/", "*.js",true));
            bundles.Add(new StyleBundle("~/myCss").IncludeDirectory("~/Template/assets/css/", "*.css",true));

            BundleTable.EnableOptimizations = true;
        }
    }
}

 