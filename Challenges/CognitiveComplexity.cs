

namespace SonarqubeTest.CognitiveComplexity
{
    public class CognitiveComplexity
    {
        public static void highCycloLowCognitive(int i)
        {
            switch (i) {
                case 1:
                    Base.doSomething();
                    break;
                case 2:
                    Base.doSomethingElse();
                    break;
                case 3:
                    Base.forgetIt();
                    break;
                case 4:
                    Base.forgetItAgain();
                    break;
                case 5:
                    Base.yetAnotherCase();
                    break;
                case 6:
                    Base.soBoring();
                    break;
                case 7:
                    Base.timeForVacations();
                    break;
                case 8:
                    Base.eightCase();
                    break;
                case 9:
                    Base.cantSeeTheEndOfIt();
                    break;
                case 10:
                    Base.tenThisIsIt();
                    break;
                default:
                    Base.doNothing();
                    break;
            }
            return;
        }


        public static void highCycloVeryHighCognitive(int i)
        {
            if ( i <= 5 ) {
                if ( i <= 2 ) {
                    if ( i == 1 ) {
                        Base.doSomething();
                    } else {
                        Base.doSomethingElse();
                    }
                } else {   
                    if ( i > 3 ) {
                        Base.forgetItAgain();
                    } else {
                        Base.forgetIt();
                    }
                }
            } else {
                if ( i <= 7 ) {
                    if ( i == 6 ) {
                        Base.soBoring();
                    } else if ( i == 7 ) {
                        Base.timeForVacations();
                    } else {
                        // Never reached
                        Base.doNothing();
                    } 
                } else {
                    if ( i == 8 ) {
                        Base.eightCase();
                    } else if ( i == 9 ) {
                        Base.cantSeeTheEndOfIt();
                    } else if ( i == 10 ) {
                        Base.tenThisIsIt();
                    } else {
                        Base.doNothing();
                    }
                }
            }
        }
    }
}