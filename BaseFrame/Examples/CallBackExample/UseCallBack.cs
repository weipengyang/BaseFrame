using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrame.Examples.CallBackExample
{
    public class UseCallBack
    {
        private string rtnInfo = "";
        private string errCode = "";
        private string errMsg = "";

        public UseCallBack()
        {
            IDCARD_RTNINFO_CALLBACK rtnInfo = ReturnIDInfo;
            CallBackExample example = new CallBackExample();
            example.InsertIdCard(60, rtnInfo);
        }

        private void ReturnIDInfo(string info, ReturnMsg returnMsg)
        {
            rtnInfo = info;
            errCode = returnMsg.RtnCode;
            errMsg = returnMsg.RtnMsg;
        }
    }
}
