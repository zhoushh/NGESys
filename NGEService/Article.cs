//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NGEService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Article
    {
        public string articleID { get; set; }
        public System.DateTime aPubDate { get; set; }
        public string author { get; set; }
        public string department { get; set; }
        public int aStatus { get; set; }
        public string aPath { get; set; }
        public string onLayout { get; set; }
    
        public virtual Layout Layout { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
