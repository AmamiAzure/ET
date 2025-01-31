﻿using System;
using System.Collections.Generic;

namespace ET
{
    /// <summary>
    /// Config组件会扫描所有的有ConfigAttribute标签的配置,加载进来
    /// </summary>
    [ComponentOf(typeof(Scene))]
    public class ConfigComponent : Entity, IAwake, IDestroy
    {
        public static ConfigComponent Instance;

        public cfg.Tables AllConfigTables;
    }
}