var cn = new Mongo();
var db = cn.getDB("HboopDB");
db.Beneficiary.insert(
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
                "Code": "01"
            },
            "Address":[
            {
                "Name": "Maison",
                "AddressLine1": "3,rue pergelese",
                "AddressLine2": "",
                "City": "Paris",
                "ZipCode": "75015",
                "Country": "France",
                "AddressType":
                {
                    "Name": "MainAddress",
                    "Description": "Address major",
                    "Code": "10"
                },
                "ModifiedDate": new Date(1369098122000),
                "CreatedDate": new Date(1369098122000)
            },
            {
                "Name": "Billing Address",
                "AddressLine1": "3,rue pergelese",
                "AddressLine2": "",
                "City": "Paris",
                "ZipCode": "75015",
                "Country": "France",
                "AddressType":
                {
                    "Name": "BillingAddress",
                    "Description": "Address major",
                    "Code": "10"
                },
                "ModifiedDate": new Date(1369098122000),
                "CreatedDate": new Date(1369098122000)
            }],
            "User": 
             {
                    "Login": "julien.dupont@gmail.com",
                    "Password": "12345",
                    "Mail": "julien.dupont@gmail.com",
                    "Status": 1,
                    "ConnexionType":
                    {
                        "Name": "google",
                        "Description": "Connexion gmail",
                        "Code": "22"
                    },
                    "ModifiedDate": new Date(1369098122000),
                    "CreatedDate": new Date(1369098122000)
                },
            "Name": "Julien",
            "Description": "Monsieur Julien DUPONT",
            "Status": 1,
            "ModifiedDate": new Date(1369098122000),
            "CreatedDate": new Date(1369098122000)               
        }
    ]);