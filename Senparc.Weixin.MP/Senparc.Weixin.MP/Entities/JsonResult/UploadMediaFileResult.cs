﻿/*----------------------------------------------------------------
    Copyright (C) 2015 Senparc
    
    文件名：UploadMediaFileResult.cs
    文件功能描述：上传媒体文件返回结果
    
    
    创建标识：Senparc - 20150211
    
    修改标识：Senparc - 20150303
    修改描述：整理接口
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Weixin.MP.Entities
{
    /// <summary>
    /// 上传媒体文件返回结果
    /// </summary>
    public class UploadMediaFileResult
    {
        public UploadMediaFileType type { get; set; }
        public string media_id { get; set; }
        public long created_at { get; set; }
    }
}
