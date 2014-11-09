using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakaas.Words
{
    public static class RandomWords
    {
        static int max1 = 60;
        static int max2 = 65;
        static int max3 = 44;

        static int index1;
        static int index2;
        static int index3;


        static string[] array1 = new string[] 
        { 
        "implement", "utilize", "integrate", "streamline", "optimize", "evolve", "transform", "embrace", 
        "enable", "orchestrate", "leverage", "reinvent", "aggregate", "architect", "enhance", "incentivize", "morph", "empower", 
        "envisioneer", "monetize", "harness", "facilitate", "seize", "disintermediate", "synergize", "strategize", "deploy", 
        "brand", "grow", "target", "syndicate", "synthesize", "deliver", "mesh", "incubate", "engage", "maximize", "benchmark", 
        "expedite", "reintermediate", "whiteboard", "visualize", "repurpose", "innovate", "scale", "unleash", "drive", "extend", 
        "engineer", "revolutionize", "generate", "exploit", "transition", "e-enable", "iterate", "cultivate", "matrix", 
        "productize", "redefine", "escalate","recontextualize"
        };

        static string[] array2 = new string[] 
        {
            "clicks-and-mortar", "value-added", "vertical", "proactive", "robust", "revolutionary", "scalable", 
        "leading-edge", "innovative", "intuitive", "strategic", "e-business", "mission-critical", "sticky", "one-to-one", 
        "24/7", "end-to-end", "global", "B2B", "B2C", "granular", "frictionless", "virtual", "viral", "dynamic", "24/365", 
        "best-of-breed", "killer", "magnetic", "bleeding-edge", "web-enabled", "interactive", "dot-com", "sexy", "back-end", 
        "real-time", "efficient", "front-end", "distributed", "seamless", "extensible", "turn-key", "world-class", 
        "open-source", "cross-platform", "cross-media", "synergistic", "bricks-and-clicks", "out-of-the-box", "enterprise", 
        "integrated", "impactful", "wireless", "transparent", "next-generation", "cutting-edge", "user-centric", "visionary", 
        "customized", "ubiquitous", "plug-and-play", "collaborative", "compelling", "holistic", "rich", "edge"
        };

        static string[] array3 = new string[] 
        {
            "synergies", "web-readiness", "paradigms", "markets", "partnerships", "infrastructures", "platforms", 
                "initiatives", "channels", "eyeballs", "communities", "ROI", "solutions", "e-tailers", "e-services", "action-items", 
                "portals", "niches", "technologies", "content", "vortals", "supply-chains", "convergence", "relationships", 
                "architectures", "interfaces", "e-markets", "e-commerce", "systems", "bandwidth", "infomediaries", "models", 
                "mindshare", "deliverables", "users", "schemas", "networks", "applications", "metrics", "e-business", "functionalities", 
                "experiences", "web services", "methodologies", "business-value", "micro-services"
        };

        static RandomWords()
        {
            Init();
        }
        static void Init()
        {
            //index2 = Math.Round((decimal)(new Random().NextDouble() * max2))).;
            index1 = new Random().Next(max1);
            index2 = new Random().Next(max2);
            index3 = new Random().Next(max3);
        }

        public static string GetSomeRandomTitle()
        {
            Init();
            return string.Format("{0} {1} {2}", array1[index1], array2[index2], array3[index3]);
        }

        public static string GetSomeRandomDescription()
        {
            Init();
            return string.Format("{0} {1} {2}", array1[index1], array2[index2], array3[index3]);
        }

        public static string GetSomeRandomText()
        {
            Init();
            return string.Format("{0} {1} {2}", array1[index1], array2[index2], array3[index3]);

        }
    }
}