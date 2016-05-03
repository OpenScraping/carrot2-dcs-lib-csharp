using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenScraping.Carrot2Dcs
{
    public static class DcsAlgorithm
    {
        public static string Lingo = "lingo"; // Lingo Clustering
        public static string SuffixTree = "stc"; // Suffix Tree Clustering
        public static string KMeans = "kmeans"; // Bisecting k-means
        public static string Url = "url"; // By URL Clustering
        public static string Source = "source"; // By Source Clustering
    }
}
