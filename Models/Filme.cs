namespace CatalogoFilmes.Models;

public class Filme{

    public long Id {get; set;}
    public string? Name {get; set;}
    public int? rating {get; set;}
    public string? Director {get; set;}
    public string[] Actors {get; set;}

}