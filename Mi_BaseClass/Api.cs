using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Mi_MCAriaPlus._8Mi_BaseClass
{
    public class Api
    {

        public static Api api = new Api();
        public static Api CreateInstance()
        {
            return api;
        }
        public string[] projectGroup =
        {
            "PG-Via",
            "PG-Vle",
            "PG-AuthMe",
            "PG-BentoBoxWorld",
            "PG-ProtocolLib",
            "P-LuckPerms",
            "P-PlotSquared",
            "P-FastAsyncWorldEdit",
            "S-Mohist",
            "S-Paper",
            "S-BungeeCord",
            "S-Waterfall",
            "S-Travertine",
            "SG-OneKeyDownload",
        };
        public String[] projectHtml = {
            // "PG-Via",0
            "https://ci.viaversion.com/api/json",
            // "PG-Vle",1
            "",
            //"PG-AuthMe",2
            "https://ci.codemc.org/job/AuthMe/api/json",
            //"PG-BentoBoxWorld",3
            "https://ci.codemc.org/job/BentoBoxWorld/api/json",
            //"PG-ProtocolLib",which is string sqeu,4
            "ProtocolLib-Server-1.7.10;ProtocolLib-Latest",
            //"P-LuckPerms",5
            "https://ci.lucko.me/job/LuckPerms/lastSuccessfulBuild/api/json",
            
            //"P-PlotSquared",6
            /*
            https://ci.athion.net/job/PlotSquared-Legacy/lastSuccessfulBuild/api/json
            https://ci.athion.net/job/PlotSquared-Releases/api/json
            */
            "",
            //"P-FastAsyncWorldEdit",7
            /*
            https://ci.athion.net/job/FastAsyncWorldEdit/
            https://ci.athion.net/job/FastAsyncWorldEdit-1.15/
            */
            "",
            //"S-Mohist",8
            "https://ci.codemc.io/job/Mohist-Community/api/json",
            //"S-Paper",9
            "https://papermc.io/api/v1/paper/",
            //"S-BungeeCord",10
            "https://ci.md-5.net/job/BungeeCord/lastSuccessfulBuild/api/json",
            //"S-Waterfall",11
            "https://papermc.io/ci/job/Waterfall/lastSuccessfulBuild/api/json",
            //"S-Travertine",12
            "https://papermc.io/ci/job/Travertine/lastSuccessfulBuild/api/json",
            //"SG-OneKeyDownload",13
            "BungeeCord;Waterfall;Travertine;Paper-1.12;Paper-1.13;Paper-1.14"
        };
    }
}
