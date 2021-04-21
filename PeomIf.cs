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
        public bool CanTrustYourselfWhenAllMenDoubtYouButMakeAllowanceForTheirDoubtingToo = true;
        public bool CanWait = true;
        public bool CanDream = true;
        public bool CanThink = true;
        public bool NotMakeThoughtsYourAim = true;
        public bool CanMeetWithTriumph = true;
        public bool CanBearToHearTheTruthYouveSpokenTwistedByKnavesToMakeATrapForFools = true;
        public bool CanMakeOneHeapOfAllYourWinnings = true;
        public bool CanForceYourHeart = true;
        public bool CanTalkWithCrowds = true;
        public bool CanFillTheUnforgivingMinuteWithSixtySecondsWorthOfDistanceRun = true;
    }

    public class PoemIf
    {
        readonly bool BlamingItOnYou = true;
        readonly bool NotBeTiredByWaiting = true;
        readonly bool BeingLiedAboutDontDealInLies = true;
        readonly bool BeingHatedDontGiveWayToHating = true;
        readonly bool YetDontLookTooGoodNorTalkTooWise = true;
        readonly bool NotMakeDreamYourMaster = true;
        readonly bool Disaster = true;
        readonly bool TreatThoseTwoImpostorsJustTheSame = true;
        readonly bool WatchTheThingsYouGaveYourLifeToBroken = true;
        readonly bool Stoop = true;
        readonly bool BuildEmUpWithWornOutTools = true;
        readonly bool RiskItOnOneTurnOfPitchAndToss = true;
        readonly bool Lose = true;
        readonly bool StartAgainAtYourBeginnings = true;
        readonly bool NeverBreatheAWordAboutYourLoss = true;
        readonly bool Nerve = true;
        readonly bool SinewToServeYourTurnLongAfterTheyAreGone = true;
        readonly bool SoHoldOnWhenThereIsNothingInYouExceptTheWillWhichSaysToThemHoldOn = true;
        readonly bool KeepYourVirtue = true;
        readonly bool WalkWithKingsNorLoseTheCommonTouch = true;
        readonly bool NeitherFoesNorLovingFriendsCanHurtYou = true;
        readonly bool AllMenCountWithYouButNoneTooMuch = true;

        public string Read(You you)
        {
            string response = string.Empty;

            // Read the Poem from here!
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

        static void Main(string[] args)
        {
            You you = new();
            PoemIf poemIf = new();

            Console.WriteLine(poemIf.Read(you));
        }
    }
}
