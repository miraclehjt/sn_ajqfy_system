//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int ID { get; set; }
        public Nullable<byte> UserType { get; set; }
        public string RealName { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string UserPic { get; set; }
        public string Dept { get; set; }
        public Nullable<bool> IsTLeader { get; set; }
        public Nullable<bool> IsYLeader { get; set; }
        public Nullable<bool> IsComment { get; set; }
        public string Job { get; set; }
        public Nullable<int> DeptOrder { get; set; }
        public Nullable<int> UserOrder { get; set; }
        public Nullable<bool> LockUser { get; set; }
        public string UserIntroduce { get; set; }
    }
}
