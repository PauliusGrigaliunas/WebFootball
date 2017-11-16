using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Football
{
    public class Teams
    {
        public void AddToTable(String name, int victories, int goals)
        {
            using (FootballEntities contex = new FootballEntities())
            {
                teamTable team = new teamTable()
                {
                    Name = name,
                    Victories = victories,
                    Goals = goals,
                };         
 
                contex.teamTables.Add(team);
                contex.SaveChanges();
            }
        }

       public bool NameCheckIfExsist(String data)
       {
            bool exsists = false;
            try
            {
                using (FootballEntities contex = new FootballEntities())
                {
                    teamTable team = contex.teamTables.FirstOrDefault(r => r.Name == data);

                    if (team.Name == data)
                    {
                        exsists = true;
                    }
                }
            }
            catch (System.NullReferenceException ex)
            {
                ex.ToString();
            }  
           
               return exsists;
            
            
       }

       public int GetVictories(String data)
       {
            int vict = 0;

            using (FootballEntities contex = new FootballEntities())
            {
                
                teamTable team = contex.teamTables.FirstOrDefault(r => r.Name == data);
                vict = (int)team.Victories;
            }
            return vict;
       }

        public int GetGoals( String data)
        {
            int goals = 0;
            using (FootballEntities contex = new FootballEntities())
            {

                teamTable team = contex.teamTables.FirstOrDefault(r => r.Name == data);
                goals = (int)team.Goals;

            }
            return goals;
        }

        public void InsertToTable(String data, int victories, int goals)
        {
            //irasyti rezultata
            using (FootballEntities contex = new FootballEntities())
            {

                teamTable team = contex.teamTables.FirstOrDefault(r => r.Name == data);
                team.Victories = victories;
                team.Goals = goals;
         
                contex.SaveChanges();
            }

        }
        public void DeleateTableRow(String data)
        {
            using (FootballEntities contex = new FootballEntities())
            {

                teamTable team = contex.teamTables.FirstOrDefault(r => r.Name == data);
              
                contex.teamTables.Remove(team);
            }
        }

    }
}
