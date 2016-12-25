var cn = new Mongo();
var db = cn.getDB("HboopDB");
db.User.insert(
[
      {
          "Login": "julien.dupont@gmail.com",
          "Password": "12345",
          "Mail": "julien.dupont@gmail.com",
          "Status": 1,
          "ModifiedDate": new Date(1369098122000),
          "CreatedDate": new Date(1369098122000)
      },
      {
          "Login": "marie.jean.hbboop@gmail.com",
          "Password": "12345",
          "Mail": "marie.jean.hbboop@gmail.com",
          "Status": 1,
          "ModifiedDate": new Date(1369098122000),
          "CreatedDate": new Date(1369098122000)
      }
 ]
);