using System.Collections.Generic;

namespace BristolApiHackathon.Models
{
    public class Options
    {
        public int MaximumLegs { get; set; }
        public int WalkSpeed { get; set; }
        public int MaximumWalkingTimeBetweenLegs { get; set; }
        public int MaximumWalkingLegTime { get; set; }
        public int MaximumTotalWalkingTime { get; set; }
        public List<int> AcceptableVehicleTypes { get; set; }
        public int PlanningPrioritization { get; set; }
        public bool AccessibilityNoStairs { get; set; }
        public bool AccessibilityNoEscalators { get; set; }
        public bool AccessibilityNoElevators { get; set; }
        public bool AccessibilityNoStepsToVehicle { get; set; }
        public bool AccessibilityNoStepsToPlatform { get; set; }
        public List<int> AvoidedLineTypes { get; set; }
    }
}