var cn = new Mongo();
var db = cn.getDB("HboopDB");
db.Store.insert(
    [
        {
            "Name": "LA JOIE",
            "Description": "Salon de coiffure",
            "Longitude": -73.9557413,
            "Latitude": 40.7720266,
            "Address":
            {
                "Name": "BOUTIQUE",
                "AddressLine1": "4,rue Spantani",
                "AddressLine2": "",
                "City": "Paris",
                "ZipCode": "75016",
                "Country": "PARIS",
                "ModifiedDate": new Date(1369098122000),
                "CreatedDate": new Date(1369098122000)
            },
            "ModifiedDate": new Date(1369098122000),
            "CreatedDate": new Date(1369098122000)
        },
        {
            "Name": "LE Monde Coiffure",
            "Description": "Salon de coiffure",
            "Longitude": -72.9557413,
            "Latitude": 20.7720266,
            "Address":
            {
                "Name": "BOUTIQUE",
                "AddressLine1": "4,rue hamel",
                "AddressLine2": "",
                "City": "Paris",
                "ZipCode": "75017",
                "Country": "PARIS",
                "ModifiedDate": new Date(1369098122000),
                "CreatedDate": new Date(1369098122000)
            },
            "ModifiedDate": new Date(1369098122000),
            "CreatedDate": new Date(1369098122000)
        }
    ]);