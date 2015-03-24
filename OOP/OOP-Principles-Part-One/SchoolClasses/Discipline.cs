namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Discipline : ICommentable
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private string comment;

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.name = name;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExercises = numberOfExercises;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                foreach (var letter in this.name)
                {
                    if (!Char.IsLetter(letter))
                    {
                        throw new ArgumentException("Invalid discipline name.");
                    }
                }
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Invallid number of lectures");
                }
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Invallid number of exercises");
                }
                this.numberOfExercises = value;
            }
        }

        public string Comment
        {
            get
            {
                if (String.IsNullOrWhiteSpace(this.Comment))
                {
                    return "Nobody has commented this yet.";
                }
                return this.comment;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid comment.");
                }
                this.comment = value;
            }
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
