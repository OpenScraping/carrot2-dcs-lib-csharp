using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenScraping.Carrot2Dcs
{
    public class DcsSettings
    {
        public DcsSettings()
        {
            this.Algorithm = DcsAlgorithm.Lingo;
            this.OutputFormat = DcsOutputFormat.Xml;
            this.ClustersOnly = false;
        }

        public string Source { get; set; } // dcs.source

        public string Query { get; set; } // query

        public int? Results { get; set; } // results

        public string Stream { get; set; } // dcs.c2stream

        public string Algorithm { get; set; } // dcs.algorithm

        public string OutputFormat { get; set; } // dcs.output.format

        public bool ClustersOnly { get; set; } // dcs.clusters.only

        public string JsonCallback { get; set; } // dcs.json.callback

        public string DefaultLanguage { get; set; } // MultilingualClustering.defaultLanguage
    }
}
