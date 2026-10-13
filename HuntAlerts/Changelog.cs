namespace HuntAlerts
{
    public static class Changelog
    {
        public const int Revision = 2;

        public sealed record Entry(string Version, string[] Features, string[] BugFixes);

        public static readonly Entry[] Entries =
        {
            new("1.4.1.7-MD",
                Features: new[]
                {
                    "Per Character configurations are the new big thing here",
                    "- Relay channels are now defined for each character, and CWLS are now saved per region as well for voyaging.",
                    "Plaintext coordinate relays have been removed, & now only Flags will be sent out",
                    "- (A future update may make the text customisable)",
                    "- If you are in a state where the map cannot be opened, this will prevent any relays from being sent",
                    "The Datacentre name is now included in notifications",
                    "Relative timestamps from Discord posts are now supported in notifications",
                    "Some buttons have been removed from the Notification window under certain circumstances",
                    "- i.e. the Party Finder will not appear when not currently on the designated world",
                    "Notifications without a valid location can now be manually set",
                    "- This feature is still in development and is prone to bugs, The DEBUG tab has been unlocked for users to create dummy notifications to relay if needbe"
                },
                BugFixes: new[]
                {
                    "Aetherite marking is a little more reliable now, with coordinate from the text no longer overriding them",
                    "Relays to world/region restricted chat channels will not be attempted if unavaliable"
                }),
            new("1.4.0.11",
                Features: new string[0],
                BugFixes: new[]
                {
                    "Fixed nav arrow flipping when looking over the horizon.",
                }),
            new("1.4.0.10",
                Features: new[]
                {
                    "Toast notifications - a positionable on-screen banner for new alerts with fade / slide animations.",
                    "Navigation arrow that points toward a hunt while you are in its zone:",
                    "- Picks up map coordinates from Yell and Shout chat automatically (on by default). Enable Party chat too for hunt trains or treasure maps.",
                    "- Opening an s-rank notification window will set its destination to the mark.",
                    "- New Nav button on S Rank notifications to force it as the arrow's destination.",
                    "Option to disable chat alerts while keeping the popup, toast, and arrow.",
                    "Reorganized the settings page to accommodate the new features.",
                },
                BugFixes: new string[0]),
        };
    }
}
