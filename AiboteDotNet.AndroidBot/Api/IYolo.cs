using AiboteDotNet.AndroidBot.DataModel;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiboteDotNet.AndroidBot.Api
{
    public interface IYolo
    {
        public Task<bool> initYolo(string yoloServerIp, string modelPath);

        public Task<List<PositionConnent>> yolo(double scale = 1);

    }
}
