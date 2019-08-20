using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ML;

namespace PlayingWithBlazor.Models
{
    public class SimpsonsOutput
    {
        public class ImageNetPrediction
        {
            public float[] PredictedLabels;
        }
    }
}