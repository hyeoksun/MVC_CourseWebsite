//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Log_Table
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string IPAdress { get; set; }
        public int ProcessID { get; set; }
        public int ProcessType { get; set; }
        public string ProcessCategoryType { get; set; }
        public System.DateTime ProcessDate { get; set; }
    
        public virtual ProcessType ProcessType1 { get; set; }
        public virtual T_User T_User { get; set; }
    }
}
