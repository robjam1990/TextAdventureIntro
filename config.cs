using System;
using System.IO;
using Newtonsoft.Json;


public class GameConfig
{
    [Serializable]
    public class GameConfigDefaults
    {
        // Game directories
        public string HomeDirectory { get; set; } = "C://./Psychosis/"; // Home directory
        public string ResourcesDirectory { get; set; } = "C:// /Psychosis/Resources/"; // Resources directory
        public string DataDirectory { get; set; } = "C:// /Psychosis/Data/"; // Data directory
        public string SaveDirectory { get; set; } = "C:// /Psychosis/Save/";    // Save directory
        public string LogDirectory { get; set; } = "C:// /Psychosis/Log/"; // Log directory
        public string ConfigDirectory { get; set; } = "C:// /Psychosis/Config/"; // Configuration directory
        public string TempDirectory { get; set; } = "C:// /Psychosis/Temp/";    // Temporary directory
        public string AssetDirectory { get; set; } = "C:// /Psychosis/Asset/"; // Asset directory
        public string ScriptDirectory { get; set; } = "C:// /Psychosis/Script/"; // Script directory
        public string PluginDirectory { get; set; } = "C:// /Psychosis/Plugin/"; // Plugin directory
        public string ModDirectory { get; set; } = "C:// /Psychosis/Mod/"; // Mod directory

        // Window settings
        public string WindowTitle { get; set; } = "Psychosis Window";   // Default window title
        public string WindowIcon { get; set; } = "Thear.png";   // Default window icon
        public int MaxWindowWidth { get; set; } = 800; // Default maximum window width
        public int MaxWindowHeight { get; set; } = 600; // Default maximum window height
        public int InitialWindowWidth { get; set; } = 600; // Default initial window width
        public int InitialWindowHeight { get; set; } = 400; // Default initial window height
        public bool WindowResizable { get; set; } = true; // Default window resizable
        public bool WindowBorderless { get; set; } = false; // Default window borderless
        public bool WindowAlwaysOnTop { get; set; } = false;    // Default window always on top
        public bool WindowVSync { get; set; } = true; // Default window VSync

        // Rendering settings
        public int[] RenderDefaultBackgroundColor { get; set; } = new int[] { 255, 255, 255 }; // White color
        public int RenderDefaultLayer { get; set; } = 0;    // Default render layer
        public int RenderFPS { get; set; } = 60; // Default render FPS
        public bool RenderVSync { get; set; } = true; // Default render VSync
        public bool RenderFullscreen { get; set; } = false; // Default render fullscreen
        public bool RenderAntialiasing { get; set; } = true; // Default render antialiasing
        public bool RenderTexture { get; set; } = true; // Default render texture
        public bool RenderPostProcessing { get; set; } = true; // Default render post-processing
        public bool RenderBloom { get; set; } = true; // Default render bloom

        // Game features
        public bool LimbRemovalEnabled { get; set; } = true; // Added Limb Removal
        public bool EcosystemSimulationEnabled { get; set; } = true; // Added Ecosystem Simulation
        public bool NationBuildingEnabled { get; set; } = true; // Added Nation Building
        public bool SocialInfrastructureEnabled { get; set; } = true; // Added Social Infrastructure
        public bool BountySystemEnabled { get; set; } = true; // Added Bounty System
        public bool HierarchySystemEnabled { get; set; } = true; // Added Hierarchy System
        public bool IndividualLoyaltyEnabled { get; set; } = true; // Added Individual Loyalty
        public bool TerritoryBorderExpansionEnabled { get; set; } = true; // Added Territory Border Expansion
        public bool DayNightCycleEnabled { get; set; } = true; // Added Day-Night Cycle
        public bool ConstructionSystemEnabled { get; set; } = true; // Added Construction System
        public bool PrisonerSystemEnabled { get; set; } = true; // Added Prisoner System
        public bool HiringSystemEnabled { get; set; } = true; // Added Hiring System
        public bool SupplyAndDemandSystemEnabled { get; set; } = true; // Added Supply and Demand System
        public bool ResourceSystemEnabled { get; set; } = true; // Added Resource System
        public bool CraftingSystemEnabled { get; set; } = true; // Added Crafting System
        public bool SurvivalSystemEnabled { get; set; } = true; // Added Survival System
        public bool CharacterGrowthSystemEnabled { get; set; } = true; // Added Character Growth System
        public bool LearningAndTeachingSystemEnabled { get; set; } = true; // Added Learning and Teaching System
        public bool ObservationSystemEnabled { get; set; } = true; // Added Observation System
        public bool CharacterCustomizationEnabled { get; set; } = true;     // Added Character Customization
        public bool GeneticManipulationEnabled { get; set; } = true; // Added Genetic Manipulation
        public bool NeuralNetworkEnabled { get; set; } = true; // Added Neural Network
        public bool ContractBoardEnabled { get; set; } = true; // Added Contract Board
        public bool ModelStrategyEnabled { get; set; } = true; // Added Model Strategy
        public bool MercenaryEnabled { get; set; } = true; // Added Mercenary
        public bool NPCEnabled { get; set; } = true; // Added NPC
        public bool ArkEnabled { get; set; } = true; // Added Ark
        public bool CharacterEnabled { get; set; } = true; // Added Character
        public bool CharacterCreationEnabled { get; set; } = true; // Added Character Creation
        public bool CharacterDevelopmentEnabled { get; set; } = true; // Added Character Development
        public bool CharacterInteractionEnabled { get; set; } = true; // Added Character Interaction
    }

    public GameConfigDefaults Config { get; private set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public GameConfig(string configPath)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
        try
        {
            string json = File.ReadAllText(configPath);
            dynamic configData = JsonConvert.DeserializeObject(json)!;
            // Validate configData here
            foreach (var property in configData)
            {
                string propertyName = ((Newtonsoft.Json.Linq.JProperty)property).Name;
                object propertyValue = ((Newtonsoft.Json.Linq.JProperty)property).Value;
                typeof(GameConfigDefaults).GetProperty(propertyName)?.SetValue(Config, propertyValue, null);
            }
        }
        catch (Exception error)
        {
            Console.WriteLine("Error loading configuration: " + error.Message);
            // Handle error gracefully or throw it
            Config = new GameConfigDefaults();
        }
    }

    public void UpdateConfig(dynamic configData)
    {
        // Validate and update configData dynamically
        foreach (var property in configData)
        {
            string propertyName = ((Newtonsoft.Json.Linq.JProperty)property).Name;
            object propertyValue = ((Newtonsoft.Json.Linq.JProperty)property).Value;
            typeof(GameConfigDefaults).GetProperty(propertyName)?.SetValue(Config, propertyValue, null);
        }
    }
}

