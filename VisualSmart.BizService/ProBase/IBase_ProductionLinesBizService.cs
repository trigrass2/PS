﻿using System.Collections.Generic;
using VisualSmart.BizService.Base;
using VisualSmart.Domain.ProBase;
using VisualSmart.Util;

namespace VisualSmart.BizService.ProBase
{
    public interface IBase_ProductionLinesBizService : IEntityBizService<Base_ProductionLines>
    {
        /// <summary>
        /// 根据产线 和 商品获取对应的产能信息
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        IList<Base_ProductionLines> GetAllDomainByLineNoAndGoodNos(QueryCondition query);
    }
}
