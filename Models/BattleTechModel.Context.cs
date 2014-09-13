﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BattleTech.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BattleTechEntities : DbContext
    {
        public BattleTechEntities()
            : base("name=BattleTechEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BattleMech> BattleMechs { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<MechClass> MechClasses { get; set; }
        public virtual DbSet<MyArmy> MyArmies { get; set; }
        public virtual DbSet<SuccessorState> SuccessorStates { get; set; }
    
        public virtual ObjectResult<Nullable<int>> sp_MechsCount()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_MechsCount");
        }
    
        public virtual ObjectResult<sp_TableStatistics_Result> sp_TableStatistics()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_TableStatistics_Result>("sp_TableStatistics");
        }
    }
}