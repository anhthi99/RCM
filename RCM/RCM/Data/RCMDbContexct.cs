using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RCM.Models;

namespace RCM.Data
{
    public class RCMDbContext : DbContext
    {
        private readonly DbContextOptions<RCMDbContext> options;

        #region コンストラクタ
        
        public RCMDbContext(DbContextOptions<RCMDbContext> options) : base (options)
        {
            this.options = options;
        }
        #endregion

        #region プロパ地
        /// <summary>
        /// オペレーター
        /// </summary>
        public DbSet<Operator> Operators { get; set; }
        /// <summary>
        /// 役割
        /// </summary>
        public DbSet<Role> Roles { get; set; }
        #endregion


    }
}
