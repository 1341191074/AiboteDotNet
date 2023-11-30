using AiboteDotNet.AndroidBot.Api;
using AiboteDotNet.AndroidBot.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace AiboteDotNet.AndroidBot
{
    public partial class AndroidBot : IYolo
    {
        public Task<bool> initYolo(string yoloServerIp, string modelPath)
        {
            return _AndroidBotCore.initYolo(yoloServerIp, modelPath);
        }
        public Task<List<PositionConnent>> yolo(double scale = 1)
        {
            return _AndroidBotCore.yolo(scale);
        }


    }
}
