var cn = new Mongo();
var db = cn.getDB("HboopDB");
db.Product.insert(
    [
            {
                "Name": "Brushing",
                "Description": "Brushing",
                "Status": 1,
                "Time": {
                    "Hour": 0,
                    "Minute": 45,
                    "Second": 0
                },
                "Discount": {
                    "Name": "DsDecember2016",
                    "Description": "discount decembre 2016",
                    "Status": 1,
                    "Rate": 0.5,
                    "DateFrom": new Date(1369098122000),
                    "DateTo": new Date(1369098122000),
                    "ModifiedDate": new Date(1369098122000),
                    "CreatedDate": new Date(1369098122000)
                },
                "Price": {
                    "Name": "BrushingPrice",
                    "Description": "Brushing ",
                    "Status": 1,
                    "Rate": 0.5,
                    "UnitPrice": 27.75,
                    "ModifiedDate": new Date(1369098122000),
                    "CreatedDate": new Date(1369098122000)
                },
                "LogoPicture":
                 {
                     "Name": "",
                     "Description": "",
                     "Path": "",
                     "MediaType":
                      {
                          "Name": "Picture",
                          "Description": "Picture",
                          "Code": "02"
                      },
                     "ModifiedDate": new Date(1369098122000),
                     "CreatedDate": new Date(1369098122000)
                 },
                "ModifiedDate": new Date(1369098122000),
                "CreatedDate": new Date(1369098122000)
            },
                       {
                           "Name": "Coloration",
                           "Description": "Coloration",
                           "Status": 1,
                           "Time": {
                               "Hour": 0,
                               "Minute": 45,
                               "Second": 0
                           },
                           "Discount": {
                               "Name": "DsDecember2016",
                               "Description": "discount decembre 2016",
                               "Status": 1,
                               "Rate": 0.5,
                               "DateFrom": new Date(1369098122000),
                               "DateTo": new Date(1369098122000),
                               "ModifiedDate": new Date(1369098122000),
                               "CreatedDate": new Date(1369098122000)
                           },
                           "Price": {
                               "Name": "ColorationPrice",
                               "Description": "Coloration prix ",
                               "Status": 1,
                               "Rate": 0.5,
                               "UnitPrice": 27.75,
                               "ModifiedDate": new Date(1369098122000),
                               "CreatedDate": new Date(1369098122000)
                           },
                           "LogoPicture":
                            {
                                "Name": "",
                                "Description": "",
                                "Path": "",
                                "MediaType":
                                 {
                                     "Name": "Picture",
                                     "Description": "Picture",
                                     "Code": "02"
                                 },
                                "ModifiedDate": new Date(1369098122000),
                                "CreatedDate": new Date(1369098122000)
                            },
                           "ModifiedDate": new Date(1369098122000),
                           "CreatedDate": new Date(1369098122000)
                       }
    ]
    );