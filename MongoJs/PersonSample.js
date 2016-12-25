var cn = new Mongo();
var db = cn.getDB("HboopDB");
db.Person.insert(
    [
        {
            "FirstName": "Dupont",
            "LastName": "Julien",
            "MiddleName": "",
            "Civility": "Monsieur",
            "BirthCountry": "France",
            "BirthDate": new Date(1369098122000),
            "ModifiedDate": new Date(1369098122000),
            "CreatedDate": new Date(1369098122000)
        },
        {
            "FirstName": "Eric",
            "LastName": "Valls",
            "MiddleName": "",
            "Civility": "Monsieur",
            "BirthCountry": "France",
            "BirthDate": new Date(1369098122000),
            "ModifiedDate": new Date(1369098122000),
            "CreatedDate": new Date(1369098122000)
        }
    ]);