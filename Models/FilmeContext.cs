using Microsoft.EntityFrameworkCore;
using System;

namespace CatalogoFilmes.Models;

public class FilmeContext: DbContext{

    public string DbPath {get;}
    
    public FilmeContext(DbContextOptions<FilmeContext> options)
    :base(options)
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "blogging.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    public DbSet<Filme> Filmes {get; set;} = null!;
}