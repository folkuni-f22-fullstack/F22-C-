namespace ReactBlog.Server
{
	public class WeatherForecast
	{
		public DateOnly Date { get; set; }

		public int TemperatureC { get; set; }

		public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

		public string? Summary { get; set; }
	}
	/*
	Motsvarande i TypeScript:
	type WeatherForecast = {
		date: DateOnly;
		temperatureC: int;
		summary?: string;
	}

	*/
}
