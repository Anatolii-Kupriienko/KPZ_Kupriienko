namespace MediatorClassLibrary
{
    public class CommandCentre : IMediator
    {
        private Dictionary<Runway, Aircraft?> runways = new Dictionary<Runway, Aircraft?>();
        private List<Aircraft> aircraft = new List<Aircraft>();

        public CommandCentre(Runway[] runways, Aircraft[] aircraft)
        {
            this.aircraft.AddRange(aircraft);
            foreach (var runway in runways)
            {
                this.runways.Add(runway, null);
                runway.SetMediator(this);
            }
            foreach (var a in aircraft)
            {
                a.SetMediator(this);
            }
        }

        public bool Notify(object sender, string ev)
        {
            switch (ev)
            {
                case "landing":
                    if (sender.GetType() != typeof(Aircraft))
                        return false;

                    foreach (var runway in runways.Keys)
                    {
                        if (runways[runway] == null)
                        {
                            runways[runway] = sender as Aircraft;
                            runway.HighlightRed();
                            return true;
                        }
                    }
                    return false;

                case "landed":
                    if (sender.GetType() != typeof(Aircraft))
                        return false;

                    foreach (var runway in runways.Keys)
                    {
                        if (runways[runway] == sender)
                        {
                            runways[runway] = null;
                            runway.HighlightGreen();
                            return true;
                        }
                    }
                    return false;

                case "taking off":
                    if (sender.GetType() != typeof(Aircraft))
                        return false;

                    foreach (var runway in runways.Keys)
                    {
                        if (runways[runway] == null)
                        {
                            runways[runway] = sender as Aircraft;
                            runway.HighlightRed();
                            return true;
                        }
                    }
                    return false;

                case "took off":
                    if (sender.GetType() != typeof(Aircraft))
                        return false;

                    foreach (var runway in runways.Keys)
                    {
                        if (runways[runway] == sender)
                        {
                            runways[runway] = null;
                            runway.HighlightGreen();
                            return true;
                        }
                    }
                    return false;

                case "is active":
                    if (sender.GetType() != typeof(Runway))
                        return false;

                    foreach (var runway in runways.Keys)
                    {
                        if (runway == sender)
                        {
                            if (runways[runway] == null)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    return false;

                default:
                    return false;
            }
        }
    }
}