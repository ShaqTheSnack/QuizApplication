using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplikation.Models
{
    public class ProcedureNames
    {
        //Alle procedures, de kan også blive set i DatabaseScripts.sql hvordan de oprettes.
        public string HistoryProcedure { get; set; } = "GetAllQuestionHistory";
        public string ScienceProcedure { get; set; } = "GetAllQuestionScience";
        public string MovieProcedure { get; set; } = "GetAllQuestionMovie";
        public string GeographyProcedure { get; set; } = "GetAllQuestionGeography";
        public string SportsProcedure { get; set; } = "GetAllQuestionSports";
        public string ProgrammingProcedure { get; set; } = "GetAllQuestionProgramming";
        public string DatabaseProcedure { get; set; } = "GetAllQuestionDatabase";
        public string ClientSideProcedure { get; set; } = "GetAllQuestionClientSide";
        public string NetworkingProcedure { get; set; } = "GetAllQuestionNetworking";
        public string GUIProcedure { get; set; } = "GetAllQuestionGUI";
        public string CategoryProcedure { get; set; } = string.Empty;
    }
}
