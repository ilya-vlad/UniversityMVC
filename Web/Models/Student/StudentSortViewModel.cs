using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Web.Models.Student
{
    public class StudentSortViewModel
    {        
        public StudentSortState FirstNameSort { get; private set; }
        public StudentSortState LastNameSort { get; private set; }
        public StudentSortState AgeSort { get; private set; }
        public StudentSortState ExamScoreSort { get; private set; }
        public StudentSortState Current { get; private set; }
        
        public StudentSortViewModel(StudentSortState sortOrder)
        {
            FirstNameSort = sortOrder == StudentSortState.FirstNameAsc ? StudentSortState.FirstNameDesc : StudentSortState.FirstNameAsc;
            LastNameSort = sortOrder == StudentSortState.LastNameAsc ? StudentSortState.LastNameDesc : StudentSortState.LastNameAsc;
            AgeSort = sortOrder == StudentSortState.AgeAsc ? StudentSortState.AgeDesc : StudentSortState.AgeAsc;
            ExamScoreSort = sortOrder == StudentSortState.ExamScoreAsc ? StudentSortState.ExamScoreDesc : StudentSortState.ExamScoreAsc;
            Current = sortOrder;
        }
    }
}
