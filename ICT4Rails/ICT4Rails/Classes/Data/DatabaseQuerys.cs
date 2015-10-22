using System;
using System.Collections.Generic;

namespace ICT4Rails
{
    public static class DatabaseQuerys
    {
        public static Dictionary<string, string> query = new Dictionary<string, string>();

        static DatabaseQuerys()
        {
            query["GetAllLogins"] = "SELECT * FROM EMPLOYEELOGINS";
            query["GetLogin"] = "SELECT * FROM EMPLOYEELOGINS WHERE USERNAME=:username";
            query["CreateEmployee"] = "INSERT INTO EMPLOYEE(NAME, SURNAME, EMPLOYEETYPE) values (:name, :surname, :employeetype)";
            query["CreateLogin"] = "INSERT INTO LOGIN(USERNAME, PASSWORD, GUID, USERTYPE, USERID) values (:username, :password, :guid, :usertype, (SELECT MAX(USERID) FROM EMPLOYEE))";
			query["GetTech"] = "SELECT m.DateAdded, m.DateFinished, m.FinishedBy, e.Name, m.Opmerking, nt.RailID, nt.Name, nt.SectorID, nt.Position, nt.TramID FROM MAINTENANCE m, newTrams nt, EMPLOYEE e WHERE m.Type = 1 AND nt.TramID = m.TramID AND e.USERID = m.FinishedBy";
            query["GetClean"] = "SELECT m.DateAdded, m.DateFinished, m.FinishedBy, e.Name, m.Opmerking, nt.RailID, nt.Name, nt.SectorID, nt.Position, nt.TramID FROM MAINTENANCE m, newTrams nt, EMPLOYEE e WHERE m.Type = 0 AND nt.TramID = m.TramID AND e.USERID = m.FinishedBy";
			query["RemoveUser"] = "DELETE FROM LOGIN WHERE USERNAME=:username";
            query["GetAllSectors"] = "SELECT * FROM SECTOR";
			query["UpdateEndDateClean"] = "UPDATE TABLE MAINTENANCE SET DATEFINISHED =:datefinished WHERE TramID =:tramid AND FINISHEDBY IS NULL";
        }
    }
}
