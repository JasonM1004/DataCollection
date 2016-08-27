using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class PastDetailsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string accountId { get; set; }

        /// <summary>
        /// 福建省 福州市
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string cancelDesc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string duobaoUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string headImg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string leftSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string luckyNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string luckyTime { get; set; }

        /// <summary>
        /// 德国马牌轮胎
        /// </summary>
        public string nickName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string participantUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int participateNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string periodId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string productInfoUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int totalTimes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string userId { get; set; }
    }

    public class DuoBao
    {
        /// <summary>
        /// 
        /// </summary>
        public int pageNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int pageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<PastDetailsItem> pastDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int result { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        public string resultDesc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int totalPageCount { get; set; }
    }
}