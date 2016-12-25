var cn = new Mongo();
var db = cn.getDB("HboopDB");
db.Affiliate.insert(
    [
        {
            "Store":
            {
                "Name": "LA JOIE",
                "Description": "Salon de coiffure",
                "Longitude":"",
                "Latitude":"",
                "Address":
                {
                    "Name":"BOUTIQUE",
                    "AddressLine1":"4,rue Spantani",
                    "AddressLine2":"",
                    "City":"Paris",
                    "ZipCode":"75016",
                    "Country":"PARIS",
                    "ModifiedDate": new Date(1369098122000),
                    "CreatedDate": new Date(1369098122000)
                },
                "ModifiedDate": new Date(1369098122000),
                "CreatedDate": new Date(1369098122000)
            },
            "AffiliateType":
            {
                "Name":"Fix",
                "Description":"Boutique",
                "Code":1        
            },
            "Name":"LA JOIE",
            "Description":"Salon de coiffure",
            "Status":"1",
            "ModifiedDate":new Date(1369098122000),
            "CreatedDate":new Date(1369098122000),
            "Users": [
                {
                    "Login":"lajoie.direction@lajoie.fr",
                    "Password":"123456",
                    "Mail": "lajoie.direction@lajoie.fr",
                    "Role":"1",
                    "Status":"1",
                    "ModifiedDate": new Date(1369098122000),
                    "CreatedDate": new Date(1369098122000)
                },
                {
                    "Login": "lajoie.contact1@lajoie.fr",
                    "Password": "123456",
                    "Mail": "lajoie.contact1@lajoie.fr",
                    "Role": "1",
                    "Status": "1",
                    "ModifiedDate": new Date(1369098122000),
                    "CreatedDate": new Date(1369098122000)
                }]
        }
        ,
                {
                    "Store":
                    {
                        "Name": "LE BONHEUR",
                        "Description": "Salon de BONHEUR",
                        "Longitude": "",
                        "Latitude": "",
                        "Address":
                        {
                            "Name": "BOUTIQUE",
                            "AddressLine1": "4,rue hamel",
                            "AddressLine2": "",
                            "City": "Paris",
                            "ZipCode": "75015",
                            "Country": "PARIS",
                            "ModifiedDate": new Date(1369098122000),
                            "CreatedDate": new Date(1369098122000)
                        },
                        "ModifiedDate": new Date(1369098122000),
                        "CreatedDate": new Date(1369098122000)
                    },
                    "AffiliateType":
                    {
                        "Name": "Fix",
                        "Description": "Boutique",
                        "Code": 1
                    },
                    "Name": "LA JOIE",
                    "Description": "Salon de coiffure",
                    "Status": "1",
                    "ModifiedDate": new Date(1369098122000),
                    "CreatedDate": new Date(1369098122000),
                    "Users": [
                        {
                            "Login": "lebonheur.direction@lebonheur.fr",
                            "Password": "123456",
                            "Mail": "lebonheur.direction@lebonheur.fr",
                            "Role": "1",
                            "Status": "1",
                            "ModifiedDate": new Date(1369098122000),
                            "CreatedDate": new Date(1369098122000)
                        },
                        {
                            "Login": "lebonheur.contact1@lebonheur.fr",
                            "Password": "123456",
                            "Mail": "lajoie.contact1@lebonheur.fr",
                            "Role": "1",
                            "Status": "1",
                            "ModifiedDate": new Date(1369098122000),
                            "CreatedDate": new Date(1369098122000)
                        }]
                }
    ]);