//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Data.Entity.Infrastructure.MappingViews;

[assembly: DbMappingViewCacheTypeAttribute(
    typeof(Konoha.DataModel.KonohaContext),
    typeof(Edm_EntityMappingGeneratedViews.ViewsForBaseEntitySetsf47ebf8e38333c0f8eba811a5bb90f3a70ee323747ce5f41a08aea220a4f55b9))]

namespace Edm_EntityMappingGeneratedViews
{
    using System;
    using System.CodeDom.Compiler;
    using System.Data.Entity.Core.Metadata.Edm;

    /// <summary>
    /// Implements a mapping view cache.
    /// </summary>
    [GeneratedCode("Entity Framework Power Tools", "0.9.0.0")]
    internal sealed class ViewsForBaseEntitySetsf47ebf8e38333c0f8eba811a5bb90f3a70ee323747ce5f41a08aea220a4f55b9 : DbMappingViewCache
    {
        /// <summary>
        /// Gets a hash value computed over the mapping closure.
        /// </summary>
        public override string MappingHashValue
        {
            get { return "f47ebf8e38333c0f8eba811a5bb90f3a70ee323747ce5f41a08aea220a4f55b9"; }
        }

        /// <summary>
        /// Gets a view corresponding to the specified extent.
        /// </summary>
        /// <param name="extent">The extent.</param>
        /// <returns>The mapping view, or null if the extent is not associated with a mapping view.</returns>
        public override DbMappingView GetView(EntitySetBase extent)
        {
            if (extent == null)
            {
                throw new ArgumentNullException("extent");
            }

            var extentName = extent.EntityContainer.Name + "." + extent.Name;

            if (extentName == "CodeFirstDatabase.Clan")
            {
                return GetView0();
            }

            if (extentName == "CodeFirstDatabase.Justu")
            {
                return GetView1();
            }

            if (extentName == "CodeFirstDatabase.Shinobi")
            {
                return GetView2();
            }

            if (extentName == "KonohaContext.Clans")
            {
                return GetView3();
            }

            if (extentName == "KonohaContext.Justus")
            {
                return GetView4();
            }

            if (extentName == "KonohaContext.Justu_Shinobi")
            {
                return GetView5();
            }

            if (extentName == "KonohaContext.Shinobis")
            {
                return GetView6();
            }

            return null;
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.Clan.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView0()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Clan
        [CodeFirstDatabaseSchema.Clan](T1.Clan_Id, T1.Clan_ClanName)
    FROM (
        SELECT 
            T.Id AS Clan_Id, 
            T.ClanName AS Clan_ClanName, 
            True AS _from0
        FROM KonohaContext.Clans AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.Justu.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView1()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Justu
        [CodeFirstDatabaseSchema.Justu](T3.Justu_Id, T3.Justu_Name, T3.[Justu.Shinobi_Id])
    FROM (
        SELECT T1.Justu_Id, T1.Justu_Name, T2.[Justu.Shinobi_Id], T1._from0, (T2._from1 AND T2._from1 IS NOT NULL) AS _from1
        FROM  (
            SELECT 
                T.Id AS Justu_Id, 
                T.Name AS Justu_Name, 
                True AS _from0
            FROM KonohaContext.Justus AS T) AS T1
            LEFT OUTER JOIN (
            SELECT 
                Key(T.Justu_Shinobi_Source).Id AS Justu_Id, 
                Key(T.Justu_Shinobi_Target).Id AS [Justu.Shinobi_Id], 
                True AS _from1
            FROM KonohaContext.Justu_Shinobi AS T) AS T2
            ON T1.Justu_Id = T2.Justu_Id
    ) AS T3");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.Shinobi.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView2()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Shinobi
        [CodeFirstDatabaseSchema.Shinobi](T1.Shinobi_Id, T1.Shinobi_Name, T1.Shinobi_IsKonohaShinobi, T1.Shinobi_ClanId)
    FROM (
        SELECT 
            T.Id AS Shinobi_Id, 
            T.Name AS Shinobi_Name, 
            T.IsKonohaShinobi AS Shinobi_IsKonohaShinobi, 
            T.ClanId AS Shinobi_ClanId, 
            True AS _from0
        FROM KonohaContext.Shinobis AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for KonohaContext.Clans.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView3()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Clans
        [Konoha.DataModel.Clan](T1.Clan_Id, T1.Clan_ClanName)
    FROM (
        SELECT 
            T.Id AS Clan_Id, 
            T.ClanName AS Clan_ClanName, 
            True AS _from0
        FROM CodeFirstDatabase.Clan AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for KonohaContext.Justus.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView4()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Justus
        [Konoha.DataModel.Justu](T1.Justu_Id, T1.Justu_Name) WITH 
        RELATIONSHIP(CREATEREF(KonohaContext.Shinobis, ROW(T1.[Justu_Shinobi.Justu_Shinobi_Target.Id]),[Konoha.DataModel.Shinobi]),[Konoha.DataModel.Justu_Shinobi],Justu_Shinobi_Source,Justu_Shinobi_Target) 
    FROM (
        SELECT 
            T.Id AS Justu_Id, 
            T.Name AS Justu_Name, 
            True AS _from0, 
            T.Shinobi_Id AS [Justu_Shinobi.Justu_Shinobi_Target.Id]
        FROM CodeFirstDatabase.Justu AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for KonohaContext.Justu_Shinobi.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView5()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Justu_Shinobi
        [Konoha.DataModel.Justu_Shinobi](T3.[Justu_Shinobi.Justu_Shinobi_Source], T3.[Justu_Shinobi.Justu_Shinobi_Target])
    FROM (
        SELECT -- Constructing Justu_Shinobi_Source
            CreateRef(KonohaContext.Justus, row(T2.[Justu_Shinobi.Justu_Shinobi_Source.Id]), [Konoha.DataModel.Justu]) AS [Justu_Shinobi.Justu_Shinobi_Source], 
            T2.[Justu_Shinobi.Justu_Shinobi_Target]
        FROM (
            SELECT -- Constructing Justu_Shinobi_Target
                T1.[Justu_Shinobi.Justu_Shinobi_Source.Id], 
                CreateRef(KonohaContext.Shinobis, row(T1.[Justu_Shinobi.Justu_Shinobi_Target.Id]), [Konoha.DataModel.Shinobi]) AS [Justu_Shinobi.Justu_Shinobi_Target]
            FROM (
                SELECT 
                    T.Id AS [Justu_Shinobi.Justu_Shinobi_Source.Id], 
                    T.Shinobi_Id AS [Justu_Shinobi.Justu_Shinobi_Target.Id], 
                    True AS _from0
                FROM CodeFirstDatabase.Justu AS T
                WHERE T.Shinobi_Id IS NOT NULL
            ) AS T1
        ) AS T2
    ) AS T3");
        }

        /// <summary>
        /// Gets the view for KonohaContext.Shinobis.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView6()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Shinobis
        [Konoha.DataModel.Shinobi](T1.Shinobi_Id, T1.Shinobi_Name, T1.Shinobi_IsKonohaShinobi, T1.Shinobi_ClanId)
    FROM (
        SELECT 
            T.Id AS Shinobi_Id, 
            T.Name AS Shinobi_Name, 
            T.IsKonohaShinobi AS Shinobi_IsKonohaShinobi, 
            T.ClanId AS Shinobi_ClanId, 
            True AS _from0
        FROM CodeFirstDatabase.Shinobi AS T
    ) AS T1");
        }
    }
}