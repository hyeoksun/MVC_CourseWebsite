﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class POSTDATAEntities : DbContext
    {
        public POSTDATAEntities()
            : base("name=POSTDATAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Ad> Ads { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<FavLogoTitle> FavLogoTitles { get; set; }
        public DbSet<Log_Table> Log_Table { get; set; }
        public DbSet<Meta> Metas { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostImage> PostImages { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<ProcessType> ProcessTypes { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<T_User> T_User { get; set; }
        public DbSet<Video> Videos { get; set; }
    }
}
