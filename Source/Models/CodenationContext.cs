using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.Infrastructure;


namespace Codenation.Challenge.Models
{
	public class CodenationContext : DbContext
	{
		public DbSet<Company> Companies { get;set;}
		public DbSet<User> Users { get; set;}
		public DbSet<Candidate> Candidates { get;set;}
		public DbSet<Submission> Submissions { get;set;}
		public DbSet<Acceleration> Accelerations { get;set;}
		public DbSet<Challenge> Challenges { get;set;}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Codenation;Trusted_Connection=True");

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Company>()
					.ToTable("company");

			modelBuilder.Entity<Company>()
					.HasKey(c => c.id);

			modelBuilder.Entity<Company>()
					.Property(c => c.id)
					.IsRequired()
					.HasColumnType("int")
					.ValueGeneratedOnAdd()
					.HasColumnName("id");

			modelBuilder.Entity<Company>()
					.Property(c => c.name)
					.HasMaxLength(100)
					.IsRequired()
					.HasColumnType("varchar")
					.HasColumnName("name");

			modelBuilder.Entity<Company>()
					.Property(c => c.slug)
					.HasMaxLength(50)
					.IsRequired()
					.HasColumnType("varchar")
					.HasColumnName("slug");

			modelBuilder.Entity<Company>()
					.Property(c => c.created_at)
					.IsRequired()
					.HasColumnType("timestamp")
					.HasColumnName("created_at");


			modelBuilder.Entity<Candidate>()
					.ToTable("candidate");

			modelBuilder.Entity<Candidate>()
					.HasKey(c => new { c.user_id, c.company_id, c.acceleration_id });

			modelBuilder.Entity<Candidate>()
					.HasOne(c => c.user)
					.WithMany(u => u.candidate)
					.HasForeignKey(c => c.user_id)
					.IsRequired();

			modelBuilder.Entity<Candidate>()
					.HasOne(c => c.acceleration)
					.WithMany(a => a.candidate)
					.HasForeignKey(c => c.acceleration_id)
					.IsRequired();

			modelBuilder.Entity<Candidate>()
					.HasOne(c => c.company)
					.WithMany(c => c.candidate)
					.HasForeignKey(c => c.company_id)
					.IsRequired();

			modelBuilder.Entity<Candidate>()
					.Property(c => c.user_id)
					.IsRequired()
					.HasColumnType("int")
					.HasColumnName("user_id");

			modelBuilder.Entity<Candidate>()
					.Property(c => c.company_id)
					.IsRequired()
					.HasColumnType("int")
					.HasColumnName("company_id");

			modelBuilder.Entity<Candidate>()
					.Property(c => c.acceleration_id)
					.IsRequired()
					.HasColumnType("int")
					.HasColumnName("acceleration_id");

			modelBuilder.Entity<Candidate>()
					.Property(c => c.status)
					.IsRequired()
					.HasColumnType("int")
					.HasColumnName("status");

			modelBuilder.Entity<Candidate>()
					.Property(c => c.created_at)
					.IsRequired()
					.HasColumnType("timestamp")
					.HasColumnName("created_at");


			modelBuilder.Entity<User>()
					.ToTable("user");

			modelBuilder.Entity<User>()
					.HasKey(u => u.id);

			modelBuilder.Entity<User>()
					.Property(u => u.id)
					.IsRequired()
					.HasColumnType("int")
					.ValueGeneratedOnAdd()
					.HasColumnName("id");

			modelBuilder.Entity<User>()
					.Property(u => u.full_name)
					.IsRequired()
					.HasMaxLength(100)
					.HasColumnType("varchar")
					.HasColumnName("full_name");

			modelBuilder.Entity<User>()
					.Property(u => u.email)
					.IsRequired()
					.HasMaxLength(100)
					.HasColumnType("varchar")
					.HasColumnName("email");

			modelBuilder.Entity<User>()
					.Property(u => u.nickName)
					.IsRequired()
					.HasMaxLength(50)
					.HasColumnType("varchar")
					.HasColumnName("nickname");

			modelBuilder.Entity<User>()
					.Property(u => u.password)
					.IsRequired()
					.HasMaxLength(255)
					.HasColumnType("varchar")
					.HasColumnName("password");

			modelBuilder.Entity<User>()
					.Property(u => u.created_at)
					.IsRequired()
					.HasColumnType("timestamp")
					.HasColumnName("created_at");

			
			modelBuilder.Entity<Submission>()
					.ToTable("submission");

			modelBuilder.Entity<Submission>()
					.HasKey(s => new { s.challenge_id, s.user_id });

			modelBuilder.Entity<Submission>()
					.HasOne(s => s.user)
					.WithMany(u => u.submission)
					.HasForeignKey(s => s.user_id)
					.IsRequired();

			modelBuilder.Entity<Submission>()
					.HasOne(s => s.challenge)
					.WithMany(c => c.submission)
					.HasForeignKey(s => s.challenge_id)
					.IsRequired();

			modelBuilder.Entity<Submission>()
					.Property(s => s.user_id)
					.IsRequired()
					.HasColumnType("int")
					.HasColumnName("user_id");

			modelBuilder.Entity<Submission>()
					.Property(s => s.challenge_id)
					.IsRequired()
					.HasColumnType("int")
					.HasColumnName("challenge_id");

			modelBuilder.Entity<Submission>()
					.Property(s => s.score)
					.IsRequired()
					.HasColumnType("float(9,2)")
					.HasColumnName("score");

			modelBuilder.Entity<Submission>()
					.Property(s => s.created_at)
					.IsRequired()
					.HasColumnType("timestamp")
					.HasColumnName("created_at");

			
			modelBuilder.Entity<Acceleration>()
					.ToTable("acceleration");

			modelBuilder.Entity<Acceleration>()
					.HasKey(a => a.id);

			modelBuilder.Entity<Acceleration>()
					.HasOne(a => a.challenge)
					.WithMany(c => c.acceleration)
					.HasForeignKey(a => a.challenge_id)
					.IsRequired();

			modelBuilder.Entity<Acceleration>()
					.Property(a => a.id)
					.HasColumnType("int")
					.IsRequired()
					.ValueGeneratedOnAdd()
					.HasColumnName("id");

			modelBuilder.Entity<Acceleration>()
					.Property(a => a.challenge_id)
					.IsRequired()
					.HasColumnType("int")
					.HasColumnName("challenge_id");

			modelBuilder.Entity<Acceleration>()
					.Property(a => a.name)
					.IsRequired()
					.HasMaxLength(100)
					.HasColumnType("varchar")
					.HasColumnName("name");

			modelBuilder.Entity<Acceleration>()
					.Property(a => a.slug)
					.IsRequired()
					.HasMaxLength(50)
					.HasColumnType("varchar")
					.HasColumnName("slug");

			modelBuilder.Entity<Acceleration>()
					.Property(a => a.created_at)
					.IsRequired()
					.HasColumnType("timestamp")
					.HasColumnName("created_at");


			modelBuilder.Entity<Challenge>()
					.ToTable("challenge");

			modelBuilder.Entity<Challenge>()
					.HasKey(c => c.id);

			modelBuilder.Entity<Challenge>()
					.Property(c => c.id)
					.HasColumnType("int")
					.IsRequired()
					.ValueGeneratedOnAdd()
					.HasColumnName("id");

			modelBuilder.Entity<Challenge>()
					.Property(c => c.name)
					.IsRequired()
					.HasMaxLength(100)
					.HasColumnType("varchar")
					.HasColumnName("name");

			modelBuilder.Entity<Challenge>()
					.Property(c => c.slug)
					.IsRequired()
					.HasMaxLength(50)
					.HasColumnType("varchar")
					.HasColumnName("slug");

			modelBuilder.Entity<Challenge>()
					.Property(c => c.created_at)
					.IsRequired()
					.HasColumnType("timestamp")
					.HasColumnName("created_at");

		}
	}
}