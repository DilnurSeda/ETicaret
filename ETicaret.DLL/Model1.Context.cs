﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ETicaret.DLL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ETicaretDBEntities : DbContext
    {
        public ETicaretDBEntities()
            : base("name=ETicaretDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bankalar> Bankalar { get; set; }
        public virtual DbSet<BegenilenUrunler> BegenilenUrunler { get; set; }
        public virtual DbSet<Duyurular> Duyurular { get; set; }
        public virtual DbSet<Faturalar> Faturalar { get; set; }
        public virtual DbSet<indirimTurleri> indirimTurleri { get; set; }
        public virtual DbSet<Kampanyalar> Kampanyalar { get; set; }
        public virtual DbSet<KargoFirmalari> KargoFirmalari { get; set; }
        public virtual DbSet<Kargolar> Kargolar { get; set; }
        public virtual DbSet<Kategoriler> Kategoriler { get; set; }
        public virtual DbSet<Markalar> Markalar { get; set; }
        public virtual DbSet<OlcuBirimleri> OlcuBirimleri { get; set; }
        public virtual DbSet<Personeller> Personeller { get; set; }
        public virtual DbSet<PersonelRolleri> PersonelRolleri { get; set; }
        public virtual DbSet<Reklamlar> Reklamlar { get; set; }
        public virtual DbSet<Sepet> Sepet { get; set; }
        public virtual DbSet<SepetDetay> SepetDetay { get; set; }
        public virtual DbSet<SiparisDetaylari> SiparisDetaylari { get; set; }
        public virtual DbSet<Siparisler> Siparisler { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<UrunDuyurulari> UrunDuyurulari { get; set; }
        public virtual DbSet<Urunler> Urunler { get; set; }
        public virtual DbSet<UrunOzellikleri> UrunOzellikleri { get; set; }
        public virtual DbSet<UrunResimleri> UrunResimleri { get; set; }
        public virtual DbSet<UyeAdresleri> UyeAdresleri { get; set; }
        public virtual DbSet<Uyeler> Uyeler { get; set; }
        public virtual DbSet<Yorumlar> Yorumlar { get; set; }
    }
}
