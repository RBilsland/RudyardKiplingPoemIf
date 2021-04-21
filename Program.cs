// Rudyard Kipling's poem If
// Interpreted as C# code
//
// by R.C.Bilsland
// 21st April 2021

using System;

namespace RudyardKipling
{
    public class You
    {
        public bool CanKeepYourHeadWhenAllAboutYouAreLosingTheirs = true;
        public bool CanTrustYourselfWhenAllMenDoubtYouButMakeAllowanceForTheirDoubtingToo { get; set; } = true;
        public bool CanWait { get; set; } = true;
        public bool CanDream { get; set; } = true;
        public bool CanThink { get; set; } = true;
        public bool NotMakeThoughtsYourAim { get; set; } = true;
        public bool CanMeetWithTriumph { get; set; } = true;
        public bool CanBearToHearTheTruthYouveSpokenTwistedByKnavesToMakeATrapForFools { get; set; } = true;
        public bool CanMakeOneHeapOfAllYourWinnings { get; set; } = true;
        public bool CanForceYourHeart { get; set; } = true;
        public bool CanTalkWithCrowds { get; set; } = true;
        public bool CanFillTheUnforgivingMinuteWithSixtySecondsWorthOfDistanceRun { get; set; } = true;

    }

    public class PoemIf
    {
        public static string Read(You you)
        {
            string response = string.Empty;

            bool BlamingItOnYou = true;
            bool NotBeTiredByWaiting = true;
            bool BeingLiedAboutDontDealInLies = true;
            bool BeingHatedDontGiveWayToHating = true;
            bool YetDontLookTooGoodNorTalkTooWise = true;
            bool NotMakeDreamYourMaster = true;
            bool Disaster = true;
            bool TreatThoseTwoImpostorsJustTheSame = true;
            bool WatchTheThingsYouGaveYourLifeToBroken = true;
            bool Stoop = true;
            bool BuildEmUpWithWornOutTools = true;
            bool RiskItOnOneTurnOfPitchAndToss = true;
            bool Lose = true;
            bool StartAgainAtYourBeginnings = true;
            bool NeverBreatheAWordAboutYourLoss = true;
            bool Nerve = true;
            bool SinewToServeYourTurnLongAfterTheyAreGone = true;
            bool SoHoldOnWhenThereIsNothingInYouExceptTheWillWhichSaysToThemHoldOn = true;
            bool KeepYourVirtue = true;
            bool WalkWithKingsNorLoseTheCommonTouch = true;
            bool NeitherFoesNorLovingFriendsCanHurtYou = true;
            bool AllMenCountWithYouButNoneTooMuch = true;

            if (you.CanKeepYourHeadWhenAllAboutYouAreLosingTheirs && BlamingItOnYou)
            {
                if (you.CanTrustYourselfWhenAllMenDoubtYouButMakeAllowanceForTheirDoubtingToo)
                {
                    if (you.CanWait && 
                        NotBeTiredByWaiting || 
                        BeingLiedAboutDontDealInLies || 
                        BeingHatedDontGiveWayToHating && 
                        YetDontLookTooGoodNorTalkTooWise)
                    {
                        if (you.CanDream && 
                            NotMakeDreamYourMaster)
                        {
                            if (you.CanMeetWithTriumph && 
                                Disaster && 
                                TreatThoseTwoImpostorsJustTheSame)
                            {
                                if (you.CanBearToHearTheTruthYouveSpokenTwistedByKnavesToMakeATrapForFools || 
                                    WatchTheThingsYouGaveYourLifeToBroken && 
                                    Stoop && 
                                    BuildEmUpWithWornOutTools)
                                {
                                    if (you.CanMakeOneHeapOfAllYourWinnings &&
                                        RiskItOnOneTurnOfPitchAndToss &&
                                        Lose &&
                                        StartAgainAtYourBeginnings &&
                                        NeverBreatheAWordAboutYourLoss)
                                    {
                                        if (you.CanForceYourHeart && 
                                            Nerve &&
                                            SinewToServeYourTurnLongAfterTheyAreGone &&
                                            SoHoldOnWhenThereIsNothingInYouExceptTheWillWhichSaysToThemHoldOn)
                                        {
                                            if (you.CanTalkWithCrowds && 
                                                KeepYourVirtue || 
                                                WalkWithKingsNorLoseTheCommonTouch)
                                            {
                                                if (NeitherFoesNorLovingFriendsCanHurtYou)
                                                {
                                                    if (AllMenCountWithYouButNoneTooMuch)
                                                    {
                                                        if (you.CanFillTheUnforgivingMinuteWithSixtySecondsWorthOfDistanceRun)
                                                        {
                                                                response = "Yours is the Earth and everything that’s in it,\r\nand—which is more—you’ll be a Man, my son!";
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return response;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            You you = new();

            Console.WriteLine(PoemIf.Read(you));
        }
    }
}
