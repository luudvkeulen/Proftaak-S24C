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
            query["GetEmployee"] = "SELECT USERID FROM EMPLOYEE WHERE name = :employee";
            query["CreateEmployee"] = "INSERT INTO EMPLOYEE(NAME, SURNAME, EMPLOYEETYPE) values (:name, :surname, :employeetype)";
            query["CreateLogin"] = "INSERT INTO LOGIN(USERNAME, PASSWORD, GUID, USERTYPE, USERID) values (:username, :password, :guid, :usertype, (SELECT MAX(USERID) FROM EMPLOYEE))";
			query["GetTech"] = "SELECT m.TRAMID,m.DATEADDED,m.DATEFINISHED,m.FINISHEDBY, m.OPMERKING FROM MAINTENANCE m WHERE m.TYPE = 1";
			query["GetClean"] = "SELECT m.TRAMID,m.DATEADDED,m.DATEFINISHED,m.FINISHEDBY, m.OPMERKING FROM MAINTENANCE m WHERE m.TYPE = 0";
			query["GetCleanUser"] = "SELECT e.NAME FROM EMPLOYEE e WHERE e.USERID =:USERID";
			query["RemoveUser"] = "DELETE FROM LOGIN WHERE USERNAME=:username";
            query["GetAllSectors"] = "SELECT * FROM SECTOR";
            query["GetReservedSector"] = "SELECT RAILID, SECTORID FROM SECTOR WHERE TRAMID = :tramid AND ISRESERVED = 1";
			query["UpdateEndDate"] = "UPDATE MAINTENANCE SET DATEFINISHED = TO_DATE(:datefinished,'dd/mm/yyyy hh24:mi:ss') WHERE TRAMID = :tramid";
            query["GetAllCleaners"] = "SELECT NAME FROM EMPLOYEE WHERE EMPLOYEETYPE = 'schoonmaker'";
            query["GetAllEngineers"] = "SELECT NAME FROM EMPLOYEE WHERE EMPLOYEETYPE = 'technicus'";
            query["maintenancefinished"] = "UPDATE MAINTENANCE SET DATEFINISHED = TO_DATE(:datefinished,'dd/mm/yyyy hh24:mi:ss'), FINISHEDBY = :employeeid WHERE TRAMID = :tramid AND TYPE = :type";
            query["addtramtoincoming"] = "INSERT INTO INCOMING (TRAMID, MOMENT) VALUES (:tramid, sysdate)";
            query["traincheckin"] = "UPDATE SECTOR SET ISRESERVED = 0 WHERE TRAMID = :tramid";
        }
    }
}
