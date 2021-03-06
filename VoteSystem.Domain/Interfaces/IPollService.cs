﻿using System;
using System.Collections.Generic;
using System.Text;
using VoteSystem.Data.DTO;
using VoteSystem.Data.Entities.PollAggregate;

namespace VoteSystem.Domain.Interfaces
{
    public interface IPollService
    {
        List<int> GetAllAvailablePollIds(int userId);
        void CreatePoll(PollCreationDTO creationDTO);
        Choice CreateChoice(ChoiceCreationDTO choiceCreation);
    }
}
