public class Activity
{
    protected string _date;
    protected int _time;
    protected string _typeOfActivity;

    public Activity(string date, string typeOfActivity, int time)
    {
        _date = date;
        _typeOfActivity = typeOfActivity;
        _time = time;
    }
    public string GetSummary()
    {
        return $"{_date} {_typeOfActivity} ({_time}min) --> Distance {Math.Round(GetDistance(), 2)} miles || Speed: {Math.Round(GetSpeed(), 2)} mph || Pace: {Math.Round(GetPace(), 2)} min per mile";
    }
    protected virtual double GetDistance()
    {
       return 0;
    }
    protected virtual double GetSpeed()
    {
        return 0;
    }
    protected virtual double GetPace()
    {
        return 0;
    }
    protected int GetTimeInMinutes()
    {
        return _time;
    }
}