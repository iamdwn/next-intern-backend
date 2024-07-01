﻿using AutoMapper;
using SWD.NextIntern.Repository.Entities;
using SWD.NextIntern.Repository.Persistence;
using SWD.NextIntern.Repository.Repositories.IRepositories;

namespace SWD.NextIntern.Repository.Repositories
{
    public class CampaignQuestionRepository : RepositoryBase<CampaignQuestion, CampaignQuestion, AppDbContext>, ICampaignQuestionRepository
    {
        public CampaignQuestionRepository(AppDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
