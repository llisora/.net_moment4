namespace AlbumApi.Models {
    public class Song {
        //Properties
        public int? SongId {get; set;}
        public string? Artist {get; set;}
        public string? Title {get; set;}
        public int? Length {get; set;}
        public string? Category {get; set;}
        public int? AlbumId {get; set;}
        public Album? Album {get; set;}
        

    }

    public class Album {
        public int? AlbumId {get; set;}
        public string? Name {get; set;}

    }
}