// This is the GUI for the Psychosis Project. It is a basic text-based GUI that will be used to display the game.

using System.Windows;
using static System.Net.Mime.MediaTypeNames;
using Forms = System.Windows.Forms;
using Image = System.Drawing;


namespace Project;

public partial interface GUI;

public partial class MainMenu : Forms
{
    private object? Controls;

    internal Forms.Label? ApplicationTitle { get; private set; }
    internal Forms.PictureBox? ApplicationLogo { get; private set; }
    internal Forms.Label? ApplicationVersion { get; private set; }
    internal Forms.Label? ApplicationCopyRight { get; private set; }
    internal Forms.Label? ApplicationDescription { get; private set; }

    private Forms.Button? ApplicationHelp;

    internal Forms.Button? ApplicationCredits { get; private set; }

    private Forms.Button? ApplicationExit;

    internal Forms.Button? ApplicationSettings { get; private set; }
    internal Forms.Button? ApplicationMap { get; private set; }

    // Constructor for MainMenu form
    public MainMenu() : base()
    {
        InitializeComponent();
    }

    // Methods for various menus
    public void NewGameMenu()
    {
        InitializeComponent();
    }

    public void LoadGameMenu()
    {
        InitializeComponent();
    }

    public void SettingsMenu()
    {
        InitializeComponent();
    }

    public void ExitMenu()
    {
        InitializeComponent();
    }

    public void CharacterMenu()
    {
        InitializeComponent();
    }

    public void InventoryMenu()
    {
        InitializeComponent();
    }

    public void StatsMenu()
    {
        InitializeComponent();
    }

    public void SkillsMenu()
    {
        InitializeComponent();
    }

    public void ActionMenu()
    {
        InitializeComponent();
    }

    public void AttackMenu()
    {
        InitializeComponent();
    }

    public void DefendMenu()
    {
        InitializeComponent();
    }

    public void UseItemMenu()
    {
        InitializeComponent();
    }

    public void ObservationMenu()
    {
        InitializeComponent();
    }

    public void LookMenu()
    {
        InitializeComponent();
    }

    public void ListenMenu()
    {
        InitializeComponent();
    }

    public void SmellMenu()
    {
        InitializeComponent();
    }

    public void MapMenu()
    {
        InitializeComponent();
    }

    public void WorldMapMenu()
    {
        InitializeComponent();
    }

    public void LocalMapMenu()
    {
        InitializeComponent();
    }

    public void VolumeMenu()
    {
        InitializeComponent();
    }

    public void GraphicsMenu()
    {
        InitializeComponent();
    }

    public void ControlsMenu()
    {
        InitializeComponent();
    }

    public void SaveMenu()
    {
        InitializeComponent();
    }

    public void QuitMenu()
    {
        InitializeComponent();
    }

    public void HelpMenu()
    {
        InitializeComponent();
    }

    public void ObjectiveMenu()
    {
        InitializeComponent();
    }

    public void AboutMenu()
    {
        InitializeComponent();
    }

    public void CreditsMenu()
    {
        InitializeComponent();
    }

    public void DevelopersMenu()
    {
        InitializeComponent();
    }

    public void ArtistsMenu()
    {
        InitializeComponent();
    }

    public void MusicMenu()
    {
        InitializeComponent();
    }

    // Initializes the components of the form
    public void InitializeComponent()
    {
        ApplicationTitle = new Forms.Label();
        ApplicationLogo = new Forms.PictureBox();
        ApplicationVersion = new Forms.Label();
        ApplicationCopyRight = new Forms.Label();
        ApplicationDescription = new Forms.Label();
        ApplicationHelp = new Forms.Button();
        ApplicationCredits = new Forms.Button();
        ApplicationExit = new Forms.Button();
        ApplicationSettings = new Forms.Button();
        ApplicationMap = new Forms.Button();
        this.Button1 = new Forms.Button();
        this.Button2 = new Forms.Button();
        this.Button3 = new Forms.Button();
        this.Button4 = new Forms.Button();
        this.Button5 = new Forms.Button();
        this.Button6 = new Forms.Button();
        this.Button7 = new Forms.Button();
        this.Button8 = new Forms.Button();
        this.Button9 = new Forms.Button();
        this.Button10 = new Forms.Button();
        this.Button11 = new Forms.Button();
        this.Button12 = new Forms.Button();
        this.Button13 = new Forms.Button();
        this.Button14 = new Forms.Button();
        this.Button15 = new Forms.Button();
        this.Button16 = new Forms.Button();
        this.Button17 = new Forms.Button();

        Controls ??= new object();
        ApplicationTitle ??= new Forms.Label();
        ApplicationLogo ??= new Forms.PictureBox();
        ApplicationVersion ??= new Forms.Label();
        ApplicationCopyRight ??= new Forms.Label();
        ApplicationDescription ??= new Forms.Label();
        ApplicationHelp ??= new Forms.Button();
        ApplicationCredits ??= new Forms.Button();
        ApplicationExit ??= new Forms.Button();
        ApplicationSettings ??= new Forms.Button();
        ApplicationMap ??= new Forms.Button();
    }

    // Load event handler for the Main Menu form
    public void MainMenu_Load(object sender, EventArgs e)
    {
        ApplicationTitle!.Text = "Psychosis";
        ApplicationLogo!.Image = Image.FromFile("C:\\Users\\User\\source\\repos\\Project\\Project\\Resources\\Logo.png");
        ApplicationVersion!.Text = "Version 1.0";
        ApplicationCopyRight!.Text = "© 2021";
        ApplicationDescription!.Text = "A text-based adventure game.";
        ApplicationHelp!.Text = "Help";
        ApplicationCredits!.Text = "Credits";
        ApplicationExit!.Text = "Exit";
        ApplicationSettings!.Text = "Settings";
        ApplicationMap!.Text = "Map";
        this.Button1!.Text = "New Game";
        this.Button2!.Text = "Load Game";
        this.Button3!.Text = "Character";
        this.Button4!.Text = "Inventory";
        this.Button5!.Text = "Stats";
        this.Button6!.Text = "Skills";
        this.Button7!.Text = "Action";
        this.Button8!.Text = "Observation";
        this.Button9!.Text = "Look";
        this.Button10!.Text = "Listen";
        this.Button11!.Text = "Smell";
        this.Button12!.Text = "Map";
        this.Button13!.Text = "World Map";
        this.Button14!.Text = "Local Map";
        this.Button15!.Text = "Settings";
        this.Button16!.Text = "Volume";
        this.Button17!.Text = "Graphics";
        this.Button18!.Text = "Controls";
        this.Button19!.Text = "Exit";
        this.Button20!.Text = "Save";
        this.Button21!.Text = "Quit";
        this.Button22!.Text = "Help";
        this.Button23!.Text = "Controls";
        this.Button24!.Text = "Objective";
        this.Button25!.Text = "About";
        this.Button26!.Text = "Credits";
        this.Button27!.Text = "Developers";
        this.Button28!.Text = "Artists";
        this.Button29!.Text = "Music";
    }
}
