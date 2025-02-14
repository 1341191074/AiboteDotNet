# AiboteDotNet
Aibote是江西爱伯特科技自主研发的一款纯代码RPA办公自动化框架，支持Android、Browser和Windows 三大平台。框架免费、API和接口协议开源，个人、企业商用零费用 以socket tcp接口协议通信方式命令驱动，支持任何一门计算机语言调用。

By Reach(QQ:1341191074) Aibote4DotNet交流Q群：684404665

Aibote能力：
        1、AndroidBot，底层自主研发，支持安卓原生APP和H5界面元素和图色定位。元素元素定位速度是Appium框架的的10倍，2340*1080 图色定位仅需要50毫秒！
        2、WindowsBot，底层自主研发，支持Windows应用、.NET、WinForm、WPF、QT、JAVA(Swing和AWT等GUI库)和Electron 等语言开发的窗口界面元素和图色定位，独家xpath算法 简洁急速，
        元素/图色定位速度分别是可视化RPA的3倍和20倍！
        3、WebBot，底层自主研发，支持chromium内核的所有浏览器和应用。C/C++语言基于浏览器内核协议研发而成的一款web自动化框架。速度是selenium 10倍！
        4、Android远程投屏，底层自主研发，可在一台电脑监控观察多台安卓RPA机器人运行状态并批量管理操作
        5、自建OCR服务器，支持文字识别和定位，免费且不限制使用次数！
        6、自研AiboteScriptUI界面开发工具，提供人机交互功能，打包exe发布机器人可以在离线环境运行！


使用参考：
``` C#
    public class AndroidBotHandler : TcpConnectionHandler
    {
        static readonly NLog.Logger LOGGER = NLog.LogManager.GetCurrentClassLogger();
        public override BotOptions CurBotOptions { get; set; } = BotOptions.AndroidBot;

        protected override async Task OnRun(TcpChannel channel, Session session)
        {
            IAndroidBot androidBot = new AndroidBot(channel);
            await Task.Delay(1000);
            await androidBot.InitOcr("192.168.2.105", 9527);
            await Task.Delay(1000);
            await androidBot.StartWeChatApp();
            await Task.Delay(3000);
            //滑动
        }
    }
```

原框架地址：https://github.com/mainxx/AiboteDotNet