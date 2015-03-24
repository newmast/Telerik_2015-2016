namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Teacher : Person, ICommentable
    {
        private List<Discipline> taughtDisciplines;
        private string comment;

        public Teacher(string name, List<Discipline> taughtDisciplines)
            : base(name)
        {
            this.taughtDisciplines = taughtDisciplines;
        }

        public Teacher(string name, List<Discipline> taughtDisciplines, string comment)
            : base(name)
        {
            this.taughtDisciplines = taughtDisciplines;
            this.comment = comment;
        }

        public List<Discipline> TaughtDisciplines
        {
            get
            {
                return this.taughtDisciplines;
            }
            set
            {
                this.taughtDisciplines = TaughtDisciplines;
            }
        }

        public string Comment
        {
            get
            {
                if (String.IsNullOrWhiteSpace(comment))
                {
                    return "No comment yet.";
                }
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
