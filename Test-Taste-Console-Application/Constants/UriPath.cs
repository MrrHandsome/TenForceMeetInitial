namespace Test_Taste_Console_Application.Constants
{
    public static class UriPath
    {
        public const string BaseUri = "https://api.le-systeme-solaire.net";
        private const string BodiesUri = "/rest/bodies";

        public const string GetAllPlanetsWithMoonsQueryParameters =
            BodiesUri + "?data=id,semiMajorAxis,moons,moon,rel&filter[]=isPlanet,neq,false";

        /// <summary>
        /// BugFix-1: Query parameter does not exists gravity, which is required to calculate average.
        /// </summary>
        public const string GetAllMoonsWithMassQueryParameters = BodiesUri +
                                               "?data=id,mass,massValue,massExponent,gravity,massValue&filter[]=aroundPlanet,gt,null";

        public const string GetMoonByIdQueryParameters = BodiesUri + "/";
    }
}
