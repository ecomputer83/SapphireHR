using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class Vacancysettings : BaseEntity
    {
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
        [ForeignKey("VacancyId")]
        public Vacancy Vacancy { get; set; }

    }
}
