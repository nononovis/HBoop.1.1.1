var cn = new Mongo();
var db = cn.getDB("HboopDB");
db.OrderDetail.insert(
    [
        {
            "Person":
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
            "BeneficiaryType":
            {
                "Name": "typename",
                "Description": "typedesc",
                "Code": "1"
            }
        }
    ]);