﻿namespace LeagueOfLegendsChampions.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using LeagueOfLegendsChampions.Data.Common.Repositories;
    using LeagueOfLegendsChampions.Data.Models;
    using LeagueOfLegendsChampions.Services.Mapping;
    using LeagueOfLegendsChampions.Web.ViewModels.Builds;
    using LeagueOfLegendsChampions.Web.ViewModels.Items;

    public class BuildsService : IBuildsService
    {
        private readonly IDeletableEntityRepository<Build> buildsRepository;
        private readonly IItemsService itemsService;
        private readonly IRepository<BuildItem> buildItemsRepository;
        private readonly IRepository<Item> itemsRepository;

        public BuildsService(IDeletableEntityRepository<Build> buildsRepository, IItemsService itemsService, IRepository<BuildItem> buildItemsRepository, IRepository<Item> itemsRepository)
        {
            this.buildsRepository = buildsRepository;
            this.itemsService = itemsService;
            this.buildItemsRepository = buildItemsRepository;
            this.itemsRepository = itemsRepository;
        }

        public async Task CreateAsync(BuildInListViewModel input, string championId)
        {
            var buildToAdd = new Build
            {
                Name = input.Name,
                BuildItems = new List<BuildItem>(),
                ChampionId = championId,
                User = input.User,
            };
            int count = 0;
            for (int i = 0; i < 2; i++)
            {
                if (!this.buildItemsRepository.AllAsNoTracking().Any(x => x.Id == $"{count}"))
                {
                    foreach (var item in input.SelectedItems)
                    {
                        var selectedItemToBuild = new BuildItem
                        {
                            Id = $"{count}",
                            Build = buildToAdd,
                            ItemId = this.itemsRepository.AllAsNoTracking().Where(i => i.Name == item).FirstOrDefault().Id,
                            ItemName = this.itemsRepository.AllAsNoTracking().Where(i => i.Name == item).FirstOrDefault().Name,
                            ItemImageUrl = this.itemsRepository.AllAsNoTracking().Where(i => i.Name == item).FirstOrDefault().ImageUrl,
                        };
                        buildToAdd.BuildItems.Add(selectedItemToBuild);
                        await this.buildItemsRepository.AddAsync(selectedItemToBuild);
                        count++;
                    }

                    break;
                }
                else
                {
                    count = this.buildItemsRepository.All().ToList().Count;
                }
            }

            await this.buildsRepository.AddAsync(buildToAdd);
            await this.buildsRepository.SaveChangesAsync();
            await this.buildItemsRepository.SaveChangesAsync();
        }

        public async Task DeleteBuildAsync(string championId, string userId)
        {
            foreach (var build in this.buildsRepository.All().Where(x => x.ChampionId == championId && x.UserId == userId))
            {
                foreach (var buildItem in this.buildItemsRepository.All().Where(i => i.BuildId == build.Id))
                {
                    this.buildItemsRepository.Delete(buildItem);
                }

                this.buildsRepository.HardDelete(build);
            }

            await this.buildItemsRepository.SaveChangesAsync();
            await this.buildsRepository.SaveChangesAsync();
        }

        public IEnumerable<T> GetAll<T>(string id)
        {
            var builds = this.buildsRepository.AllAsNoTracking()
                .Where(b => b.ChampionId == id)
                .To<T>()
                .ToList();

            return builds;
        }
    }
}
