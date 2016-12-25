var cn = new Mongo();
var db = cn.getDB("HboopDB");
db.ProductCategory.insert(
    [
        {
            "Name": "Coiffure",
            "Description": "Coiffure",
            "Status": 1,
            "LogoPicture":
             {
                 "Name": "PictoCoffure",
                 "Description": "",
                 "Path": "C:\Users\Admin\Pictures\Camera Roll",
                 "MediaType":
                  {
                     "Name": "Picture",
                     "Description": "Picture",
                     "Code": "03"
                 },
                 "ModifiedDate": new Date(1369098122000),
                 "CreatedDate": new Date(1369098122000)
             },
            "Products":
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
            ],
            "ModifiedDate": new Date(1369098122000),
            "CreatedDate": new Date(1369098122000)
        },
		        {
            "Name": "Coiffure",
            "Description": "Coiffure",
            "Status": 1,
            "LogoPicture":
             {
                 "Name": "PictoCoffure",
                 "Description": "",
                 "Path": "C:\Users\Admin\Pictures\Camera Roll",
                 "MediaType":
                  {
                     "Name": "Picture",
                     "Description": "Picture",
                     "Code": "03"
                 },
                 "ModifiedDate": new Date(1369098122000),
                 "CreatedDate": new Date(1369098122000)
             },
            "Products":
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
            ],
            "ModifiedDate": new Date(1369098122000),
            "CreatedDate": new Date(1369098122000)
        },
		        {
            "Name": "Coiffure",
            "Description": "Coiffure",
            "Status": 1,
            "LogoPicture":
             {
                 "Name": "PictoCoffure",
                 "Description": "",
                 "Path": "C:\Users\Admin\Pictures\Camera Roll",
                 "MediaType":
                  {
                     "Name": "Picture",
                     "Description": "Picture",
                     "Code": "03"
                 },
                 "ModifiedDate": new Date(1369098122000),
                 "CreatedDate": new Date(1369098122000)
             },
            "Products":
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
            ],
            "ModifiedDate": new Date(1369098122000),
            "CreatedDate": new Date(1369098122000)
        }
    ]);
