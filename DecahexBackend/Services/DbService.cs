using DecahexBackend.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace DecahexBackend.Services
{
    public class DbService
    {
        private readonly IMongoCollection<Anime> _animeCollection;
        private readonly IMongoCollection<Announcement> _announcementCollection;
        private readonly IMongoCollection<Download> _downloadCollection;
        private readonly IMongoCollection<Garbage> _garbageCollection;
        private readonly IMongoCollection<GranturismoPost> _granturismoPostCollection;
        private readonly IMongoCollection<GranturismoTune> _granturismoTuneCollection;
        private readonly IMongoCollection<Hentai> _hentaiCollection;
        private readonly IMongoCollection<Misc> _miscCollection;
        private readonly IMongoCollection<Project> _projectCollection;
        private readonly IMongoCollection<Snippet> _snippetCollection;
        private readonly IMongoCollection<User> _userCollection;


        private readonly IConfiguration _configuration;

        public DbService(IOptions<UserStoreDatabaseSettings> userStoreDatabseSettings, IConfiguration config)
        {
            _configuration = config;

         
            var mongoClient = new MongoClient(_configuration["ConnectionString"]);
          
            var mongoDatabase = mongoClient.GetDatabase("decahex");

            _animeCollection = mongoDatabase.GetCollection<Anime>("Anime");
            _announcementCollection = mongoDatabase.GetCollection<Announcement>("Announcements");
            _downloadCollection = mongoDatabase.GetCollection<Download>("Downloads");
            _garbageCollection = mongoDatabase.GetCollection<Garbage>("Garbage");
            _granturismoPostCollection = mongoDatabase.GetCollection<GranturismoPost>("Granturismo");
            _granturismoTuneCollection = mongoDatabase.GetCollection<GranturismoTune>("Tunes");
            _hentaiCollection = mongoDatabase.GetCollection<Hentai>("Hentai");
            _miscCollection = mongoDatabase.GetCollection<Misc>("Misc");
            _projectCollection = mongoDatabase.GetCollection<Project>("Projects");
            _snippetCollection = mongoDatabase.GetCollection<Snippet>("Snippets");
            _userCollection = mongoDatabase.GetCollection<User>("Users");

        }


        //Anime methods
        public async Task<List<Anime>> GetAnimeAsync() => await _animeCollection.Find(_ => true).ToListAsync();

        public async Task<Anime?> GetAnimeAsync(int id) => await _animeCollection.Find(x => x.AnimeId == id).FirstOrDefaultAsync();

        public async Task CreateAnimeAsync(Anime newAnime) => await _animeCollection.InsertOneAsync(newAnime);

        public async Task UpdateAnimeAsync(int id, Anime updatedAnime) => await _animeCollection.ReplaceOneAsync(x => x.AnimeId == id, updatedAnime);

        public async Task RemoveAnimeAsync(int id) => await _animeCollection.DeleteOneAsync(x => x.AnimeId == id);



        //Announcement methods
        public async Task<List<Announcement>> GetAnnouncementAsync() => await _announcementCollection.Find(_ => true).ToListAsync();

        public async Task<Announcement?> GetAnnouncementAsync(int id) => await _announcementCollection.Find(x => x.AnnouncementId == id).FirstOrDefaultAsync();

        public async Task CreateAnnouncementAsync(Announcement newAnnouncement) => await _announcementCollection.InsertOneAsync(newAnnouncement);

        public async Task UpdateAnnouncementAsync(int id, Announcement updatedAnnouncement) => await _announcementCollection.ReplaceOneAsync(x => x.AnnouncementId == id, updatedAnnouncement);

        public async Task RemoveAnnouncementAsync(int id) => await _announcementCollection.DeleteOneAsync(x => x.AnnouncementId == id);



        //Download methods
        public async Task<List<Download>> GetDownloadAsync() => await _downloadCollection.Find(_ => true).ToListAsync();

        public async Task<Download?> GetDownloadAsync(int id) => await _downloadCollection.Find(x => x.DownloadId == id).FirstOrDefaultAsync();

        public async Task CreateDownloadAsync(Download newDownload) => await _downloadCollection.InsertOneAsync(newDownload);

        public async Task UpdateDownloadAsync(int id, Download updatedDownload) => await _downloadCollection.ReplaceOneAsync(x => x.DownloadId == id, updatedDownload);

        public async Task RemoveDownloadAsync(int id) => await _downloadCollection.DeleteOneAsync(x => x.DownloadId == id);



        //Garbage methods
        public async Task<List<Garbage>> GetGarbageAsync() => await _garbageCollection.Find(_ => true).ToListAsync();

        public async Task<Garbage?> GetGarbageAsync(int id) => await _garbageCollection.Find(x => x.GarbageId == id).FirstOrDefaultAsync();

        public async Task CreateGarbageAsync(Garbage newGarbage) => await _garbageCollection.InsertOneAsync(newGarbage);

        public async Task UpdateGarbageAsync(int id, Garbage updatedGarbage) => await _garbageCollection.ReplaceOneAsync(x => x.GarbageId == id, updatedGarbage);

        public async Task RemoveGarbageAsync(int id) => await _garbageCollection.DeleteOneAsync(x => x.GarbageId == id);



        //Gran turismo methods
        public async Task<List<GranturismoPost>> GetGranturismoAsync() => await _granturismoPostCollection.Find(_ => true).ToListAsync();

        public async Task<GranturismoPost?> GetGranturismoAsync(int id) => await _granturismoPostCollection.Find(x => x.GranturismoPostId == id).FirstOrDefaultAsync();

        public async Task CreateGranturismoAsync(GranturismoPost newGranTurismoPost) => await _granturismoPostCollection.InsertOneAsync(newGranTurismoPost);

        public async Task UpdateGranturismoAsync(int id, GranturismoPost updatedGranTurismoPost) => await _granturismoPostCollection.ReplaceOneAsync(x => x.GranturismoPostId == id, updatedGranTurismoPost);

        public async Task RemoveGranturismoAsync(int id) => await _granturismoPostCollection.DeleteOneAsync(x => x.GranturismoPostId == id);



        //Tune methods
        public async Task<List<GranturismoTune>> GetGranturismoTuneAsync() => await _granturismoTuneCollection.Find(_ => true).ToListAsync();

        public async Task<GranturismoTune?> GetGranturismoTuneAsync(int id) => await _granturismoTuneCollection.Find(x => x.GranturismoTuneId == id).FirstOrDefaultAsync();

        public async Task CreateGranturismoTuneAsync(GranturismoTune newUser) => await _granturismoTuneCollection.InsertOneAsync(newUser);

        public async Task UpdateGranturismoTuneAsync(int id, GranturismoTune updatedGranTurismoTune) => await _granturismoTuneCollection.ReplaceOneAsync(x => x.GranturismoTuneId == id, updatedGranTurismoTune);

        public async Task RemoveGranturismoTuneAsync(int id) => await _granturismoTuneCollection.DeleteOneAsync(x => x.GranturismoTuneId == id);



        //Hentai methods
        public async Task<List<Hentai>> GetHentaiAsync() => await _hentaiCollection.Find(_ => true).ToListAsync();

        public async Task<Hentai?> GetHentaiAsync(int id) => await _hentaiCollection.Find(x => x.HentaiId == id).FirstOrDefaultAsync();

        public async Task CreateHentaiAsync(Hentai newHentai) => await _hentaiCollection.InsertOneAsync(newHentai);

        public async Task UpdateHentaiAsync(int id, Hentai updatedHentai) => await _hentaiCollection.ReplaceOneAsync(x => x.HentaiId == id, updatedHentai);

        public async Task RemoveHentaiAsync(int id) => await _hentaiCollection.DeleteOneAsync(x => x.HentaiId == id);



        //Misc methods
        public async Task<List<Misc>> GetMiscAsync() => await _miscCollection.Find(_ => true).ToListAsync();

        public async Task<Misc?> GetMiscAsync(int id) => await _miscCollection.Find(x => x.MiscId == id).FirstOrDefaultAsync();

        public async Task CreateMiscAsync(Misc newMisc) => await _miscCollection.InsertOneAsync(newMisc);

        public async Task UpdateMiscAsync(int id, Misc updatedMisc) => await _miscCollection.ReplaceOneAsync(x => x.MiscId == id, updatedMisc);

        public async Task RemoveMiscAsync(int id) => await _miscCollection.DeleteOneAsync(x => x.MiscId == id);


        //Project methods
        public async Task<List<Project>> GetProjectAsync() => await _projectCollection.Find(_ => true).ToListAsync();

        public async Task<Project?> GetProjectAsync(int id) => await _projectCollection.Find(x => x.ProjectId == id).FirstOrDefaultAsync();

        public async Task CreateProjectAsync(Project newProject) => await _projectCollection.InsertOneAsync(newProject);

        public async Task UpdateProjectAsync(int id, Project updatedProject) => await _projectCollection.ReplaceOneAsync(x => x.ProjectId == id, updatedProject);

        public async Task RemoveProjectAsync(int id) => await _projectCollection.DeleteOneAsync(x => x.ProjectId == id);



        //Snippet methods
        public async Task<List<Snippet>> GetSnippetAsync() => await _snippetCollection.Find(_ => true).ToListAsync();

        public async Task<Snippet?> GetSnippetAsync(int id) => await _snippetCollection.Find(x => x.SnippetId == id).FirstOrDefaultAsync();

        public async Task CreateSnippetAsync(Snippet newSnippet) => await _snippetCollection.InsertOneAsync(newSnippet);

        public async Task UpdateSnippetAsync(int id, Snippet updatedSnippet) => await _snippetCollection.ReplaceOneAsync(x => x.SnippetId == id, updatedSnippet);

        public async Task RemoveSnippetAsync(int id) => await _snippetCollection.DeleteOneAsync(x => x.SnippetId == id);


        //User methods
        public async Task<List<User>> GetUserAsync() => await _userCollection.Find(_ => true).ToListAsync();

        public async Task<User?> GetUserAsync(string id) => await _userCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateUserAsync(User newUser) => await _userCollection.InsertOneAsync(newUser);

        public async Task UpdateuserAsync(string id, User updatedUser) => await _userCollection.ReplaceOneAsync(x => x.Id == id, updatedUser);

        public async Task RemoveUserAsync(string id) => await _userCollection.DeleteOneAsync(x => x.Id == id);




    }
}
