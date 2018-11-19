using System;
namespace InternshipTest.Education
{
    public class Period
    {   
        DateTime startDate = new DateTime(2015, 9, 1);
        DateTime endDate = new DateTime(2020, 7, 28);
        public Period(){

        }
        public Period(DateTime startDate, DateTime endDate){
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public bool includes(DateTime date){
            return date >= startDate && date <= endDate;
        }

        public DateTime GetStartDate() {
            return startDate;
        }
        public DateTime GetEndDate() {
            return endDate;
        }
    }
}
