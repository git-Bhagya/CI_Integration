﻿using Ci_Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ci_Project.Entities.ViewModels
{
    public class AdminViewModel
    {
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<City> Cities { get; set; }
        public IEnumerable<Country> Countries { get; set; }
        public List<Mission> MissionList { get; set; }
        public List<MissionTheme> MissionThemeList { get; set; }
        public List<Skill> SkillList { get; set; }
        public List<MissionApplication> MissionApplicationList { get; set; }
        public List<Story> StoryList { get; set; }
        public List<User> UserList { get; set; }
        public List<Banner> BannerList { get; set; }
        public List<MissionMedium> MissionImages { get; set; }
        public List<MissionDocument> MissionDec { get; set; }
        public List<MissionSkill> MissionSkill { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }
        public int EmployeeId { get; set; }
        public string Department { get; set; }
        public int city { get; set; }
        public int country { get; set; }
        public string ProfileText { get; set; }
        public string status { get; set; }
        public string Pass { get; set; }

        //pagination
        public int totalrecord { get; set; }
        public int currentPage { get; set; }

        //Mission
        public string MissionTitle { get; set; }
        public string MissionType { get; set; }
        public string Description { get; set; }
        public string SDescription { get; set; }
        public string OrgName { get; set; }
        public string OrgDetails { get; set; }
        public int Seats { get; set; }
        public DateTime Deadline { get; set; }
        public int Theme { get; set; }
        public string Skills { get; set; }
        public string Mimages { get; set; }
        public string Document { get; set; }
        public string Availability { get; set; }
        public string Video { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        //cms page view model
        public List<CmsPage> listOfCmsPage { get; set; }
        public string CMStitle { get; set; }
        public string CMSdescription { get; set; }
        public string CMSslug { get; set; }
        public string CMSStatus { get; set; }


        //mission Theme
        public int ThemeId { get; set; }
        public string ThemeTitle { get; set; }
        public string ThemeStatus { get; set; }
        public DateTime CreateAt { get; set; }

        //skill
        public string SkillName { get; set; }
        public string SkillStatus { get; set; }

        //banner
        public string BImages { get; set; }
        public string BText { get; set; }
        public int SortOrder { get; set; }
    }
}
