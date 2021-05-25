using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class VacancysettingsModel
    {
        public int Id { get; set; }
        public int VacancyId { get; set; }
        public string WelcomeMessage { get; set; }
        public string RejectMessage { get; set; }
        public bool PhoneInterviewChecked { get; set; }
        public string WelcomeMessageToPhoneInterview { get; set; }
        public bool CareerTestingChecked { get; set; }
        public string WelcomeMessageToCareerTesting { get; set; }
        public string GoogleFormsForCareerTesting { get; set; }
        public string ResponseSpreadsheetForGoogleForms { get; set; }
        public bool SetAutomaticScoring { get; set; }
        public int ScorePerQuestion { get; set; }
        public int PassAverageScore { get; set; }
        public string QuestionsAndPossibleAnswerXML { get; set; }
        public bool FaceToFaceInterviewChecked { get; set; }
        public string WelcomeMessageToFaceToFaceInterview { get; set; }
    }
}
