namespace app_myconference.Pages;
public partial class SchedulePage : ContentPage
{
	readonly ScheduleViewModel vm;
	public static int Day { get; set; }	
	public SchedulePage(ScheduleViewModel vm)
	{
		InitializeComponent();

		Day++;
		vm.Day = Day;

		BindingContext = this.vm = vm;
	}
	protected override async void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
		if (vm.Schedule.Count == 0)
			await vm.LoadDataCommand.ExecuteAsync(null);
	}
}