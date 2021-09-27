
using MVC.Web.Models.Shared;
using System;

namespace MVC.Web.Models.Student
{
    public class StudentSortViewModel : IGenericSortViewModel
    {        
        public StudentSortState FirstNameSort { get; private set; }
        public StudentSortState LastNameSort { get; private set; }
        public StudentSortState AgeSort { get; private set; }
        public StudentSortState ExamScoreSort { get; private set; }
        private StudentSortState Current { get; set; }        

        public StudentSortViewModel(StudentSortState sortOrder)
        {
            FirstNameSort = sortOrder == StudentSortState.FirstNameAsc ? StudentSortState.FirstNameDesc : StudentSortState.FirstNameAsc;
            LastNameSort = sortOrder == StudentSortState.LastNameAsc ? StudentSortState.LastNameDesc : StudentSortState.LastNameAsc;
            AgeSort = sortOrder == StudentSortState.AgeAsc ? StudentSortState.AgeDesc : StudentSortState.AgeAsc;
            ExamScoreSort = sortOrder == StudentSortState.ExamScoreAsc ? StudentSortState.ExamScoreDesc : StudentSortState.ExamScoreAsc;
            Current = sortOrder;
        }

        public Enum GetCurrent()
        {
            return Current;
        }
    }
}
