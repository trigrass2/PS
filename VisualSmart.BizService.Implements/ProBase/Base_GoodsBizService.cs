﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualSmart.BizService.Implements.Base;
using VisualSmart.BizService.ProBase;
using VisualSmart.Dao.DataQuickStart.ProBase;
using VisualSmart.Domain.ProBase;
using VisualSmart.Util;

namespace VisualSmart.BizService.Implements.ProBase
{
    public class Base_GoodsBizService : EntityBizService<Base_Goods, Base_GoodsDao>, IBase_GoodsBizService
    {
        /// <summary>
        /// 获取ID
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public int GetId(QueryCondition query)
        {
            return EntityDao.GetId(query);
        }

        /// <summary>
        /// 获取信息列表
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public IList<string> GetGoodName(QueryCondition query)
        {
            return EntityDao.GetGoodName(query);
        }

        /// <summary>
        /// 获取信息列表
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public List<Base_Goods> GetBomName(string parentNo, string sonNo)
        {
            return EntityDao.GetBomName(parentNo, sonNo);
        }


    }
}
