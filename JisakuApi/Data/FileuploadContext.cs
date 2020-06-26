using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JisakuApi.Models;

    public class FileuploadContext : DbContext
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="options">データベースコンテキストオプション</param>        
        public FileuploadContext (DbContextOptions<FileuploadContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// FileUploadテーブル
        /// </summary>
        /// <value></value>
        public DbSet<JisakuApi.Models.FileUpload> FileUpload { get; set; }

                /// <summary>
        /// モデルを構成する
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FileUpload>(entity =>
            {
                entity.HasKey(e => new { e.Id })
                    .HasName("PK_FileUpload");

                entity.ToTable("FileUpload");

                entity.Property(e => e.Id).IsRequired();

                entity.Property(e => e.ApprovalNo).HasMaxLength(6);

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.FileData);

                entity.Property(e => e.ModifiedDate);

            });
        }
    }
