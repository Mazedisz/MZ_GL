﻿using System.Collections.Generic;

namespace SoapBox.JsonScheme {
    public class GetServerInformation {
        public string MessageSrv { get; set; }
        public string HomePageUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string DiscordUrl { get; set; }
        public string ServerName { get; set; }
        public string Country { get; set; }
        public int? TimeZone { get; set; }
        public string BannerUrl { get; set; }
        public string AdminList { get; set; }
        public string OwnerList { get; set; }
        public int NumberOfRegistered { get; set; }
        public List<string> ActivatedHolidaySceneryGroups { get; set; }
        public List<string> DisactivatedHolidaySceneryGroups { get; set; }
        public int OnlineNumber { get; set; }
        public string RequireTicket { get; set; }
        public string ServerVersion { get; set; }
        public int MaxUsersAllowed { get; set; }
        public string AllowedCountries { get; set; }
        public string FreeroamMapSocket { get; set; }
        public List<string> FreeroamServers { get; set; }
        public string ModernAuthSupport { get; set; }
        public int SecondsToShutDown { get; set; }
        public string ModsUrl { get; set; }
        public string WebSignupUrl { get; set; }
        public string WebRecoveryUrl { get; set; }
        public bool RWACallow { get; set; }
    }
}
