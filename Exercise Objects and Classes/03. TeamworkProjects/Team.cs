class Team
{
       //характеристики -> име, създател, списък от членове
       public string Name { get; set; }
       public string Creator { get; set; }
       public List<string> Members { get; set; }

        //constructor -> създаване на обекти от класа
        public Team (string name, string creator)
        {
            //нов празен обект(отбор)
            Name = name;
            Creator = creator;
            Members = new List<string> ();

        }


}

