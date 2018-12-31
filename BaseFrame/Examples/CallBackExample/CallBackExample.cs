using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using BaseFrame.Examples.CallBackExample;

namespace BaseFrame.Examples.CallBackExample
{
    public delegate void IDCARD_RTNINFO_CALLBACK(string info, ReturnMsg returnMsg);

    public class CallBackExample
    {
        private static IDCARD_RTNINFO_CALLBACK localIdCardCallBack; //回调函数

        public void InsertIdCard(int timeOut, IDCARD_RTNINFO_CALLBACK idCardCallback)
        {
            localIdCardCallBack = idCardCallback;
            Thread thread = new Thread(new ThreadStart(StartInsertIdCard));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void StartInsertIdCard()
        {
            ReturnMsg rtnMsg = new ReturnMsg();
            rtnMsg.RtnCode = "0000";
            rtnMsg.RtnMsg = "正确";
            localIdCardCallBack(null, rtnMsg);
        }
    }
}
