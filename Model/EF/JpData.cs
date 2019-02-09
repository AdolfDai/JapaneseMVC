namespace Model.EF
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

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
		public virtual DbSet<N5動詞> N5動詞 { get; set; }
		public virtual DbSet<User> Users { get; set; }
		public virtual DbSet<かなとはく> かなとはく { get; set; }
		public virtual DbSet<グループ> グループ { get; set; }
		public virtual DbSet<会話> 会話 { get; set; }
		public virtual DbSet<例文> 例文 { get; set; }
		public virtual DbSet<問題> 問題 { get; set; }
		public virtual DbSet<問題の答えTable> 問題の答えTable { get; set; }
		public virtual DbSet<文型> 文型 { get; set; }
		public virtual DbSet<漢字> 漢字 { get; set; }
		public virtual DbSet<第課> 第課 { get; set; }
		public virtual DbSet<練習A> 練習A { get; set; }
		public virtual DbSet<練習B> 練習B { get; set; }
		public virtual DbSet<練習C> 練習C { get; set; }
		public virtual DbSet<言葉PlusTable> 言葉PlusTable { get; set; }
		public virtual DbSet<言葉Table> 言葉Table { get; set; }
		public virtual DbSet<形容詞> 形容詞 { get; set; }

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

			modelBuilder.Entity<第課>()
				.HasMany(e => e.文型)
				.WithRequired(e => e.第課)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<第課>()
				.HasMany(e => e.練習B)
				.WithRequired(e => e.第課)
				.WillCascadeOnDelete(false);
		}
	}
}
