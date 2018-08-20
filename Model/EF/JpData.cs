namespace Model.EF
{
    using System.Data.Entity;

    public partial class JpData : DbContext
    {
        public JpData()
            : base("name=JpData")
        {
        }

        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<GrammarNihongo> GrammarNihongoes { get; set; }
        public virtual DbSet<Group動詞> Group動詞 { get; set; }
        public virtual DbSet<Group形容詞> Group形容詞 { get; set; }
        public virtual DbSet<N5動詞_Table> N5動詞_Table { get; set; }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<かなとはく> かなとはく { get; set; }
        public virtual DbSet<グループ_Table> グループ_Table { get; set; }
        public virtual DbSet<会話_Table> 会話_Table { get; set; }
        public virtual DbSet<例文_Table> 例文_Table { get; set; }
        public virtual DbSet<問題_Table> 問題_Table { get; set; }
        public virtual DbSet<形容詞> 形容詞 { get; set; }
        public virtual DbSet<文型_Table> 文型_Table { get; set; }
        public virtual DbSet<漢字___Table> 漢字___Table { get; set; }
        public virtual DbSet<第課_Table> 第課_Table { get; set; }
        public virtual DbSet<練習A_Table> 練習A_Table { get; set; }
        public virtual DbSet<練習Ｂ_Table> 練習Ｂ_Table { get; set; }
        public virtual DbSet<練習C_Table> 練習C_Table { get; set; }
        public virtual DbSet<言葉Plus_Table> 言葉Plus_Table { get; set; }
        public virtual DbSet<言葉_Table> 言葉_Table { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrator>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Administrator>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Administrator>()
                .Property(e => e.CreadtedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Administrator>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Group形容詞>()
                .HasOptional(e => e.形容詞)
                .WithRequired(e => e.Group形容詞1);

            modelBuilder.Entity<User>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CreadtedBy)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<第課_Table>()
                .HasMany(e => e.文型_Table)
                .WithRequired(e => e.第課_Table)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<第課_Table>()
                .HasMany(e => e.練習Ｂ_Table)
                .WithRequired(e => e.第課_Table)
                .WillCascadeOnDelete(false);
        }
    }
}