using Test_Taste_Console_Application.Domain.DataTransferObjects;

namespace Test_Taste_Console_Application.Domain.Objects
{
    public class Moon
    {
        public string Id { get; set; }
        public float MassValue { get; set; }
        public float MassExponent { get; set; }

        /// <summary>
        /// BugFix-1: Required this proerty for calculate average.
        /// </summary>
        public float Gravity { get; set; }

        public Moon(MoonDto moonDto)
        {
            Id = moonDto.Id;
            MassValue = moonDto.MassValue;
            MassExponent = moonDto.MassExponent;

            // BugFix-1: Required this proerty for calculate average.
            Gravity = moonDto.MassGravity;
        }
    }
}
