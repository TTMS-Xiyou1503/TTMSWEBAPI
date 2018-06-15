using System.ComponentModel.DataAnnotations;

namespace TTMSWebAPI.Models
{    
    /// <summary>
    /// 筛选订单模型
    /// </summary>
    public class SelectOrderModel
    {
        /// <summary>
        /// 影厅ID
        /// </summary>
        public int TheaterId { get; set; }
        
        /// <summary>
        /// 用户Id
        /// </summary>
        public int UserId { get; set; }
        
        /// <summary>
        /// 日期
        /// </summary>
        [StringLength(15)]
        public string TradeDate { get; set; }
        
        /// <summary>
        /// 类型
        /// </summary>
        public int Type { get; set; }
        
//        /// <summary>
//        /// 剧目名称
//        /// </summary>
//        [StringLength(50)]
//        public string programmeName { get; set; }
//        
//        /// <summary>
//        /// 影厅名称
//        /// </summary>
//        public string theaterName { get; set; }
//        /// <summary>
//        /// 票价
//        /// </summary>
//        public int price { get; set; }
        
//        /// <summary>
//        /// 座位行数
//        /// </summary>
//        public int rowNumber { get; set; }
//        
//        /// <summary>
//        /// 座位列数
//        /// </summary>
//        public int colNumber { get; set; }
//        /// <summary>
//        /// 用户名
//        /// </summary>
//        public  string userName { get; set; }
    }

    /// <summary>
    /// 分析销售情况API
    /// </summary>
    public class AnalyseOrderModel
    {
        /// <summary>
        /// 影厅ID
        /// </summary>
        public int TheaterId { get; set; }
        
        /// <summary>
        /// 用户Id
        /// </summary>
        public int UserId { get; set; }
        
        /// <summary>
        /// 日期
        /// </summary>
        [StringLength(15)]
        public string TradeDate { get; set; }
        
        /// <summary>
        /// 时间长度
        /// </summary>
        public int DateLength { get; set; }
        
        /// <summary>
        /// 剧目Id
        /// </summary>
        public int ProgrammeId { get; set; } 
    }
}